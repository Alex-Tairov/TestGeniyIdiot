using Geniy_Idiot_Common;
using System;
using System.Windows.Forms;

namespace Geniy_Idiot
{
    public partial class MainForm1 : Form
    {
        private User user;
        private Game game;
        public MainForm1()
        {
            InitializeComponent();
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
            var userInfoForm = new UserInfoForm();
            if (userInfoForm.ShowDialog(this) == DialogResult.OK)
            {
                var userName = userInfoForm.UserNameTextBox.Text;//Записываем имя пользователя
                user = new User(userName);
                game = new Game(user);
                game.ReStore();
                PrintNextQuestion();
            }
            else
            {
                Close();
            }
        }


        private void PrintNextQuestion()
        {
            if (game.IsEnd())
            {
                var diagnose = game.CalculateDiagnose();
                MessageBox.Show(game.CalculateDiagnose());
                game.SaveResult();
                
                nextQuestionButton_Click.Enabled = false;
               // nextQuestionButton.Enabled = false;
                return;

            }
            var question = game.PopRandomQuestion();
            questionTextLabel.Text = question.Text;
            questionNumberLabel.Text = game.GetCurrentQuestionNumberInfo();
            userAnswerTextBox.Clear();
            userAnswerTextBox.Focus();
        }

        //Обрабатываем нажатие на кнопку "Далее"
        private void nextQuestionButton_Click_Click(object sender, EventArgs e)
        {
            var len = userAnswerTextBox.Text.Length;
            if (len == 0)
            {
                MessageBox.Show("Вы ничего не ввели");
            }
            else
            {
                var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
                game.AcceptAnswers(userAnswer);
                PrintNextQuestion();
            }
        }


        //Защита от дурака
        private void userAnswerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           e.Handled = !(Char.IsDigit(e.KeyChar) || (e.KeyChar == 8));
           if (e.Handled == true)
           {
               MessageBox.Show("Введите корректно данные");
           }
            
        }

        private void новаяИграToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var userInfoForm = new UserInfoForm();
            if (userInfoForm.ShowDialog(this) == DialogResult.OK)
            {
                var userName = userInfoForm.UserNameTextBox.Text;//Записываем имя пользователя
                user = new User(userName);
                game = new Game(user);
                game.ReStore();
                nextQuestionButton_Click.Enabled = true;
                PrintNextQuestion();
            }
            else
            {
                Close();
            }
        }

        //Выводим результаты
        private void отобразитьПредыдущиеРещультатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userResultsForm = new UserResultsForm(UserResult.GetResultsFromFile());
            userResultsForm.Show();
        }

        //Кнопка "Рестарт"
        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.ReStore();
            PrintNextQuestion();
        }

        //Кнопка "Выход"
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void добавитьУдалитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //var questionsManagerForm = new UserResultsForm(UserResult.GetResultsFromFile());
            var questionsManagerForm = new QuestionsManagerForm(QuestionsStorage.GetQuestions());
            questionsManagerForm.Show();
           // userResultsForm.Show();
        }
    }
}
