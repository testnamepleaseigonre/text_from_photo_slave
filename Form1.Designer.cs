
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startReceiverButton
            // 
            this.startReceiverButton.Location = new System.Drawing.Point(264, 45);
            this.startReceiverButton.Name = "startReceiverButton";
            this.startReceiverButton.Size = new System.Drawing.Size(112, 23);
            this.startReceiverButton.TabIndex = 0;
            this.startReceiverButton.Text = "Start receiver";
            this.startReceiverButton.UseVisualStyleBackColor = true;
            this.startReceiverButton.Click += new System.EventHandler(this.startReceiverButton_Click);
            // 
            // stopReceiverButton
            // 
            this.stopReceiverButton.Location = new System.Drawing.Point(264, 231);
            this.stopReceiverButton.Name = "stopReceiverButton";
            this.stopReceiverButton.Size = new System.Drawing.Size(112, 23);
            this.stopReceiverButton.TabIndex = 1;
            this.stopReceiverButton.Text = "Stop receiver";
            this.stopReceiverButton.UseVisualStyleBackColor = true;
            this.stopReceiverButton.Click += new System.EventHandler(this.stopReceiverButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopReceiverButton);
            this.Controls.Add(this.startReceiverButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startReceiverButton;
        private System.Windows.Forms.Button stopReceiverButton;
        private System.Windows.Forms.Label label1;
    }
}

