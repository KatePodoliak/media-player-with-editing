namespace audioKP
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReference = new System.Windows.Forms.Button();
            this.panelConvSub = new System.Windows.Forms.Panel();
            this.buttonToStereo = new System.Windows.Forms.Button();
            this.buttonToMono = new System.Windows.Forms.Button();
            this.buttonResampling = new System.Windows.Forms.Button();
            this.buttonWavToMp3 = new System.Windows.Forms.Button();
            this.buttonMp3ToWav = new System.Windows.Forms.Button();
            this.buttonСonverting = new System.Windows.Forms.Button();
            this.panelEditSub = new System.Windows.Forms.Panel();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.buttonCombine = new System.Windows.Forms.Button();
            this.buttonCut = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.panelFilesSub = new System.Windows.Forms.Panel();
            this.buttonCloseFiles = new System.Windows.Forms.Button();
            this.buttonOpenFiles = new System.Windows.Forms.Button();
            this.buttonFiles = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelChild = new System.Windows.Forms.Panel();
            this.labelNowPlay = new System.Windows.Forms.Label();
            this.picturePlayer = new System.Windows.Forms.PictureBox();
            this.panelPlay = new System.Windows.Forms.Panel();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.trackBarPlay = new System.Windows.Forms.TrackBar();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.boxPlayPause = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelSideMenu.SuspendLayout();
            this.panelConvSub.SuspendLayout();
            this.panelEditSub.SuspendLayout();
            this.panelFilesSub.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).BeginInit();
            this.panelPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.panelSideMenu.Controls.Add(this.buttonExit);
            this.panelSideMenu.Controls.Add(this.buttonReference);
            this.panelSideMenu.Controls.Add(this.panelConvSub);
            this.panelSideMenu.Controls.Add(this.buttonСonverting);
            this.panelSideMenu.Controls.Add(this.panelEditSub);
            this.panelSideMenu.Controls.Add(this.buttonEdit);
            this.panelSideMenu.Controls.Add(this.panelFilesSub);
            this.panelSideMenu.Controls.Add(this.buttonFiles);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(230, 565);
            this.panelSideMenu.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Image = global::audioKP.Properties.Resources.icon_exit;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(0, 675);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonExit.Size = new System.Drawing.Size(213, 40);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // buttonReference
            // 
            this.buttonReference.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReference.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReference.FlatAppearance.BorderSize = 0;
            this.buttonReference.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonReference.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReference.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReference.ForeColor = System.Drawing.Color.White;
            this.buttonReference.Image = global::audioKP.Properties.Resources.icon_help;
            this.buttonReference.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReference.Location = new System.Drawing.Point(0, 635);
            this.buttonReference.Name = "buttonReference";
            this.buttonReference.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonReference.Size = new System.Drawing.Size(213, 40);
            this.buttonReference.TabIndex = 8;
            this.buttonReference.Text = "Reference";
            this.buttonReference.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReference.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReference.UseVisualStyleBackColor = true;
            this.buttonReference.Click += new System.EventHandler(this.buttonReference_Click);
            // 
            // panelConvSub
            // 
            this.panelConvSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.panelConvSub.Controls.Add(this.buttonToStereo);
            this.panelConvSub.Controls.Add(this.buttonToMono);
            this.panelConvSub.Controls.Add(this.buttonResampling);
            this.panelConvSub.Controls.Add(this.buttonWavToMp3);
            this.panelConvSub.Controls.Add(this.buttonMp3ToWav);
            this.panelConvSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConvSub.Location = new System.Drawing.Point(0, 435);
            this.panelConvSub.Name = "panelConvSub";
            this.panelConvSub.Size = new System.Drawing.Size(213, 200);
            this.panelConvSub.TabIndex = 7;
            // 
            // buttonToStereo
            // 
            this.buttonToStereo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonToStereo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToStereo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonToStereo.FlatAppearance.BorderSize = 0;
            this.buttonToStereo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonToStereo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonToStereo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToStereo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToStereo.ForeColor = System.Drawing.Color.White;
            this.buttonToStereo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToStereo.Location = new System.Drawing.Point(0, 157);
            this.buttonToStereo.Name = "buttonToStereo";
            this.buttonToStereo.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.buttonToStereo.Size = new System.Drawing.Size(213, 39);
            this.buttonToStereo.TabIndex = 4;
            this.buttonToStereo.Text = "To stereo";
            this.buttonToStereo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToStereo.UseVisualStyleBackColor = false;
            this.buttonToStereo.Click += new System.EventHandler(this.buttonToStereo_Click);
            // 
            // buttonToMono
            // 
            this.buttonToMono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonToMono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToMono.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonToMono.FlatAppearance.BorderSize = 0;
            this.buttonToMono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonToMono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonToMono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToMono.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToMono.ForeColor = System.Drawing.Color.White;
            this.buttonToMono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToMono.Location = new System.Drawing.Point(0, 118);
            this.buttonToMono.Name = "buttonToMono";
            this.buttonToMono.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.buttonToMono.Size = new System.Drawing.Size(213, 39);
            this.buttonToMono.TabIndex = 3;
            this.buttonToMono.Text = "To mono";
            this.buttonToMono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToMono.UseVisualStyleBackColor = false;
            this.buttonToMono.Click += new System.EventHandler(this.buttonToMono_Click);
            // 
            // buttonResampling
            // 
            this.buttonResampling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonResampling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResampling.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonResampling.FlatAppearance.BorderSize = 0;
            this.buttonResampling.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonResampling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonResampling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResampling.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResampling.ForeColor = System.Drawing.Color.White;
            this.buttonResampling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResampling.Location = new System.Drawing.Point(0, 79);
            this.buttonResampling.Name = "buttonResampling";
            this.buttonResampling.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.buttonResampling.Size = new System.Drawing.Size(213, 39);
            this.buttonResampling.TabIndex = 2;
            this.buttonResampling.Text = "Resampling";
            this.buttonResampling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResampling.UseVisualStyleBackColor = false;
            this.buttonResampling.Click += new System.EventHandler(this.buttonResampling_Click);
            // 
            // buttonWavToMp3
            // 
            this.buttonWavToMp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonWavToMp3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWavToMp3.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonWavToMp3.FlatAppearance.BorderSize = 0;
            this.buttonWavToMp3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonWavToMp3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonWavToMp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWavToMp3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWavToMp3.ForeColor = System.Drawing.Color.White;
            this.buttonWavToMp3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWavToMp3.Location = new System.Drawing.Point(0, 40);
            this.buttonWavToMp3.Name = "buttonWavToMp3";
            this.buttonWavToMp3.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.buttonWavToMp3.Size = new System.Drawing.Size(213, 39);
            this.buttonWavToMp3.TabIndex = 1;
            this.buttonWavToMp3.Text = "WAV to MP3";
            this.buttonWavToMp3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWavToMp3.UseVisualStyleBackColor = false;
            this.buttonWavToMp3.Click += new System.EventHandler(this.buttonWavToMp3_Click);
            // 
            // buttonMp3ToWav
            // 
            this.buttonMp3ToWav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonMp3ToWav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMp3ToWav.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMp3ToWav.FlatAppearance.BorderSize = 0;
            this.buttonMp3ToWav.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonMp3ToWav.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonMp3ToWav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMp3ToWav.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMp3ToWav.ForeColor = System.Drawing.Color.White;
            this.buttonMp3ToWav.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMp3ToWav.Location = new System.Drawing.Point(0, 0);
            this.buttonMp3ToWav.Name = "buttonMp3ToWav";
            this.buttonMp3ToWav.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.buttonMp3ToWav.Size = new System.Drawing.Size(213, 40);
            this.buttonMp3ToWav.TabIndex = 0;
            this.buttonMp3ToWav.Text = "MP3 to WAV";
            this.buttonMp3ToWav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMp3ToWav.UseVisualStyleBackColor = false;
            this.buttonMp3ToWav.Click += new System.EventHandler(this.buttonMp3ToWav_Click);
            // 
            // buttonСonverting
            // 
            this.buttonСonverting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonСonverting.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonСonverting.FlatAppearance.BorderSize = 0;
            this.buttonСonverting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonСonverting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonСonverting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonСonverting.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonСonverting.ForeColor = System.Drawing.Color.White;
            this.buttonСonverting.Image = global::audioKP.Properties.Resources.icon_convertation;
            this.buttonСonverting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonСonverting.Location = new System.Drawing.Point(0, 395);
            this.buttonСonverting.Name = "buttonСonverting";
            this.buttonСonverting.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonСonverting.Size = new System.Drawing.Size(213, 40);
            this.buttonСonverting.TabIndex = 6;
            this.buttonСonverting.Text = "Сonverting";
            this.buttonСonverting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonСonverting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonСonverting.UseVisualStyleBackColor = true;
            this.buttonСonverting.Click += new System.EventHandler(this.buttonСonverting_Click);
            // 
            // panelEditSub
            // 
            this.panelEditSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.panelEditSub.Controls.Add(this.buttonReverse);
            this.panelEditSub.Controls.Add(this.buttonCombine);
            this.panelEditSub.Controls.Add(this.buttonCut);
            this.panelEditSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEditSub.Location = new System.Drawing.Point(0, 271);
            this.panelEditSub.Name = "panelEditSub";
            this.panelEditSub.Size = new System.Drawing.Size(213, 124);
            this.panelEditSub.TabIndex = 5;
            // 
            // buttonReverse
            // 
            this.buttonReverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonReverse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReverse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReverse.FlatAppearance.BorderSize = 0;
            this.buttonReverse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonReverse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReverse.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReverse.ForeColor = System.Drawing.Color.White;
            this.buttonReverse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReverse.Location = new System.Drawing.Point(0, 80);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.buttonReverse.Size = new System.Drawing.Size(213, 40);
            this.buttonReverse.TabIndex = 2;
            this.buttonReverse.Text = "Reverse";
            this.buttonReverse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReverse.UseVisualStyleBackColor = false;
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // buttonCombine
            // 
            this.buttonCombine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonCombine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCombine.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCombine.FlatAppearance.BorderSize = 0;
            this.buttonCombine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonCombine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonCombine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCombine.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCombine.ForeColor = System.Drawing.Color.White;
            this.buttonCombine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCombine.Location = new System.Drawing.Point(0, 40);
            this.buttonCombine.Name = "buttonCombine";
            this.buttonCombine.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.buttonCombine.Size = new System.Drawing.Size(213, 40);
            this.buttonCombine.TabIndex = 1;
            this.buttonCombine.Text = "Combine";
            this.buttonCombine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCombine.UseVisualStyleBackColor = false;
            this.buttonCombine.Click += new System.EventHandler(this.buttonCombine_Click);
            // 
            // buttonCut
            // 
            this.buttonCut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonCut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCut.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCut.FlatAppearance.BorderSize = 0;
            this.buttonCut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonCut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCut.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCut.ForeColor = System.Drawing.Color.White;
            this.buttonCut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCut.Location = new System.Drawing.Point(0, 0);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.buttonCut.Size = new System.Drawing.Size(213, 40);
            this.buttonCut.TabIndex = 0;
            this.buttonCut.Text = "Cut";
            this.buttonCut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCut.UseVisualStyleBackColor = false;
            this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Image = global::audioKP.Properties.Resources.icon_edit;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(0, 231);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonEdit.Size = new System.Drawing.Size(213, 40);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // panelFilesSub
            // 
            this.panelFilesSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.panelFilesSub.Controls.Add(this.buttonCloseFiles);
            this.panelFilesSub.Controls.Add(this.buttonOpenFiles);
            this.panelFilesSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilesSub.Location = new System.Drawing.Point(0, 150);
            this.panelFilesSub.Name = "panelFilesSub";
            this.panelFilesSub.Size = new System.Drawing.Size(213, 81);
            this.panelFilesSub.TabIndex = 1;
            // 
            // buttonCloseFiles
            // 
            this.buttonCloseFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonCloseFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCloseFiles.FlatAppearance.BorderSize = 0;
            this.buttonCloseFiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonCloseFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonCloseFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseFiles.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseFiles.ForeColor = System.Drawing.Color.White;
            this.buttonCloseFiles.Location = new System.Drawing.Point(0, 40);
            this.buttonCloseFiles.Name = "buttonCloseFiles";
            this.buttonCloseFiles.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.buttonCloseFiles.Size = new System.Drawing.Size(213, 40);
            this.buttonCloseFiles.TabIndex = 1;
            this.buttonCloseFiles.Text = "Close file";
            this.buttonCloseFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCloseFiles.UseVisualStyleBackColor = false;
            this.buttonCloseFiles.Click += new System.EventHandler(this.buttonCloseFiles_Click);
            // 
            // buttonOpenFiles
            // 
            this.buttonOpenFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonOpenFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOpenFiles.FlatAppearance.BorderSize = 0;
            this.buttonOpenFiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonOpenFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonOpenFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFiles.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFiles.ForeColor = System.Drawing.Color.White;
            this.buttonOpenFiles.Location = new System.Drawing.Point(0, 0);
            this.buttonOpenFiles.Name = "buttonOpenFiles";
            this.buttonOpenFiles.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.buttonOpenFiles.Size = new System.Drawing.Size(213, 40);
            this.buttonOpenFiles.TabIndex = 0;
            this.buttonOpenFiles.Text = "Open file";
            this.buttonOpenFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenFiles.UseVisualStyleBackColor = false;
            this.buttonOpenFiles.Click += new System.EventHandler(this.buttonOpenFiles_Click);
            // 
            // buttonFiles
            // 
            this.buttonFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFiles.FlatAppearance.BorderSize = 0;
            this.buttonFiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiles.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiles.ForeColor = System.Drawing.Color.White;
            this.buttonFiles.Image = global::audioKP.Properties.Resources.icon_file;
            this.buttonFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFiles.Location = new System.Drawing.Point(0, 110);
            this.buttonFiles.Name = "buttonFiles";
            this.buttonFiles.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonFiles.Size = new System.Drawing.Size(213, 40);
            this.buttonFiles.TabIndex = 0;
            this.buttonFiles.Text = "File";
            this.buttonFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFiles.UseVisualStyleBackColor = true;
            this.buttonFiles.Click += new System.EventHandler(this.buttonFiles_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(213, 110);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(67, 31);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(65, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.panelChild.Controls.Add(this.labelNowPlay);
            this.panelChild.Controls.Add(this.picturePlayer);
            this.panelChild.Controls.Add(this.panelPlay);
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(230, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(691, 565);
            this.panelChild.TabIndex = 2;
            // 
            // labelNowPlay
            // 
            this.labelNowPlay.AutoSize = true;
            this.labelNowPlay.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNowPlay.ForeColor = System.Drawing.Color.White;
            this.labelNowPlay.Location = new System.Drawing.Point(17, 401);
            this.labelNowPlay.Name = "labelNowPlay";
            this.labelNowPlay.Size = new System.Drawing.Size(0, 16);
            this.labelNowPlay.TabIndex = 2;
            // 
            // picturePlayer
            // 
            this.picturePlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picturePlayer.Image = ((System.Drawing.Image)(resources.GetObject("picturePlayer.Image")));
            this.picturePlayer.Location = new System.Drawing.Point(221, 110);
            this.picturePlayer.Name = "picturePlayer";
            this.picturePlayer.Size = new System.Drawing.Size(250, 237);
            this.picturePlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlayer.TabIndex = 1;
            this.picturePlayer.TabStop = false;
            // 
            // panelPlay
            // 
            this.panelPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.panelPlay.Controls.Add(this.labelEnd);
            this.panelPlay.Controls.Add(this.labelStart);
            this.panelPlay.Controls.Add(this.trackBarVolume);
            this.panelPlay.Controls.Add(this.trackBarPlay);
            this.panelPlay.Controls.Add(this.pictureBox5);
            this.panelPlay.Controls.Add(this.pictureBox4);
            this.panelPlay.Controls.Add(this.boxPlayPause);
            this.panelPlay.Controls.Add(this.pictureBox2);
            this.panelPlay.Controls.Add(this.pictureBox1);
            this.panelPlay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlay.Location = new System.Drawing.Point(0, 456);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(691, 109);
            this.panelPlay.TabIndex = 0;
            // 
            // labelEnd
            // 
            this.labelEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnd.ForeColor = System.Drawing.Color.White;
            this.labelEnd.Location = new System.Drawing.Point(626, 90);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(53, 16);
            this.labelEnd.TabIndex = 8;
            this.labelEnd.Text = "0:00:00";
            // 
            // labelStart
            // 
            this.labelStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart.ForeColor = System.Drawing.Color.White;
            this.labelStart.Location = new System.Drawing.Point(17, 90);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(53, 16);
            this.labelStart.TabIndex = 7;
            this.labelStart.Text = "0:00:00";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBarVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarVolume.Location = new System.Drawing.Point(515, 17);
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(173, 45);
            this.trackBarVolume.TabIndex = 6;
            this.trackBarVolume.Value = 10;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // trackBarPlay
            // 
            this.trackBarPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarPlay.Location = new System.Drawing.Point(6, 58);
            this.trackBarPlay.Maximum = 0;
            this.trackBarPlay.Name = "trackBarPlay";
            this.trackBarPlay.Size = new System.Drawing.Size(682, 45);
            this.trackBarPlay.TabIndex = 2;
            this.trackBarPlay.Scroll += new System.EventHandler(this.trackBarPlay_Scroll);
            this.trackBarPlay.ValueChanged += new System.EventHandler(this.trackBarPlay_ValueChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::audioKP.Properties.Resources.icon_sound;
            this.pictureBox5.Location = new System.Drawing.Point(468, 15);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::audioKP.Properties.Resources.icon_forward;
            this.pictureBox4.Location = new System.Drawing.Point(398, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // boxPlayPause
            // 
            this.boxPlayPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxPlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxPlayPause.Image = global::audioKP.Properties.Resources.icon_play;
            this.boxPlayPause.Location = new System.Drawing.Point(328, 15);
            this.boxPlayPause.Name = "boxPlayPause";
            this.boxPlayPause.Size = new System.Drawing.Size(32, 32);
            this.boxPlayPause.TabIndex = 2;
            this.boxPlayPause.TabStop = false;
            this.boxPlayPause.Click += new System.EventHandler(this.boxPlayPause_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::audioKP.Properties.Resources.icon_back;
            this.pictureBox2.Location = new System.Drawing.Point(258, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::audioKP.Properties.Resources.icon_playlist;
            this.pictureBox1.Location = new System.Drawing.Point(188, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(921, 565);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio player";
            this.panelSideMenu.ResumeLayout(false);
            this.panelConvSub.ResumeLayout(false);
            this.panelEditSub.ResumeLayout(false);
            this.panelFilesSub.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelChild.ResumeLayout(false);
            this.panelChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).EndInit();
            this.panelPlay.ResumeLayout(false);
            this.panelPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelFilesSub;
        private System.Windows.Forms.Button buttonCloseFiles;
        private System.Windows.Forms.Button buttonOpenFiles;
        private System.Windows.Forms.Button buttonFiles;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelEditSub;
        private System.Windows.Forms.Button buttonCombine;
        private System.Windows.Forms.Button buttonCut;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Panel panelPlay;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox picturePlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.TrackBar trackBarPlay;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox boxPlayPause;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelNowPlay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonСonverting;
        private System.Windows.Forms.Panel panelConvSub;
        private System.Windows.Forms.Button buttonResampling;
        private System.Windows.Forms.Button buttonWavToMp3;
        private System.Windows.Forms.Button buttonMp3ToWav;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReference;
        private System.Windows.Forms.Button buttonToMono;
        private System.Windows.Forms.Button buttonToStereo;
        private System.Windows.Forms.Button buttonReverse;
    }
}

