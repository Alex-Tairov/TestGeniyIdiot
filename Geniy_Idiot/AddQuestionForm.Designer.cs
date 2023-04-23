
namespace Geniy_Idiot
{
    partial class AddQuestionForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.AddQuestionTextBox = new System.Windows.Forms.TextBox();
            this.AddAnswerTextBox = new System.Windows.Forms.TextBox();
            this.EnterQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(171, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите текст вопроса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(211, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите ответ";
            // 
            // AddQuestionTextBox
            // 
            this.AddQuestionTextBox.Location = new System.Drawing.Point(44, 94);
            this.AddQuestionTextBox.Name = "AddQuestionTextBox";
            this.AddQuestionTextBox.Size = new System.Drawing.Size(524, 22);
            this.AddQuestionTextBox.TabIndex = 2;
            // 
            // AddAnswerTextBox
            // 
            this.AddAnswerTextBox.Location = new System.Drawing.Point(142, 220);
            this.AddAnswerTextBox.Name = "AddAnswerTextBox";
            this.AddAnswerTextBox.Size = new System.Drawing.Size(298, 22);
            this.AddAnswerTextBox.TabIndex = 3;
            this.AddAnswerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddAnswerTextBox_KeyPress);
            // 
            // EnterQuestionButton
            // 
            this.EnterQuestionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EnterQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterQuestionButton.Location = new System.Drawing.Point(212, 289);
            this.EnterQuestionButton.Name = "EnterQuestionButton";
            this.EnterQuestionButton.Size = new System.Drawing.Size(164, 53);
            this.EnterQuestionButton.TabIndex = 4;
            this.EnterQuestionButton.Text = "Добавить вопрос";
            this.EnterQuestionButton.UseVisualStyleBackColor = false;
            this.EnterQuestionButton.Click += new System.EventHandler(this.EnterQuestionButton_Click);
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(608, 374);
            this.Controls.Add(this.EnterQuestionButton);
            this.Controls.Add(this.AddAnswerTextBox);
            this.Controls.Add(this.AddQuestionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuestionForm";
            //this.Load += new System.EventHandler(this.AddQuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddQuestionTextBox;
        private System.Windows.Forms.TextBox AddAnswerTextBox;
        private System.Windows.Forms.Button EnterQuestionButton;
    }
}