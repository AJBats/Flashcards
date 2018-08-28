using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcards
{
    public partial class Form1 : Form
    {
        public List<String> answerSet = new List<string>();
        public String[] questionSet;
        public int rightAnswer = 0;
        public int previousQuestion = -1;

        public Form1()
        {
            InitializeComponent();

            this.flashcardPane.Location = new System.Drawing.Point(12, 12);
            this.mainMenu.Visible = true;
            this.flashcardPane.Visible = false;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Size = new System.Drawing.Size(820, 500);            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rightAnswer == 0)
            {
                // yes
                SetupQuestion();
            }
            else
            {
                // no
                this.button1.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rightAnswer == 1)
            {
                // yes
                SetupQuestion();
            }
            else
            {
                // no
                this.button2.ForeColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rightAnswer == 2)
            {
                // yes
                SetupQuestion();
            }
            else
            {
                // no
                this.button3.ForeColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                
                string lineRead = sr.ReadLine();
                while(lineRead != null)
                {
                    answerSet.Add(lineRead);
                    lineRead = sr.ReadLine();
                }

                sr.Close();

                string dirName = Path.GetDirectoryName(openFileDialog1.FileName);

                String[] inputQuestionSet = Directory.GetFiles(dirName, "*.jpg", SearchOption.TopDirectoryOnly);
                questionSet = new String[inputQuestionSet.Length];

                foreach (String file in inputQuestionSet)
                {
                    int parsedResult;
                    string pureFileName = Path.GetFileNameWithoutExtension(Path.GetFileName(file));                    

                    if (int.TryParse(pureFileName, out parsedResult))
                    {
                        if(parsedResult == 0)
                        {
                            throw new System.Exception("Critical error: Do not use 0.jpg. Start questions at 1.jpg and count up.");
                        }

                        questionSet[parsedResult - 1] = file;
                    }
                    else
                    {
                        throw new System.Exception("Critical error: One of the input jpg files is not named after an integer value.");
                    }
                    
                }

                if (answerSet.Count != questionSet.Length)
                {
                    MessageBox.Show("Number of answers does not match number of questions.\nPlease correct data.");
                    return;
                }

                if(answerSet.Count < 3)
                {
                    MessageBox.Show("Must have more than 3 questions in lesson.");
                    return;
                }
            
                SetupQuestion();

                mainMenu.Visible = false;
                flashcardPane.Visible = true;
            }
        }

        private void SetupQuestion()
        {
            Random rnd = new Random();
            List<String> answerSetCopy = new List<String>();

            foreach(String s in answerSet)
            {
                answerSetCopy.Add(s);
            }

            int randoQuestion = rnd.Next(0, questionSet.Length);
            int plzDontInfinite = 0;
            // dont repeat last question
            while(randoQuestion == previousQuestion)
            {
                plzDontInfinite++;
                randoQuestion = rnd.Next(0, questionSet.Length);
                if(plzDontInfinite > 100000)
                {
                    throw new System.Exception("Infinite loop detected.");
                }
            }
            rightAnswer = rnd.Next(0, 3);

            pictureBox1.Image = Image.FromFile(questionSet[randoQuestion]);

            this.button1.ForeColor = Color.Black;
            this.button2.ForeColor = Color.Black;
            this.button3.ForeColor = Color.Black;


            switch (rightAnswer)
            {
                case 0:
                    button1.Text = answerSet[randoQuestion];
                    answerSetCopy.Remove(button1.Text);
                    button2.Text = answerSetCopy[rnd.Next(0, answerSetCopy.Count)];
                    answerSetCopy.Remove(button2.Text);
                    button3.Text = answerSetCopy[rnd.Next(0, answerSetCopy.Count)];
                    break;
                case 1:
                    button2.Text = answerSet[randoQuestion];
                    answerSetCopy.Remove(button2.Text);
                    button1.Text = answerSetCopy[rnd.Next(0, answerSetCopy.Count)];
                    answerSetCopy.Remove(button1.Text);
                    button3.Text = answerSetCopy[rnd.Next(0, answerSetCopy.Count)];
                    break;
                case 2:
                    button3.Text = answerSet[randoQuestion];
                    answerSetCopy.Remove(button3.Text);
                    button1.Text = answerSetCopy[rnd.Next(0, answerSetCopy.Count)];
                    answerSetCopy.Remove(button1.Text);
                    button2.Text = answerSetCopy[rnd.Next(0, answerSetCopy.Count)];
                    break;
                default:
                    throw new System.Exception("rightAnswer out of bounds.");
                    
            }

            previousQuestion = randoQuestion;
        }
    }
}
