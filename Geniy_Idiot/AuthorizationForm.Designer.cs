
namespace Geniy_Idiot
{
    partial class AuthorizationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.authorizationTextBox = new System.Windows.Forms.TextBox();
            this.authorizationOKbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите пароль";
            // 
            // authorizationTextBox
            // 
            this.authorizationTextBox.Location = new System.Drawing.Point(327, 192);
            this.authorizationTextBox.Name = "authorizationTextBox";
            this.authorizationTextBox.Size = new System.Drawing.Size(100, 22);
            this.authorizationTextBox.TabIndex = 1;
            // 
            // authorizationOKbutton
            // 
            this.authorizationOKbutton.Location = new System.Drawing.Point(340, 282);
            this.authorizationOKbutton.Name = "authorizationOKbutton";
            this.authorizationOKbutton.Size = new System.Drawing.Size(75, 23);
            this.authorizationOKbutton.TabIndex = 2;
            this.authorizationOKbutton.Text = "OK";
            this.authorizationOKbutton.UseVisualStyleBackColor = true;
            this.authorizationOKbutton.Click += new System.EventHandler(this.authorizationOKbutton_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.authorizationOKbutton);
            this.Controls.Add(this.authorizationTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox authorizationTextBox;
        private System.Windows.Forms.Button authorizationOKbutton;
    }
}