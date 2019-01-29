namespace Vano
{
    partial class MainScreen
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
            this.firstBrowseButton = new System.Windows.Forms.Button();
            this.SecondBrowseButton = new System.Windows.Forms.Button();
            this.firstFileBox = new System.Windows.Forms.TextBox();
            this.secondFileBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.fileCheckbox = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // firstBrowseButton
            // 
            this.firstBrowseButton.Location = new System.Drawing.Point(258, 32);
            this.firstBrowseButton.Name = "firstBrowseButton";
            this.firstBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.firstBrowseButton.TabIndex = 0;
            this.firstBrowseButton.Text = "Browse";
            this.firstBrowseButton.UseVisualStyleBackColor = true;
            this.firstBrowseButton.Click += new System.EventHandler(this.firstBrowseButton_Click);
            // 
            // SecondBrowseButton
            // 
            this.SecondBrowseButton.Location = new System.Drawing.Point(258, 84);
            this.SecondBrowseButton.Name = "SecondBrowseButton";
            this.SecondBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.SecondBrowseButton.TabIndex = 1;
            this.SecondBrowseButton.Text = "Browse";
            this.SecondBrowseButton.UseVisualStyleBackColor = true;
            this.SecondBrowseButton.Click += new System.EventHandler(this.SecondBrowseButton_Click);
            // 
            // firstFileBox
            // 
            this.firstFileBox.Location = new System.Drawing.Point(13, 32);
            this.firstFileBox.Name = "firstFileBox";
            this.firstFileBox.Size = new System.Drawing.Size(206, 20);
            this.firstFileBox.TabIndex = 2;
            // 
            // secondFileBox
            // 
            this.secondFileBox.Location = new System.Drawing.Point(13, 84);
            this.secondFileBox.Name = "secondFileBox";
            this.secondFileBox.Size = new System.Drawing.Size(206, 20);
            this.secondFileBox.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(258, 125);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // fileCheckbox
            // 
            this.fileCheckbox.AutoSize = true;
            this.fileCheckbox.Location = new System.Drawing.Point(13, 130);
            this.fileCheckbox.Name = "fileCheckbox";
            this.fileCheckbox.Size = new System.Drawing.Size(53, 17);
            this.fileCheckbox.TabIndex = 5;
            this.fileCheckbox.Text = "Files?";
            this.fileCheckbox.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Vano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 163);
            this.Controls.Add(this.fileCheckbox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.secondFileBox);
            this.Controls.Add(this.firstFileBox);
            this.Controls.Add(this.SecondBrowseButton);
            this.Controls.Add(this.firstBrowseButton);
            this.Name = "Vano";
            this.Text = "Vano";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button firstBrowseButton;
        private System.Windows.Forms.Button SecondBrowseButton;
        private System.Windows.Forms.TextBox firstFileBox;
        private System.Windows.Forms.TextBox secondFileBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.CheckBox fileCheckbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

