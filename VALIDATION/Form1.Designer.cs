namespace VALIDATION
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
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.buttonPhoneNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(260, 85);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(272, 53);
            this.txtPhoneNumber.TabIndex = 0;
            // 
            // buttonPhoneNumber
            // 
            this.buttonPhoneNumber.Location = new System.Drawing.Point(321, 161);
            this.buttonPhoneNumber.Name = "buttonPhoneNumber";
            this.buttonPhoneNumber.Size = new System.Drawing.Size(141, 61);
            this.buttonPhoneNumber.TabIndex = 1;
            this.buttonPhoneNumber.Text = "Check";
            this.buttonPhoneNumber.UseVisualStyleBackColor = true;
            this.buttonPhoneNumber.Click += new System.EventHandler(this.buttonPhoneNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPhoneNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button buttonPhoneNumber;
    }
}

