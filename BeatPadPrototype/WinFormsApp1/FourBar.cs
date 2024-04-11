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
        string buttonSound2Filepath;
        string buttonSound3Filepath;
        string buttonSound4Filepath;
        int currentButtonIndex = 0;
        HashSet<int> sound1ClickedButtonIndexes = new HashSet<int>();
        HashSet<int> sound2ClickedButtonIndexes = new HashSet<int>();
        HashSet<int> sound3ClickedButtonIndexes = new HashSet<int>();
        HashSet<int> sound4ClickedButtonIndexes = new HashSet<int>();
        int soundButtonAt = 1;


        /// <summary>
        /// Initializes a new instance of the <see cref="FourBar"/> class.
        /// </summary>
        public FourBar()
        {
            InitializeComponent();
            this.player = new AudioPlayer();
            InitializeButtons();
            PlayButtonsLoop();

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
                for (int i = 0; i < 32; i++)
                {
                    if (sound1ClickedButtonIndexes.Contains(i) || sound2ClickedButtonIndexes.Contains(i)  || sound3ClickedButtonIndexes.Contains(i) || sound4ClickedButtonIndexes.Contains(i))
                    {
                        if (sound1ClickedButtonIndexes.Contains(i))
                        {
                            // Play the sound asynchronously
                            await Task.Run(() => player.PlayAudio(buttonSound1Filepath));
                            currentButtonIndex = (currentButtonIndex + 1) % 32;
                            await Task.Delay(250);
                        }
                        if (sound2ClickedButtonIndexes.Contains(i))
                        {
                            // Play the sound asynchronously
                            await Task.Run(() => player.PlayAudio(buttonSound2Filepath));
                            currentButtonIndex = (currentButtonIndex + 1) % 32;
                            await Task.Delay(250);
                        }
                        if (sound3ClickedButtonIndexes.Contains(i))
                        {
                            // Play the sound asynchronously
                            await Task.Run(() => player.PlayAudio(buttonSound3Filepath));
                            currentButtonIndex = (currentButtonIndex + 1) % 32;
                            await Task.Delay(250);
                        }
                        if (sound4ClickedButtonIndexes.Contains(i))
                        {
                            // Play the sound asynchronously
                            await Task.Run(() => player.PlayAudio(buttonSound4Filepath));
                            currentButtonIndex = (currentButtonIndex + 1) % 32;
                            await Task.Delay(250);
                        }
                    }
                    else
                    {
                        Controls[$"button{i + 1}"].BackColor = Color.Green;
                        await Task.Delay(250);
                        Controls[$"button{i + 1}"].BackColor = Color.White;
                        currentButtonIndex = (currentButtonIndex + 1) % 32;
                    }
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
            if (sound1ClickedButtonIndexes.Contains(clickedIndex))
            {
                // Deselect the button
                sound1ClickedButtonIndexes.Remove(clickedIndex);
                clickedButton.BackColor = Color.White;
            }
            else
            {
                // Select the button
                sound1ClickedButtonIndexes.Add(clickedIndex);
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
                // Assign the uploaded file path to buttonSound1
                buttonSound1Filepath = uploadForm.filepath;
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
        /// Event handler for uploading sound files. Assigns the uploaded file path to the current button.
        /// </summary>
        private void buttonUpload2_Click(object sender, EventArgs e)
        {
            // Reset upload form
            uploadForm.resetForm();
            // Show the upload form
            uploadForm.ShowDialog();

            // If user successfully uploads file
            if (uploadForm.filepath != null)
            {
                // Assign the uploaded file path to buttonSound2
                buttonSound2Filepath = uploadForm.filepath;
                // Enable the current button
                Controls[$"button{currentButtonIndex + 1}"].Enabled = true;
                // Change the button name if user added a name
                if (uploadForm.name != null)
                {
                    Controls[$"buttonSound2"].Text = uploadForm.name;
                }
            }
        }

        /// <summary>
        /// Event handler for uploading sound files. Assigns the uploaded file path to the current button.
        /// </summary>
        private void buttonUpload3_Click(object sender, EventArgs e)
        {
            // Reset upload form
            uploadForm.resetForm();
            // Show the upload form
            uploadForm.ShowDialog();

            // If user successfully uploads file
            if (uploadForm.filepath != null)
            {
                // Assign the uploaded file path to buttonSound3
                buttonSound3Filepath = uploadForm.filepath;
                // Enable the current button
                Controls[$"button{currentButtonIndex + 1}"].Enabled = true;
                // Change the button name if user added a name
                if (uploadForm.name != null)
                {
                    Controls[$"buttonSound3"].Text = uploadForm.name;
                }
            }
        }

        /// <summary>
        /// Event handler for uploading sound files. Assigns the uploaded file path to the current button.
        /// </summary>
        private void buttonUpload4_Click(object sender, EventArgs e)
        {
            // Reset upload form
            uploadForm.resetForm();
            // Show the upload form
            uploadForm.ShowDialog();

            // If user successfully uploads file
            if (uploadForm.filepath != null)
            {
                // Assign the uploaded file path to buttonSound4
                buttonSound4Filepath = uploadForm.filepath;
                // Enable the current button
                Controls[$"button{currentButtonIndex + 1}"].Enabled = true;
                // Change the button name if user added a name
                if (uploadForm.name != null)
                {
                    Controls[$"buttonSound4"].Text = uploadForm.name;
                }
            }
        }

        /// <summary>
        /// Event handler for assigning a sound file to buttonSound1 and starting the loop.
        /// </summary>
        private async void buttonSound1_Click(object sender, EventArgs e)
        {
            soundButtonAt = 1;
            buttonSound1Filepath = uploadForm.filepath;
            if (!string.IsNullOrEmpty(buttonSound1Filepath))
            {
                await Task.Run(() => player.PlayAudio(buttonSound1Filepath)); // Play the sound once
            }
        }

        private async void buttonSound2_Click(object sender, EventArgs e)
        {
            soundButtonAt = 2;
            buttonSound2Filepath = uploadForm.filepath;
            if (!string.IsNullOrEmpty(buttonSound2Filepath))
            {
                await Task.Run(() => player.PlayAudio(buttonSound2Filepath)); // Play the sound once
            }
        }

        private async void buttonSound3_Click(object sender, EventArgs e)
        {
            soundButtonAt = 3;
            buttonSound3Filepath = uploadForm.filepath;
            if (!string.IsNullOrEmpty(buttonSound3Filepath))
            {
                await Task.Run(() => player.PlayAudio(buttonSound3Filepath)); // Play the sound once
            }
        }

        private async void buttonSound4_Click(object sender, EventArgs e)
        {
            soundButtonAt = 4;
            buttonSound4Filepath = uploadForm.filepath;
            if (!string.IsNullOrEmpty(buttonSound4Filepath))
            {
                await Task.Run(() => player.PlayAudio(buttonSound4Filepath)); // Play the sound once
            }
        }
    }
}
