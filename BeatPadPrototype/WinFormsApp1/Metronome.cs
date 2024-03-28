using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Metronome : Form
    {
        private const int UpperLimit = 400;
        private const int LowerLimit = 20;
        private int bpm = 60;
        public Metronome()
        {
            InitializeComponent();
            bpmBox.Text = bpm.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bpmBox_TextChanged(object sender, EventArgs e)
        {
            bool isNumerical = int.TryParse(bpmBox.Text, out int Int);
            if (!isNumerical)
            {
                bpmBox.Text = "60";
            }
            else // this does not work
            {
                // if bpmBox text is more than lower limit or less than upper limit
                if (LowerLimit <= int.Parse(bpmBox.Text) && int.Parse(bpmBox.Text) <= UpperLimit)
                {
                    bpm = int.Parse(bpmBox.Text);
                }
                else
                {
                    bpm = int.Parse(bpmBox.Text) > UpperLimit ? UpperLimit : LowerLimit;
                }
                bpmBox.Text = bpm.ToString();

            }
        }

        private void Metronome_Load(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int bpmUpperRange = UpperLimit - LowerLimit;
            float maxScrollValue = 91f;
            float scrollValue = hScrollBar1.Value / maxScrollValue;
            int finalBpm = (int) (LowerLimit + (bpmUpperRange * scrollValue));
            bpmBox.Text = finalBpm.ToString();
        }

    }
}
