using System;
using WMPLib;
using System.Windows.Forms;
using System.IO;

namespace audioKP
{
    public partial class Main : Form
    {
        public string fileNameOfd, fileName; //name and path of file

        WindowsMediaPlayer wmp; //object for audio

        SaveFileDialog svd;
        OpenFileDialog ofd;
        ChildTrim ct; //object of class ChildTrim
        ChildCombine cc; //object of class ChildCombine
        ChildResample cr; //object of class ChildResample
        Editor ed; //object of class Editor

        bool playpause; //state 
        bool left = true; //direction of the scrolling line of the file name
        int trackInfo = 0; //number of creeping characters



        public Main()
        {
            InitializeComponent();
            hideSub();
            wmp = new WindowsMediaPlayer();
            trackBarPlay.Enabled = false;
            trackBarVolume.Enabled = false;
            timer.Enabled = false;
            ed = new Editor();
            ct = new ChildTrim();
            cc = new ChildCombine();
            cr = new ChildResample();
        }

        /// <summary>
        /// open file and play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenFiles_Click(object sender, EventArgs e)
        {
            hideSub();
            ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Audio files (*.mp3; *.wav)|*.mp3;*.wav;|MP3 files|*.mp3|WAV files|*.wav";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileNameOfd = ofd.FileName;
                fileName = ofd.SafeFileName;
                wmp.URL = fileNameOfd;
                wmp.controls.play();
                wmp.controls.play();
                boxPlayPause.Image = Properties.Resources.icon_stop;
                trackBarPlay.Enabled = true;
                trackBarVolume.Enabled = true;
                timer.Enabled = true;
                timer.Interval = 1000;
                labelNowPlay.Text = fileName;
                ct.fileName = fileName;
                ct.fileNameOfd = fileNameOfd;
                cc.fileName = fileName;
                cc.fileNameOfd = fileNameOfd;
                cr.fileName = fileName;
                cr.fileNameOfd = fileNameOfd;
            }
        }

        /// <summary>
        /// reversing audio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReverse_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileNameOfd != null)
                {
                    svd = new SaveFileDialog();
                    svd.Filter = "Audio File (*.wav)|*.wav";
                    if (svd.ShowDialog() == DialogResult.OK)
                    {
                        string outfile = svd.FileName;
                        Reversing rv = new Reversing(fileNameOfd, outfile);
                        rv.reverse();
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
        /// close current file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCloseFiles_Click(object sender, EventArgs e)
        {
            hideSub();
            wmp.controls.stop();
            fileName = "";
            labelNowPlay.Text = "";
            trackBarPlay.Enabled = false;
            trackBarVolume.Enabled = false;
            boxPlayPause.Image = Properties.Resources.icon_play;
        }

        /// <summary>
        /// open form for cutting audio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCut_Click(object sender, EventArgs e)
        {
            hideSub();
            openChildForm(ct);
        }

        /// <summary>
        /// open form for combine audio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCombine_Click(object sender, EventArgs e)
        {
            hideSub();
            openChildForm(cc);
        }

        /// <summary>
        /// open form for resampling audio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResampling_Click(object sender, EventArgs e)
        {
            hideSub();
            openChildForm(cr);
        }

        /// <summary>
        /// opening child form
        /// </summary>
        /// <param name="child"></param>
        private void openChildForm(Form child)
        {
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelChild.Controls.Add(child);
            panelChild.Tag = child;
            child.BringToFront();
            child.Show();
        }

        /// <summary>
        /// change current position of audio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarPlay_Scroll(object sender, EventArgs e)
        {
            wmp.controls.currentPosition = trackBarPlay.Value;
        }

        /// <summary>
        /// change volume of audio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            wmp.settings.volume = trackBarVolume.Value * 10;
        }

        /// <summary>
        /// display of current track time and total duration, creeping line of the name of the current track
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            trackBarPlay.Maximum = Convert.ToInt32(wmp.currentMedia.duration);
            trackBarPlay.Value = Convert.ToInt32(wmp.controls.currentPosition);
            if (fileName != "")
            {
                int s = (int)wmp.currentMedia.duration;
                int h = s / 3600;
                int m = (s - (h * 3600)) / 60; 
                s = s - (h * 3600 + m * 60);
                labelEnd.Text = String.Format("{0:D}:{1:D2}:{2:D2}", h, m, s);
                s = (int)wmp.controls.currentPosition;
                h = s / 3600;
                m = (s - (h * 3600)) / 60;
                s = s - (h * 3600 + m * 60);
                labelStart.Text = String.Format("{0:D}:{1:D2}:{2:D2}", h, m, s);
            }
            else
            {
                labelEnd.Text = "0:00:00";
                labelStart.Text = "0:00:00";
            }
            if (trackInfo <= fileName.Length)
            {
                timer.Interval = 200;
                if (left)
                    labelNowPlay.Text = fileName.Substring(trackInfo, fileName.Length - trackInfo);
                else
                    labelNowPlay.Text = fileName.Substring(fileName.Length - trackInfo, trackInfo);
                trackInfo++;
            }
            else
            {
                trackInfo = 0;
                if (left)
                    left = false;
                else
                    left = true;
            }
        }

