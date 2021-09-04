namespace audioKP
{
    partial class ChildResample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtn192 = new System.Windows.Forms.RadioButton();
            this.radioBtn96 = new System.Windows.Forms.RadioButton();
            this.radioBtn16 = new System.Windows.Forms.RadioButton();
            this.radioBtn48 = new System.Windows.Forms.RadioButton();
            this.radioBtn32 = new System.Windows.Forms.RadioButton();
            this.radioBtn44 = new System.Windows.Forms.RadioButton();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(654, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(25, 25);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Х";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.radioBtn192);
            this.panel1.Controls.Add(this.radioBtn96);
            this.panel1.Controls.Add(this.radioBtn16);
            this.panel1.Controls.Add(this.radioBtn48);
            this.panel1.Controls.Add(this.radioBtn32);
            this.panel1.Controls.Add(this.radioBtn44);
            this.panel1.Location = new System.Drawing.Point(24, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 193);
            this.panel1.TabIndex = 10;
            // 
            // radioBtn192
            // 
            this.radioBtn192.AutoSize = true;
            this.radioBtn192.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtn192.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn192.ForeColor = System.Drawing.Color.White;
            this.radioBtn192.Location = new System.Drawing.Point(15, 156);
            this.radioBtn192.Name = "radioBtn192";
            this.radioBtn192.Size = new System.Drawing.Size(113, 22);
            this.radioBtn192.TabIndex = 20;
            this.radioBtn192.TabStop = true;
            this.radioBtn192.Text = "192000 Hz";
            this.radioBtn192.UseVisualStyleBackColor = true;
            this.radioBtn192.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioBtn96
            // 
            this.radioBtn96.AutoSize = true;
            this.radioBtn96.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtn96.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn96.ForeColor = System.Drawing.Color.White;
            this.radioBtn96.Location = new System.Drawing.Point(15, 129);
            this.radioBtn96.Name = "radioBtn96";
            this.radioBtn96.Size = new System.Drawing.Size(103, 22);
            this.radioBtn96.TabIndex = 19;
            this.radioBtn96.TabStop = true;
            this.radioBtn96.Text = "96000 Hz";
            this.radioBtn96.UseVisualStyleBackColor = true;
            this.radioBtn96.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioBtn16
            // 
            this.radioBtn16.AutoSize = true;
            this.radioBtn16.Checked = true;
            this.radioBtn16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtn16.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn16.ForeColor = System.Drawing.Color.White;
            this.radioBtn16.Location = new System.Drawing.Point(15, 17);
            this.radioBtn16.Name = "radioBtn16";
            this.radioBtn16.Size = new System.Drawing.Size(103, 22);
            this.radioBtn16.TabIndex = 0;
            this.radioBtn16.TabStop = true;
            this.radioBtn16.Text = "16000 Hz";
            this.radioBtn16.UseVisualStyleBackColor = true;
            this.radioBtn16.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioBtn48
            // 
            this.radioBtn48.AutoSize = true;
            this.radioBtn48.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtn48.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn48.ForeColor = System.Drawing.Color.White;
            this.radioBtn48.Location = new System.Drawing.Point(15, 101);
            this.radioBtn48.Name = "radioBtn48";
            this.radioBtn48.Size = new System.Drawing.Size(103, 22);
            this.radioBtn48.TabIndex = 18;
            this.radioBtn48.TabStop = true;
            this.radioBtn48.Text = "48000 Hz";
            this.radioBtn48.UseVisualStyleBackColor = true;
            this.radioBtn48.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioBtn32
            // 
            this.radioBtn32.AutoSize = true;
            this.radioBtn32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtn32.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn32.ForeColor = System.Drawing.Color.White;
            this.radioBtn32.Location = new System.Drawing.Point(15, 45);
            this.radioBtn32.Name = "radioBtn32";
            this.radioBtn32.Size = new System.Drawing.Size(103, 22);
            this.radioBtn32.TabIndex = 16;
            this.radioBtn32.TabStop = true;
            this.radioBtn32.Text = "32000 Hz";
            this.radioBtn32.UseVisualStyleBackColor = true;
            this.radioBtn32.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioBtn44
            // 
            this.radioBtn44.AutoSize = true;
            this.radioBtn44.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtn44.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn44.ForeColor = System.Drawing.Color.White;
            this.radioBtn44.Location = new System.Drawing.Point(15, 73);
            this.radioBtn44.Name = "radioBtn44";
            this.radioBtn44.Size = new System.Drawing.Size(103, 22);
            this.radioBtn44.TabIndex = 17;
            this.radioBtn44.TabStop = true;
            this.radioBtn44.Text = "44100 Hz";
            this.radioBtn44.UseVisualStyleBackColor = true;
            this.radioBtn44.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(24, 54);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 18);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "File:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select sampling rate for resampling:";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(274, 360);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 40);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ChildResample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(691, 492);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildResample";
            this.Text = "ChildResample";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RadioButton radioBtn192;
        private System.Windows.Forms.RadioButton radioBtn96;
        private System.Windows.Forms.RadioButton radioBtn16;
        private System.Windows.Forms.RadioButton radioBtn48;
        private System.Windows.Forms.RadioButton radioBtn32;
        private System.Windows.Forms.RadioButton radioBtn44;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
    }
}