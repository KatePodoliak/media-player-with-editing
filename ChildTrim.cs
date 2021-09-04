using System;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace audioKP
{
    public partial class ChildTrim : Form
    {
        private string ofdNameAudio, ext, timeStart, timeEnd;
        TimeSpan ts1, ts2;
        SaveFileDialog svd;

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
                ext = Path.GetExtension(ofdNameAudio);
            }
        }

        public ChildTrim()
        {
            InitializeComponent();
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            try
            {
                svd = new SaveFileDialog();
                timeStart = textBoxStart.Text;
                ts1 = TimeSpan.Parse(timeStart);
                timeEnd = textBoxEnd.Text;
                ts2 = TimeSpan.Parse(timeEnd);
                if (ofdNameAudio != null)
                {
                    if (validTime(timeStart) && validTime(timeEnd))
                    {
                        switch (ext)
                        {
                            case ".mp3":
                                svd.Filter = "Audio File (*.mp3;)|*.mp3";
                                if (svd.ShowDialog() == DialogResult.OK)
                                {
                                    string outputPath = svd.FileName;
                                    if (outputPath != null)
                                        Editor.trimMP3(ofdNameAudio, outputPath, ts1, ts2);
                                    else
                                        throw new Exception("No file selected to save!");
                                }
                                break;
                            case ".wav":
                                svd.Filter = "WAV files|*.wav";
                                if (svd.ShowDialog() == DialogResult.OK)
                                {
                                    string outputPath = svd.FileName;
                                    if (outputPath != null)
                                        Editor.trimWav(ofdNameAudio, outputPath, ts1, ts2);
                                    else
                                        throw new Exception("No file selected to save!");
                                }
                                break;
                        }
                        textBoxStart.Text = "00:00:00";
                        textBoxEnd.Text = "00:00:00";
                    }
                    else
                    {
                        throw new Exception("Incorrect start and end times of a new track!");
                    }
                }
                else
                {
                    throw new Exception("Open the file for editing!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// checking the entered time in textboxes
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool validTime(string time)
        {
            DateTime dDate;
            if (DateTime.TryParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dDate))
                return true;
            else
                return false;
        }

        /// <summary>
        /// close this child form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
