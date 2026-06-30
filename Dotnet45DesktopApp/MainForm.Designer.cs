namespace Dotnet45DesktopApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.greetingLabel = new System.Windows.Forms.Label();
            this.sayHelloButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // greetingLabel
            //
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Location = new System.Drawing.Point(12, 20);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(35, 13);
            this.greetingLabel.TabIndex = 0;
            this.greetingLabel.Text = "Ready";
            //
            // sayHelloButton
            //
            this.sayHelloButton.Location = new System.Drawing.Point(15, 50);
            this.sayHelloButton.Name = "sayHelloButton";
            this.sayHelloButton.Size = new System.Drawing.Size(120, 30);
            this.sayHelloButton.TabIndex = 1;
            this.sayHelloButton.Text = "Say Hello";
            this.sayHelloButton.UseVisualStyleBackColor = true;
            this.sayHelloButton.Click += new System.EventHandler(this.sayHelloButton_Click);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 111);
            this.Controls.Add(this.sayHelloButton);
            this.Controls.Add(this.greetingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dotnet45 Desktop App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Button sayHelloButton;
    }
}
