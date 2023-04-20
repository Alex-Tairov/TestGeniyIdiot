using Geniy_Idiot_Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Geniy_Idiot
{
    public partial class AuthorizationForm : Form
    {
        private Dictionary<string, string> userSpecialists =new Dictionary<string, string> { { "admin", "12345" } };

        private string currentUserName;
        
        public AuthorizationForm(string currentUserName)
        {
            InitializeComponent();
            this.currentUserName = currentUserName;
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

        }

        private void authorizationOKbutton_Click(object sender, EventArgs e)
        {
            if (Autorization(authorizationTextBox.Text, currentUserName))
            {
                // MessageBox.Show("Успех");
                //Controls.Clear();
                Close();
                var questionsManagerForm = new QuestionsManagerForm(QuestionsStorage.GetQuestions());
                questionsManagerForm.Show();
            }
            else
            {
                MessageBox.Show("Введите правильный пароль");
            }
            
        }

        private bool Autorization(string password, string currentName)
        {
            if (userSpecialists[currentName] == password)
            {
                return true;
            }
            return false;
        }
    }
}
