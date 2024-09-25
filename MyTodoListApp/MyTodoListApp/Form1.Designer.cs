namespace MyTodoListApp
{
    partial class Form1
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
            this.tbArtistInput = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblSongName = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTryAgain = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblDirection = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panelSongName = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tbArtistInput
            // 
            this.tbArtistInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArtistInput.Location = new System.Drawing.Point(102, 197);
            this.tbArtistInput.Name = "tbArtistInput";
            this.tbArtistInput.Size = new System.Drawing.Size(155, 26);
            this.tbArtistInput.TabIndex = 0;
            this.tbArtistInput.TextChanged += new System.EventHandler(this.tbArtistInput_TextChanged);
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(39, 200);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(57, 20);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "Artist:";
            // 
            // lblSongName
            // 
            this.lblSongName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.ForeColor = System.Drawing.Color.Teal;
            this.lblSongName.Location = new System.Drawing.Point(125, 122);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(59, 24);
            this.lblSongName.TabIndex = 2;
            this.lblSongName.Text = "Song";
            this.lblSongName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSongName.Click += new System.EventHandler(this.lblSongName_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(27, 55);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(253, 29);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Who sang this song?";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTryAgain
            // 
            this.lblTryAgain.AutoSize = true;
            this.lblTryAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTryAgain.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTryAgain.Location = new System.Drawing.Point(98, 259);
            this.lblTryAgain.Name = "lblTryAgain";
            this.lblTryAgain.Size = new System.Drawing.Size(119, 24);
            this.lblTryAgain.TabIndex = 4;
            this.lblTryAgain.Text = "Try Again :(";
            this.lblTryAgain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCorrect.Location = new System.Drawing.Point(98, 259);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(115, 24);
            this.lblCorrect.TabIndex = 5;
            this.lblCorrect.Text = "Correct ^_^";
            this.lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnStart.Location = new System.Drawing.Point(114, 320);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 36);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirection.Location = new System.Drawing.Point(28, 105);
            this.lblDirection.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(242, 60);
            this.lblDirection.TabIndex = 7;
            this.lblDirection.Text = "Direction: Song names will be flashed for 15 seconds, you must guess who is the a" +
    "rtist";
            this.lblDirection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDirection.Click += new System.EventHandler(this.lblDirection_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubmit.Location = new System.Drawing.Point(114, 320);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 36);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panelSongName
            // 
            this.panelSongName.Location = new System.Drawing.Point(32, 105);
            this.panelSongName.Name = "panelSongName";
            this.panelSongName.Size = new System.Drawing.Size(238, 60);
            this.panelSongName.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 405);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTryAgain);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.tbArtistInput);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.panelSongName);
            this.Name = "Form1";
            this.Text = "Guess the Music Artist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbArtistInput;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTryAgain;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panelSongName;
    }
}

