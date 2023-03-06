namespace StudentManagement
{
    partial class ForgotPassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassForm));
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonSendCode = new System.Windows.Forms.Button();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.textBoxVerCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(179, 79);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(213, 22);
            this.textBoxEmail.TabIndex = 0;
            // 
            // buttonSendCode
            // 
            this.buttonSendCode.Location = new System.Drawing.Point(309, 126);
            this.buttonSendCode.Name = "buttonSendCode";
            this.buttonSendCode.Size = new System.Drawing.Size(83, 35);
            this.buttonSendCode.TabIndex = 1;
            this.buttonSendCode.Text = "Send Code";
            this.buttonSendCode.UseVisualStyleBackColor = true;
            this.buttonSendCode.Click += new System.EventHandler(this.buttonSendCode_Click);
            // 
            // buttonVerify
            // 
            this.buttonVerify.Location = new System.Drawing.Point(309, 268);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(83, 44);
            this.buttonVerify.TabIndex = 3;
            this.buttonVerify.Text = "Verify Code";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // textBoxVerCode
            // 
            this.textBoxVerCode.Location = new System.Drawing.Point(179, 224);
            this.textBoxVerCode.Name = "textBoxVerCode";
            this.textBoxVerCode.Size = new System.Drawing.Size(213, 22);
            this.textBoxVerCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Verify Code:";
            // 
            // ForgotPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 439);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.textBoxVerCode);
            this.Controls.Add(this.buttonSendCode);
            this.Controls.Add(this.textBoxEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPassForm";
            this.Text = "ForgotPassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonSendCode;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.TextBox textBoxVerCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}