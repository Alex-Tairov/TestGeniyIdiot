
namespace Geniy_Idiot
{
    partial class MainForm1
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
            this.components = new System.ComponentModel.Container();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nextQuestionButton_Click = new System.Windows.Forms.Button();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отобразитьПредыдущиеРещультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рестартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьУдалитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Location = new System.Drawing.Point(275, 165);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(100, 22);
            this.userAnswerTextBox.TabIndex = 0;
            this.userAnswerTextBox.Text = "1";
            this.userAnswerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userAnswerTextBox_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // nextQuestionButton_Click
            // 
            this.nextQuestionButton_Click.Location = new System.Drawing.Point(260, 233);
            this.nextQuestionButton_Click.Name = "nextQuestionButton_Click";
            this.nextQuestionButton_Click.Size = new System.Drawing.Size(135, 75);
            this.nextQuestionButton_Click.TabIndex = 1;
            this.nextQuestionButton_Click.Text = "Далее";
            this.nextQuestionButton_Click.UseVisualStyleBackColor = true;
            this.nextQuestionButton_Click.Click += new System.EventHandler(this.nextQuestionButton_Click_Click);
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Location = new System.Drawing.Point(272, 117);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(104, 17);
            this.questionTextLabel.TabIndex = 2;
            this.questionTextLabel.Text = "Текст вопроса";
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Location = new System.Drawing.Point(296, 42);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(70, 17);
            this.questionNumberLabel.TabIndex = 3;
            this.questionNumberLabel.Text = "Вопрос№";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.отобразитьПредыдущиеРещультатыToolStripMenuItem,
            this.рестартToolStripMenuItem,
            this.добавитьУдалитьВопросToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(354, 26);
            this.newGameToolStripMenuItem.Text = "Новая игра";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click_1);
            // 
            // отобразитьПредыдущиеРещультатыToolStripMenuItem
            // 
            this.отобразитьПредыдущиеРещультатыToolStripMenuItem.Name = "отобразитьПредыдущиеРещультатыToolStripMenuItem";
            this.отобразитьПредыдущиеРещультатыToolStripMenuItem.Size = new System.Drawing.Size(354, 26);
            this.отобразитьПредыдущиеРещультатыToolStripMenuItem.Text = "Отобразить предыдущие рещультаты";
            this.отобразитьПредыдущиеРещультатыToolStripMenuItem.Click += new System.EventHandler(this.отобразитьПредыдущиеРещультатыToolStripMenuItem_Click);
            // 
            // рестартToolStripMenuItem
            // 
            this.рестартToolStripMenuItem.Name = "рестартToolStripMenuItem";
            this.рестартToolStripMenuItem.Size = new System.Drawing.Size(354, 26);
            this.рестартToolStripMenuItem.Text = "Рестарт";
            this.рестартToolStripMenuItem.Click += new System.EventHandler(this.рестартToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(354, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // добавитьУдалитьВопросToolStripMenuItem
            // 
            this.добавитьУдалитьВопросToolStripMenuItem.Name = "добавитьУдалитьВопросToolStripMenuItem";
            this.добавитьУдалитьВопросToolStripMenuItem.Size = new System.Drawing.Size(354, 26);
            this.добавитьУдалитьВопросToolStripMenuItem.Text = "Добавить /Удалить вопрос";
            this.добавитьУдалитьВопросToolStripMenuItem.Click += new System.EventHandler(this.добавитьУдалитьВопросToolStripMenuItem_Click);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.nextQuestionButton_Click);
            this.Controls.Add(this.userAnswerTextBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm1";
            this.Text = "MainForm1";
            this.Load += new System.EventHandler(this.MainForm1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userAnswerTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button nextQuestionButton_Click;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отобразитьПредыдущиеРещультатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рестартToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьУдалитьВопросToolStripMenuItem;
    }
}