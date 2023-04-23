
namespace Geniy_Idiot
{
    partial class QuestionsManagerForm
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
            this.questionsDataGridView = new System.Windows.Forms.DataGridView();
            this.questionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddQuestionbutton = new System.Windows.Forms.Button();
            this.DeleteQuestionbutton = new System.Windows.Forms.Button();
            this.SetBasedQuestionsbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsDataGridView
            // 
            this.questionsDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionNumber,
            this.Question,
            this.Answer});
            this.questionsDataGridView.Location = new System.Drawing.Point(114, 67);
            this.questionsDataGridView.Name = "questionsDataGridView";
            this.questionsDataGridView.RowHeadersWidth = 51;
            this.questionsDataGridView.RowTemplate.Height = 24;
            this.questionsDataGridView.Size = new System.Drawing.Size(519, 266);
            this.questionsDataGridView.TabIndex = 0;
            // 
            // questionNumber
            // 
            this.questionNumber.HeaderText = "№";
            this.questionNumber.MinimumWidth = 6;
            this.questionNumber.Name = "questionNumber";
            this.questionNumber.Width = 25;
            // 
            // Question
            // 
            this.Question.HeaderText = "Вопрос";
            this.Question.MinimumWidth = 6;
            this.Question.Name = "Question";
            this.Question.Width = 250;
            // 
            // Answer
            // 
            this.Answer.HeaderText = "Ответ";
            this.Answer.MinimumWidth = 6;
            this.Answer.Name = "Answer";
            this.Answer.Width = 50;
            // 
            // AddQuestionbutton
            // 
            this.AddQuestionbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddQuestionbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddQuestionbutton.Location = new System.Drawing.Point(76, 352);
            this.AddQuestionbutton.Name = "AddQuestionbutton";
            this.AddQuestionbutton.Size = new System.Drawing.Size(155, 60);
            this.AddQuestionbutton.TabIndex = 1;
            this.AddQuestionbutton.Text = "Добавить вопрос";
            this.AddQuestionbutton.UseVisualStyleBackColor = false;
            this.AddQuestionbutton.Click += new System.EventHandler(this.AddQuestionbutton_Click);
            // 
            // DeleteQuestionbutton
            // 
            this.DeleteQuestionbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DeleteQuestionbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteQuestionbutton.Location = new System.Drawing.Point(287, 352);
            this.DeleteQuestionbutton.Name = "DeleteQuestionbutton";
            this.DeleteQuestionbutton.Size = new System.Drawing.Size(155, 60);
            this.DeleteQuestionbutton.TabIndex = 2;
            this.DeleteQuestionbutton.Text = "Удалить вопросы";
            this.DeleteQuestionbutton.UseVisualStyleBackColor = false;
            this.DeleteQuestionbutton.Click += new System.EventHandler(this.DeleteQuestionbutton_Click);
            // 
            // SetBasedQuestionsbutton
            // 
            this.SetBasedQuestionsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SetBasedQuestionsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetBasedQuestionsbutton.Location = new System.Drawing.Point(493, 352);
            this.SetBasedQuestionsbutton.Name = "SetBasedQuestionsbutton";
            this.SetBasedQuestionsbutton.Size = new System.Drawing.Size(155, 60);
            this.SetBasedQuestionsbutton.TabIndex = 3;
            this.SetBasedQuestionsbutton.Text = "Сбросить до базовых вопросов";
            this.SetBasedQuestionsbutton.UseVisualStyleBackColor = false;
            this.SetBasedQuestionsbutton.Click += new System.EventHandler(this.SetBasedQuestionsbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(248, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Панель администратора";
            // 
            // QuestionsManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetBasedQuestionsbutton);
            this.Controls.Add(this.DeleteQuestionbutton);
            this.Controls.Add(this.AddQuestionbutton);
            this.Controls.Add(this.questionsDataGridView);
            this.Name = "QuestionsManagerForm";
            this.Text = "ГенийИдиот";
            this.Load += new System.EventHandler(this.QuestionsManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView questionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.Button AddQuestionbutton;
        private System.Windows.Forms.Button DeleteQuestionbutton;
        private System.Windows.Forms.Button SetBasedQuestionsbutton;
        private System.Windows.Forms.Label label1;
    }
}