﻿namespace StudentManagement
{
    partial class ResetPassWordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassWordForm));
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.textBoxVerNewPass = new System.Windows.Forms.TextBox();
            this.buttonResetPass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Location = new System.Drawing.Point(155, 60);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(124, 22);
            this.textBoxNewPass.TabIndex = 0;
            // 
            // textBoxVerNewPass
            // 
            this.textBoxVerNewPass.Location = new System.Drawing.Point(155, 115);
            this.textBoxVerNewPass.Name = "textBoxVerNewPass";
            this.textBoxVerNewPass.Size = new System.Drawing.Size(124, 22);
            this.textBoxVerNewPass.TabIndex = 1;
            // 
            // buttonResetPass
            // 
            this.buttonResetPass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonResetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetPass.Location = new System.Drawing.Point(171, 158);
            this.buttonResetPass.Name = "buttonResetPass";
            this.buttonResetPass.Size = new System.Drawing.Size(108, 38);
            this.buttonResetPass.TabIndex = 2;
            this.buttonResetPass.Text = "Reset";
            this.buttonResetPass.UseVisualStyleBackColor = false;
            this.buttonResetPass.Click += new System.EventHandler(this.buttonResetPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm Password:";
            // 
            // ResetPassWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonResetPass);
            this.Controls.Add(this.textBoxVerNewPass);
            this.Controls.Add(this.textBoxNewPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetPassWordForm";
            this.Text = "ResetPassWordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.TextBox textBoxVerNewPass;
        private System.Windows.Forms.Button buttonResetPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}