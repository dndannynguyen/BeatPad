using System;
using System.Drawing;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    /// <summary>
    /// Danny Nguyen
    /// 
    /// Represents the main form of the application for playing sound files in a loop of the four bar beat formation.
    /// </summary>
    public partial class FourBar : Form
    {
        private bool isRunning = false;
        BeatSoundUpload uploadForm = new BeatSoundUpload();
        AudioPlayer player;
        string[] buttonFilepaths = new string[32];
        string[] buttonSoundFilepaths = new string[4];
        int currentButtonIndex = 0;
        HashSet<int>[] soundClickedButtonIndexes = new HashSet<int>[4]; // Array to store clicked button indexes for each sound button
        int soundButtonAt = 1;
        int bpmValue = 240;


        /// <summary>
        /// Initializes a new instance of the <see cref="FourBar"/> class.
        /// </summary>
        public FourBar()
        {
            InitializeComponent();
            this.FormClosing += FourBarClosing;
            this.player = new AudioPlayer();
            InitializeButtons();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            for (int i = 0; i < 4; i++)
            {
                soundClickedButtonIndexes[i] = new HashSet<int>();
            }
            isRunning = true;
            PlayButtonsLoop();

        }

        private void FourBarClosing(object sender, FormClosingEventArgs e)
        {
            isRunning = false;
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
            while (isRunning)
            {
                for (int i = 0; i < 32; i++)
                {
                    if (!isRunning) break;

                    if (soundClickedButtonIndexes[0].Contains(i) || soundClickedButtonIndexes[1].Contains(i) || soundClickedButtonIndexes[2].Contains(i) || soundClickedButtonIndexes[3].Contains(i))
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (!isRunning) break;

                            if (soundClickedButtonIndexes[j].Contains(i))
                            {
                                // Play the sound asynchronously
                                await Task.Run(() => player.PlayAudio(buttonSoundFilepaths[j]));
                                await Task.Delay(bpmValue);
                                currentButtonIndex = (currentButtonIndex + 1) % 32;
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            // If the button is not set to play sounds in the period, keep the green background going through.
                            Controls[$"button{i + 1}"].BackColor = Color.Green;
                            await Task.Delay(bpmValue);
                            Controls[$"button{i + 1}"].BackColor = Color.White;
                            currentButtonIndex = (currentButtonIndex + 1) % 32;
                        }
                        catch
                        {
                            isRunning = false;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Event handler for button clicks. Toggles the selection of buttons and updates their background color.
        /// </summary>
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int clickedIndex = int.Parse(clickedButton.Name.Substring(6)) - 1;

            // Select the sound button
            soundClickedButtonIndexes[soundButtonAt - 1].SymmetricExceptWith(new HashSet<int> { clickedIndex });
            clickedButton.BackColor = soundClickedButtonIndexes[soundButtonAt - 1].Contains(clickedIndex) ? Color.Pink : Color.White;
        }

        /// <summary>
        /// Event handler for uploading sound files. Assigns the uploaded file path to the current button.
        /// </summary>
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            Button uploadButton = sender as Button;
            int soundButtonIndex = int.Parse(uploadButton.Name.Substring(12, 1));

            uploadForm.resetForm();
            uploadForm.ShowDialog();

            if (uploadForm.filepath != null)
            {
                buttonSoundFilepaths[soundButtonIndex - 1] = uploadForm.filepath;
                Controls[$"button{currentButtonIndex + 1}"].Enabled = true;
                if (uploadForm.name != null)
                {
                    Controls[$"buttonSound{soundButtonIndex}"].Text = uploadForm.name;
                }
            }
        }

        /// <summary>
        /// Event handler for when a sound button is clicked. Sets the currently selected sound button and refreshes the UI accordingly.
        /// </summary>
        private void buttonSound_Click(object sender, EventArgs e)
        {
            Button soundButton = sender as Button;
            soundButtonAt = int.Parse(soundButton.Name.Substring(11, 1));
            RefreshUI();
            ShowUI();
        }

        /// <summary>
        /// Shows the UI configuration for the currently selected sound button, highlighting the buttons that are selected.
        /// </summary>
        private void ShowUI()
        {
            for (int i = 0; i < 32; i++)
            {
                Button button = Controls[$"button{i + 1}"] as Button;
                button.BackColor = soundClickedButtonIndexes[soundButtonAt - 1].Contains(i) ? Color.Pink : Color.White;
            }
        }

        /// <summary>
        /// Refreshes the UI for all 32 buttons, resetting their colors to default.
        /// </summary>
        private void RefreshUI()
        {
            for (int i = 0; i < 32; i++)
            {
                Button button = Controls[$"button{i + 1}"] as Button;
                button.BackColor = Color.White;
            }
        }

        /// <summary>
        /// When the BPM value is changed, updates the BPM value and resets the current button index.
        /// </summary>
        private void buttonApply_Click(object sender, EventArgs e)
        {
            int bpmInput = (int)numberBox.Value;
            if (bpmInput > 0)
            {
                bpmValue = 60000 / bpmInput;
            }
        }
    }
}
