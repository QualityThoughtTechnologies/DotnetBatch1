namespace HelloWinforms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPressMe = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPressMe
            // 
            this.btnPressMe.Location = new System.Drawing.Point(214, 99);
            this.btnPressMe.Name = "btnPressMe";
            this.btnPressMe.Size = new System.Drawing.Size(75, 23);
            this.btnPressMe.TabIndex = 0;
            this.btnPressMe.Text = "Press Me";
            this.btnPressMe.UseVisualStyleBackColor = true;
            this.btnPressMe.Click += new System.EventHandler(this.btnPressMe_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(192, 35);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(100, 20);
            this.txtMessage.TabIndex = 1;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(45, 38);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(141, 13);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Enter Your Custom Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 303);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnPressMe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hello Winforms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPressMe;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblText;
    }
}

