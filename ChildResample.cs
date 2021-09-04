using System;
using System.Windows.Forms;

namespace audioKP
{
    public partial class ChildResample : Form
    {
        private string ofdNameAudio; //path of file
        int rate = 16000; //standart rate
        public string fileName
        {
            set
            {
                labelName.Text = "File: " + value;
            }

        }

        public string fileNameOfd
        {
            set
            {
                ofdNameAudio = value;
            }
        }

        public ChildResample()
        {
            InitializeComponent();
        }

        /// <summary>
        /// resampling and save new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(ofdNameAudio != null)
            {
                SaveFileDialog svd = new SaveFileDialog();
                svd.Filter = "WAV file|*.wav;";
                svd.FilterIndex = 2;
                if (svd.ShowDialog() == DialogResult.OK)
                {
                    Editor ed = new Editor();
                    string outputFile = svd.FileName;
                    ed.resampling(ofdNameAudio, outputFile, rate);
                }
            }
            else
            {
                MessageBox.Show("Input file for resampling!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// handling radio button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_Click(object sender, EventArgs e)
        {
            RadioButton radioBtn = (RadioButton)sender;
            switch (radioBtn.Name)
            {
                case "radioBtn16":
                    rate = 16000;
                    break;
                case "radioBtn32":
                    rate = 32000;
                    break;
                case "radioBtn44":
                    rate = 44100;
                    break;
                case "radioBtn48":
                    rate = 48000;
                    break;
                case "radioBtn96":
                    rate = 96000;
                    break;
                case "radioBtn192":
                    rate = 192000;
                    break;

            }
        }

        /// <summary>
        /// close this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
