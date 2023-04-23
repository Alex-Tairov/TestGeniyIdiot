using Geniy_Idiot_Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Geniy_Idiot
{
    public partial class AuthorizationForm : Form
    {
        private Dictionary<string, string> adminDct =new Dictionary<string, string> { { "admin", "12345" } };

        private string currentUserName;
        
        public AuthorizationForm(string currentUserName)
        {
            InitializeComponent();
            this.currentUserName = currentUserName;
        }

     
        private void authorizationOKbutton_Click(object sender, EventArgs e)
        {
            if (Autorization(authorizationTextBox.Text, currentUserName))
            {
                Close();
                var questionsManagerForm = new QuestionsManagerForm(QuestionsStorage.GetQuestions());
                questionsManagerForm.Show();
            }
            else
            {
                MessageBox.Show("Введите правильный пароль");
                authorizationTextBox.Clear();
            }
            
        }

        private bool Autorization(string password, string currentName)
        {
            if (adminDct[currentName] == password)
            {
                return true;
            }
            return false;
     
        }
    }
}