        /// <summary>
        /// change of state and icon (play, stop) by pressing the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boxPlayPause_Click(object sender, EventArgs e)
        {
            if (fileName != "")
            {
                playpause = !playpause;
                if (playpause)
                {
                    wmp.controls.pause();
                    boxPlayPause.Image = Properties.Resources.icon_play;
                    boxPlayPause.Refresh();
                }
                if (!playpause)
                {
                    wmp.controls.play();
                    boxPlayPause.Image = Properties.Resources.icon_stop;
                    boxPlayPause.Refresh();
                }
            }
        }

        /// <summary>
        /// hide submenu
        /// </summary>
        private void hideSub()
        {
            panelFilesSub.Visible = false;
            panelEditSub.Visible = false;
            panelConvSub.Visible = false;
        }
        /// <summary>
        /// show submenu
        /// </summary>
        /// <param name="menuSub"></param>
        private void showSub(Panel menuSub)
        {
            if (menuSub.Visible == false)
            {
                hideSub();
                menuSub.Visible = true;
            }
            else
                menuSub.Visible = false;
        }

        /// <summary>
        /// call a method to open a submenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFiles_Click(object sender, EventArgs e)
        {
            showSub(panelFilesSub);
        }

        /// <summary>
        /// call a method to open a submenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            showSub(panelEditSub);
        }

        /// <summary>
        /// call a method to open a submenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonСonverting_Click(object sender, EventArgs e)
        {
            showSub(panelConvSub);
        }

        /// <summary>
        /// changing the icon at the end of the track
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarPlay_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarPlay.Value == Convert.ToInt32(wmp.currentMedia.duration))
            {
                boxPlayPause.Image = Properties.Resources.icon_play;
                boxPlayPause.Refresh();
            }
        }

        /// <summary>
        /// converting mp3 to wav
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMp3ToWav_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileNameOfd != null)
                {
                    svd = new SaveFileDialog();
                    svd.Filter = "Audio File (*.wav)|*.wav";
                    svd.DefaultExt = "wav";
                    if (svd.ShowDialog() == DialogResult.OK)
                    {
                        string outFile = svd.FileName;
                        ed.mp3ToWav(fileNameOfd, outFile);
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
        /// converting wav to mp3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWavToMp3_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileNameOfd != null)
                {
                    svd = new SaveFileDialog();
                    svd.Filter = "Audio File (*.mp3)|*.mp3";
                    svd.DefaultExt = "mp3";
                    if (svd.ShowDialog() == DialogResult.OK)
                    {
                        string outFile = svd.FileName;
                        ed.wavToMP3(fileNameOfd, outFile);
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
        /// calling the audio converting method to mono type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonToMono_Click(object sender, EventArgs e)
        {
            try 
            {
                if (fileNameOfd != null)
                {
                    svd = new SaveFileDialog();
                    svd.Filter = "Audio File (*.wav)|*.wav";
                    if (svd.ShowDialog() == DialogResult.OK)
                    {
                        string outFile = svd.FileName;
                        ed.changeType(fileNameOfd, outFile, 1);
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
        /// calling the audio converting method to stereo type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonToStereo_Click(object sender, EventArgs e)
        {
            try
            {
                if(fileNameOfd != null)
                {
                    svd = new SaveFileDialog();
                    svd.Filter = "Audio File (*.wav)|*.wav";
                    if (svd.ShowDialog() == DialogResult.OK)
                    {
                        string outFile = svd.FileName;
                        ed.changeType(fileNameOfd, outFile, 2);
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

        private void buttonReference_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// exit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
