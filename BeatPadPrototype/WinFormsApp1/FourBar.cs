using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    /// <summary>
    /// Danny Nguyen
    /// 
    /// Represents the main form of the application for playing sound files in a loop.
    /// </summary>
    public partial class FourBar : Form
    {
        // Instance variables
        BeatSoundUpload uploadForm = new BeatSoundUpload();
        AudioPlayer player;
        string[] buttonFilepaths = new string[32];
        string buttonSound1Filepath;
        int selectedButtonIndex = -1;
        int currentButtonIndex = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="FourBar"/> class.
        /// </summary>
        public FourBar()
        {
            InitializeComponent();
            this.player = new AudioPlayer();
            InitializeButtons();
        }

        /// <summary>
        /// Initializes the buttons on the form and assigns event handlers.
        /// </summary>
        private void InitializeButtons()
        {
            // Initialize buttons and event handlers
            for (int i = 0; i < 32; i++)
            {
                Button button = Controls[$"button{i + 1}"] as Button;
                button.Click += Button_Click;
            }
        }

        /// <summary>
        /// Starts playing the sound files in a loop.
        /// </summary>
        private async Task PlayButtonsLoop()
        {
            while (true)
            {
                // Reset the background color of all buttons to white
                foreach (Control control in Controls)
                {
                    if (control is Button button)
                    {

                    }
                }

                // Loop through buttons
                for (int i = 0; i < 32; i++)
                {
                    if (selectedButtonIndex == i && !string.IsNullOrEmpty(buttonSound1Filepath))
                    {
                        // Change button color to red if it's the selected button
                        Controls[$"button{selectedButtonIndex + 1}"].BackColor = Color.Red;
                        // Play the sound asynchronously
                        await Task.Run(() => player.PlayAudio(buttonSound1Filepath));
                    }
                    // Move to the next button index
                    currentButtonIndex = (currentButtonIndex + 1) % 32;
                    await Task.Delay(250);
                }
            }
        }

        /// <summary>
        /// Event handler for button clicks. Toggles the selection of buttons and updates their background color.
        /// </summary>
        private void Button_Click(object sender, EventArgs e)
        {
            // Get the index of the clicked button
            Button clickedButton = sender as Button;
            int clickedIndex = int.Parse(clickedButton.Name.Substring(6)) - 1; // Extract the button index from its name

            // Toggle button selection
            if (selectedButtonIndex == clickedIndex)
            {
                // Deselect the button
                selectedButtonIndex = -1;
                clickedButton.BackColor = Color.White;
            }
            else
            {
                // Select the button
                selectedButtonIndex = clickedIndex;
                clickedButton.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// Event handler for uploading sound files. Assigns the uploaded file path to the current button.
        /// </summary>
        private void buttonUpload1_Click(object sender, EventArgs e)
        {
            // Reset upload form
            uploadForm.resetForm();
            // Show the upload form
            uploadForm.ShowDialog();

            // If user successfully uploads file
            if (uploadForm.filepath != null)
            {
                // Add the audio file path of the current button
                buttonFilepaths[currentButtonIndex] = uploadForm.filepath;
                // Enable the current button
                Controls[$"button{currentButtonIndex + 1}"].Enabled = true;
                // Change the button name if user added a name
                if (uploadForm.name != null)
                {
                    Controls[$"buttonSound1"].Text = uploadForm.name;
                }
            }
        }

        /// <summary>
        /// Event handler for assigning a sound file to buttonSound1 and starting the loop.
        /// </summary>
        private void buttonSound1_Click(object sender, EventArgs e)
        {
            // Set the selected sound file path for buttonSound1
            buttonSound1Filepath = uploadForm.filepath;
            // Start the loop if a sound file is selected for buttonSound1
            PlayButtonsLoop(); // Start the loop asynchronously
        }
    }
}
