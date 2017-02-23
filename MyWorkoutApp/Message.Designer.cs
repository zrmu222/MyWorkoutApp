namespace MyWorkoutApp
{
    partial class Message
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.okay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(107, 40);
            this.messageLabel.MaximumSize = new System.Drawing.Size(300, 25);
            this.messageLabel.MinimumSize = new System.Drawing.Size(100, 25);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(141, 25);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Successfully Completed Day";
            // 
            // okay
            // 
            this.okay.Location = new System.Drawing.Point(138, 79);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(75, 23);
            this.okay.TabIndex = 1;
            this.okay.Text = "Ok";
            this.okay.UseVisualStyleBackColor = true;
            this.okay.Click += new System.EventHandler(this.okay_Click);
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 132);
            this.Controls.Add(this.okay);
            this.Controls.Add(this.messageLabel);
            this.Name = "Message";
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button okay;
    }
}