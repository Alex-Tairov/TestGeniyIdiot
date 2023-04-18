
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
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsDataGridView
            // 
            this.questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionNumber,
            this.Question,
            this.Answer});
            this.questionsDataGridView.Location = new System.Drawing.Point(21, 21);
            this.questionsDataGridView.Name = "questionsDataGridView";
            this.questionsDataGridView.RowHeadersWidth = 51;
            this.questionsDataGridView.RowTemplate.Height = 24;
            this.questionsDataGridView.Size = new System.Drawing.Size(662, 150);
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
            // QuestionsManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.questionsDataGridView);
            this.Name = "QuestionsManagerForm";
            this.Text = "QuestionsManagerForm";
            this.Load += new System.EventHandler(this.QuestionsManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView questionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
    }
}