using System;
using System.Windows.Forms;

namespace Geniy_Idiot
{
    public partial class FinishGameForm : Form
    {
        private string resultDiagnos;
                
        public FinishGameForm(string resultDiagnos)
        {
            InitializeComponent();
            this.resultDiagnos = resultDiagnos;
        }

        private void FinishGame_Load(object sender, EventArgs e)
        {
            ResultDiagnosLabel.Text = resultDiagnos;
        }

        
    }
}
