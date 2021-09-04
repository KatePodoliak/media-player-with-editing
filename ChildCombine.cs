using System;
using System.Windows.Forms;


namespace audioKP
{
    public partial class ChildCombine : Form
    {
        private string path1, path2;
        String[] files;
        Editor ed = new Editor();
        SaveFileDialog svd;

        public string fileName
        {
            set
            {
                labelName1.Text = "First file: " + value;
            }
        }

        public string fileNameOfd
        {
            set
            {
                path1 = value;
            }
        }
        public ChildCombine()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //open second file for combine
        private void buttonOpenCmb_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.RestoreDirectory = true;
            ofd.Filter = "MP3 files|*.mp3";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path2 = ofd.FileName;
                labelName2.Text = "Second file: " + ofd.SafeFileName;
            }
        }


        private void buttonCmb_Click(object sender, EventArgs e)
        {
            try
            {
                files = new String[2] { path1, path2 };
                svd = new SaveFileDialog();
                svd.Filter = "MP3 file|*.mp3";
                if (files.Length == 2)
                {
                    if (svd.ShowDialog() == DialogResult.OK)
                    {
                        string outputFile = svd.FileName;
                        ed.combineMp3(files, outputFile);
                    }
                }
                else
                {
                    throw new Exception("Open two files to combine!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
