using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Quiz
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Text = "Нажмите, чтобы начать";
            button1.Text = "";
            button3.Text = "";
            label1.Text = "" ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                var curQ = Question.CreateQ(Question.QNumber);
                curQ.startNewQ(label1, pictureBox1, button1, button2, button3);
            if (Question.QNumber != 1)
            {
                var curQPr = Question.CreateQ(Question.QNumber - 1);
                if (curQPr.rightAnswer == 1)
                {
                    Question.rightAnsCount++;
                    label3.Text = "right!";
                }
                else
                {
                    label3.Text = "wrong!";
                }
                label2.Text = $"{Question.rightAnsCount}/{Question.QNumber-1}";
                Question.QNumber++;
                if (Question.QNumber > 5)
                {
                    MessageBox.Show($"Количество правильных ответов:{Question.rightAnsCount} / {Question.QNumber-2}");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
            }
            else Question.QNumber++;
        }
        private void button2_Click(object sender, EventArgs e)
        {
                var curQ = Question.CreateQ(Question.QNumber);
                curQ.startNewQ(label1, pictureBox1, button1, button2, button3);
            if (Question.QNumber != 1)
            {
                var curQPr = Question.CreateQ(Question.QNumber-1);
                if (curQPr.rightAnswer == 2)
                {
                    Question.rightAnsCount++;
                    label3.Text = "right!";
                }
                else
                {
                    label3.Text = "wrong!";
                }
                label2.Text = $"{Question.rightAnsCount}/{Question.QNumber-1}";
                Question.QNumber++;
                if (Question.QNumber > 5)
                {
                    MessageBox.Show($"Количество правильных ответов:{Question.rightAnsCount} / {Question.QNumber-2}");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
            }
            else Question.QNumber++;
        }
        private void button3_Click(object sender, EventArgs e)
        {
                var curQ = Question.CreateQ(Question.QNumber);
                curQ.startNewQ(label1, pictureBox1, button1, button2, button3);
            if (Question.QNumber != 1)
            {
                var curQPr = Question.CreateQ(Question.QNumber - 1);
                if (curQPr.rightAnswer == 3)
                {
                    Question.rightAnsCount++;
                    label3.Text = "right!";
                }
                else
                {
                    label3.Text = "wrong!";
                }
                label2.Text = $"{Question.rightAnsCount}/{Question.QNumber-1}";
                Question.QNumber++;
                if (Question.QNumber > 5)
                {
                    MessageBox.Show($"Количество правильных ответов:{Question.rightAnsCount} / {Question.QNumber-2}");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
            }
            else Question.QNumber++;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    class Question
    {
        static public int rightAnsCount=0;
        static public int QNumber = 1;
        private string[] Btext;
        public int rightAnswer;
        private string pictureName;
        private string task;
        private int currentQ;
        public Question(string[] Btext, int rightAnswer, string pictureName, string task, int currentQ)
        {
            this.Btext = Btext;
            this.rightAnswer = rightAnswer;
            this.pictureName = pictureName;
            this.task = task;
            this.currentQ = currentQ;
        }
        public void startNewQ(Label label, PictureBox pictureBox, Button b1, Button b2, Button b3)
        {
            label.Text = this.task;
            pictureBox.Image = Image.FromFile($"{Environment.CurrentDirectory}\\Quiz{currentQ}.jpg");
            b1.Text = this.Btext[0];
            b2.Text = this.Btext[1];
            b3.Text = this.Btext[2];
        }
        static public Question CreateQ(int Qnumber)
        {
            switch (Qnumber)
            {
                case 1:
                    string[] Btext1 = { "Для создания программ", "Для перевода программ в машинные коды", "Для обеспечения бесперебойной работы программ" };
                    var firstQ = new Question(Btext1, 2, "", "1.Для чего используют программы-ассемблеры?", 1);
                    return firstQ;
                case 2:
                    string[] Btext2 = { "К языкам среднего уровня", "К языкам высокого уровня", "К языкам низкого уровня" };
                    var secondQ = new Question(Btext2, 3, "", "2.К какому уровню языков относятся языки ассемблера?", 2);
                    return secondQ;
                case 3:
                    string[] Btext3 = { "Программные средства для обеспечения бесперебойной работы существующих программ", "Программные средства для создания и отладки новых программ", "Программные средства для перевода команд с естественного языка в машинные коды" };
                    var thirdQ = new Question(Btext3, 2, "", "3.Что такое системы программирования?", 3);
                    return thirdQ;
                case 4:
                    string[] Btext4 = { "Ада", "Паскаль", "Фортран" };
                    var fourthQ = new Question(Btext4, 3, "", "4.Какой язык программирования, созданный в 1957 году, является одним из первых алгоритмических языков и до\n сих пор применяется для научных вычислений?", 4);
                    return fourthQ;
                default:
                    string[] temp = { "", "", "" };
                    return new Question(temp, 0, "", "", 5);
            }
        }
    }
}
