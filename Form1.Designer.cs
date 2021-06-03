
namespace text_from_photo_slave
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
            this.startReceiverButton = new System.Windows.Forms.Button();
            this.stopReceiverButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startReceiverButton
            // 
            this.startReceiverButton.Location = new System.Drawing.Point(12, 12);
            this.startReceiverButton.Name = "startReceiverButton";
            this.startReceiverButton.Size = new System.Drawing.Size(112, 23);
            this.startReceiverButton.TabIndex = 0;
            this.startReceiverButton.Text = "Start receiver";
            this.startReceiverButton.UseVisualStyleBackColor = true;
            this.startReceiverButton.Click += new System.EventHandler(this.startReceiverButton_Click);
            // 
            // stopReceiverButton
            // 
            this.stopReceiverButton.Location = new System.Drawing.Point(130, 12);
            this.stopReceiverButton.Name = "stopReceiverButton";
            this.stopReceiverButton.Size = new System.Drawing.Size(112, 23);
            this.stopReceiverButton.TabIndex = 1;
            this.stopReceiverButton.Text = "Stop receiver";
            this.stopReceiverButton.UseVisualStyleBackColor = true;
            this.stopReceiverButton.Click += new System.EventHandler(this.stopReceiverButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(451, 108);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(564, 484);
            this.ResultTextBox.TabIndex = 4;
            this.ResultTextBox.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 616);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.stopReceiverButton);
            this.Controls.Add(this.startReceiverButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startReceiverButton;
        private System.Windows.Forms.Button stopReceiverButton;
        private System.Windows.Forms.RichTextBox ResultTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

