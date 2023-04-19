using Geniy_Idiot_Common;
using System;
using System.Windows.Forms;

namespace Geniy_Idiot
{
    public partial class AddQuestionForm : Form
    {
        //private QuestionsStorage questionsStorage;
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void AddQuestionForm_Load(object sender, EventArgs e)
        {
           
        }

        private void EnterQuestionButton_Click(object sender, EventArgs e)
        {
            var q1 = AddQuestionTextBox.Text;
            var a1 = Convert.ToInt32(AddAnswerTextBox.Text);
            var newQuestion = new Question(q1, a1);
            var lst = QuestionsStorage.GetQuestionsFromFile();
            lst.Add(newQuestion);
            QuestionsStorage.SaveQuestions(lst);
            Close();
        }
    }
}
