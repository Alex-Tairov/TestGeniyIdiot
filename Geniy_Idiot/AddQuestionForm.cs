using Geniy_Idiot_Common;
using System;
using System.Windows.Forms;

namespace Geniy_Idiot
{
    public partial class AddQuestionForm : Form
    {
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void AddQuestionForm_Load(object sender, EventArgs e)
        {
           
        }

        private void EnterQuestionButton_Click(object sender, EventArgs e)
        {
            var questionsList = QuestionsStorage.GetQuestionsFromFile();
            if (AddQuestionTextBox.Text == "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Вопрос не должен быть пустой строкой!", "Неверный ввод", buttons);
            }
            else
            {
                try
                {
                    var question= AddQuestionTextBox.Text;
                    var answer = Convert.ToInt32(AddAnswerTextBox.Text);
                    questionsList.Add(new Question(question, answer));
                    QuestionsStorage.SaveQuestions(questionsList);
                    EnterQuestionButton.DialogResult = DialogResult.OK;
                    Close();
                }
                catch (FormatException)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Пожалуйста, введите число!", "Неверный ввод", buttons);
                }
                
            }
        }

        private void AddAnswerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || (e.KeyChar == 8));
            if (e.Handled == true)
            {
                MessageBox.Show("Ответ должен быть числом");
            }
        }
    }
}
