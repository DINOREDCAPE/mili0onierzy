using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mili_juniorzy
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 8;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if(questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered" + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is" + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);
        }
        private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.muminki;
                    lblQuestion.Text = "Jaka to bajka?";
                    button1.Text = "Muminki";
                    button2.Text = "Ala i fala";
                    button3.Text = "Bolek i lolek";
                    button4.Text = "Alicja w krainie czarow";
                    correctAnswer = 1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.gumisie;
                    lblQuestion.Text = "Jaka to bajka?";
                    button1.Text = "Muminki";
                    button2.Text = "Misie malisie";
                    button3.Text = "Wesola gromada";
                    button4.Text = "Gumisie";
                    correctAnswer = 4;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.reksio;
                    lblQuestion.Text = "Jak sie nazywa ten piesek?";
                    button1.Text = "Maryla Rodowicz";
                    button2.Text = "Kajtek";
                    button3.Text = "Reksio";
                    button4.Text = "Ciapek";
                    correctAnswer = 3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.bolek;
                    lblQuestion.Text = "Jak sie nazywa ta bajka";
                    button1.Text = "Pies i Kot";
                    button2.Text = "Bolek i Lolek";
                    button3.Text = "Pat i Mat";
                    button4.Text = "Adam i Zawada";
                    correctAnswer = 2;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.pat;
                    lblQuestion.Text = "Co to za bajka?";
                    button1.Text = "Bolek i Lolek";
                    button2.Text = "Bracia Grim";
                    button3.Text = "Pat i Mat";
                    button4.Text = "Szach i Mat";
                    correctAnswer = 3;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.zwirek;
                    lblQuestion.Text = "Co to za bajka?";
                    button1.Text = "Zwirek i Muchomorek";
                    button2.Text = "Grzyb i Kania";
                    button3.Text = "Kurka i Prawdziwek";
                    button4.Text = "Gruz i Piasek";
                    correctAnswer = 1;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.krecik;
                    lblQuestion.Text = "Z jakiego kraju pochodzi ta bajka";
                    button1.Text = "Polska";
                    button2.Text = "Słowacja";
                    button3.Text = "Czechy";
                    button4.Text = "Niemcy";
                    correctAnswer = 3;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.rumcajs;
                    lblQuestion.Text = "Jak sie nazywa ten Kozak?";
                    button1.Text = "Rumcajs";
                    button2.Text = "Barnaba";
                    button3.Text = "Janeczek";
                    button4.Text = "Rogal DDL";
                    correctAnswer = 1;
                    break;
                    

            }
        }
    }
}
