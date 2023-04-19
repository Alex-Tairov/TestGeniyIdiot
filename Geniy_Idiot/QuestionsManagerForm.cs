using Geniy_Idiot_Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geniy_Idiot
{
    public partial class QuestionsManagerForm : Form
    {
        private List<Question> questions;
        public QuestionsManagerForm(List<Question> questions)
        {
            InitializeComponent();
            this.questions = questions;
        }

        private void QuestionsManagerForm_Load(object sender, EventArgs e)
        {
            var questions = QuestionsStorage.GetQuestionsFromFile();
            for (int i = 0; i < questions.Count; i++)
            {
                var question = questions[i];
                questionsDataGridView.Rows.Add(i+1,question.Text, question.Answer);
                
           
            }
        }

        private void AddQuestionbutton_Click(object sender, EventArgs e)
        {
            var addNewQuestionForm = new AddQuestionForm();
            addNewQuestionForm.ShowDialog();
            Controls.Clear();
            InitializeComponent();
            SetValuesTable();
        }

        private void SetValuesTable()
        {
            
            var questions = QuestionsStorage.GetQuestionsFromFile();
            for (int i = 0; i < questions.Count; i++)
            {
                var question = questions[i];
                questionsDataGridView.Rows.Add(i + 1, question.Text, question.Answer);
            }
        }

        private void DeleteQuestionbutton_Click(object sender, EventArgs e)
        {
            var deletedRows = questionsDataGridView.SelectedRows;
            var lst = QuestionsStorage.GetQuestionsFromFile();
            MessageBox.Show(lst.Count.ToString());
           // MessageBox.Show(deletedRows.Count.ToString());
            for (int i = 0; i < deletedRows.Count; i++)
            {
                var row = deletedRows[i];
                var textQuestions = row.Cells[1]?.Value?.ToString();
                if (textQuestions != null)
                    lst.RemoveAll(x=>x.Text==textQuestions);
                   // MessageBox.Show(textQuestions);
                    //QuestionsStorage.Remove(textQuestions);
            }
            QuestionsStorage.SaveQuestions(lst);
            //MessageBox.Show(lst.Count.ToString());
            Controls.Clear();
            InitializeComponent();
            SetValuesTable();
        }

      
    }
}
