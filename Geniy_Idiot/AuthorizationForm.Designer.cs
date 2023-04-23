
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите пароль";
            // 
            // authorizationTextBox
            // 
            this.authorizationTextBox.Location = new System.Drawing.Point(109, 98);
            this.authorizationTextBox.Name = "authorizationTextBox";
            this.authorizationTextBox.Size = new System.Drawing.Size(111, 22);
            this.authorizationTextBox.TabIndex = 1;
            // 
            // authorizationOKbutton
            // 
            this.authorizationOKbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.authorizationOKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationOKbutton.Location = new System.Drawing.Point(109, 141);
            this.authorizationOKbutton.Name = "authorizationOKbutton";
            this.authorizationOKbutton.Size = new System.Drawing.Size(111, 34);
            this.authorizationOKbutton.TabIndex = 2;
            this.authorizationOKbutton.Text = "OK";
            this.authorizationOKbutton.UseVisualStyleBackColor = false;
            this.authorizationOKbutton.Click += new System.EventHandler(this.authorizationOKbutton_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(361, 207);
            this.Controls.Add(this.authorizationOKbutton);
            this.Controls.Add(this.authorizationTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ГенийИдиот";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox authorizationTextBox;
        private System.Windows.Forms.Button authorizationOKbutton;
    }
}