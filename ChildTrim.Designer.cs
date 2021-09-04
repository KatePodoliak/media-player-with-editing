namespace audioKP
{
    partial class ChildTrim
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
            this.labelName = new System.Windows.Forms.Label();
            this.buttonCut = new System.Windows.Forms.Button();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(24, 54);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 18);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "File:";
            // 
            // buttonCut
            // 
            this.buttonCut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.buttonCut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonCut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCut.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCut.ForeColor = System.Drawing.Color.White;
            this.buttonCut.Location = new System.Drawing.Point(263, 205);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(150, 40);
            this.buttonCut.TabIndex = 1;
            this.buttonCut.Text = "Cut";
            this.buttonCut.UseVisualStyleBackColor = false;
            this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click);
            // 
            // textBoxStart
            // 
            this.textBoxStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.textBoxStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStart.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStart.ForeColor = System.Drawing.Color.White;
            this.textBoxStart.Location = new System.Drawing.Point(93, 108);
            this.textBoxStart.Multiline = true;
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(73, 21);
            this.textBoxStart.TabIndex = 2;
            this.textBoxStart.Text = "00:00:00";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart.ForeColor = System.Drawing.Color.White;
            this.labelStart.Location = new System.Drawing.Point(24, 108);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(58, 18);
            this.labelStart.TabIndex = 3;
            this.labelStart.Text = "Start:";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnd.ForeColor = System.Drawing.Color.White;
            this.labelEnd.Location = new System.Drawing.Point(24, 162);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(47, 18);
            this.labelEnd.TabIndex = 5;
            this.labelEnd.Text = "End:";
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.textBoxEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEnd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnd.ForeColor = System.Drawing.Color.White;
            this.textBoxEnd.Location = new System.Drawing.Point(93, 162);
            this.textBoxEnd.Multiline = true;
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(73, 21);
            this.textBoxEnd.TabIndex = 4;
            this.textBoxEnd.Text = "00:00:00";
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalTime.ForeColor = System.Drawing.Color.White;
            this.labelTotalTime.Location = new System.Drawing.Point(29, 196);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(0, 18);
            this.labelTotalTime.TabIndex = 6;
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
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Х";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ChildTrim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(691, 492);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelTotalTime);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.textBoxEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.buttonCut);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildTrim";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonCut;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.Button buttonClose;
    }
}