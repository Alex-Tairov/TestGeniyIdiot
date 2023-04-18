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
    }
}
