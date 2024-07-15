﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class QuizApp : Form
    {

        // variables list for this quiz game
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public QuizApp()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 8;

            this.Text = "Quiz app Question about C# OOP";
           


        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);




            if (buttonTag == correctAnswer)
            {
                score++;


            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage here
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);
                string mess="";
                if (percentage < 50) {
                    mess = "You should improve more!";
                }
                else if (percentage >= 50 && percentage <80) {
                    mess = "You did a great job, keep it up!";
                }
                else if(percentage >= 80) {
                    mess = "You are doing well!";
                }
                MessageBox.Show("Quiz Ended" + Environment.NewLine +
                                "You have answered " + score + " questions correcly" + Environment.NewLine +
                                "Your total percentage is " + percentage + " %" + Environment.NewLine + mess + Environment.NewLine +
                                "Click Ok to play again"
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

            FileStream fs = new FileStream("C:\\Users\\DarkM\\Desktop\\TongHopCacLAB\\Question.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            String cauhoi_1 = rd.ReadLine();
            String cauhoi_2 = rd.ReadLine();
            String cauhoi_3 = rd.ReadLine();
            String cauhoi_4 = rd.ReadLine();
            String cauhoi_5 = rd.ReadLine();
            String cauhoi_6 = rd.ReadLine();
            String cauhoi_7 = rd.ReadLine();
            String cauhoi_8 = rd.ReadLine();
            rd.Close();

            switch (qnum)
            {
                case 1:

                    pictureBox1.Image = TongHop.Properties.Resources.questions;
                    lblQuestion.Text = cauhoi_1;

                    button1.Text = "Multi -inheritance";
                    button2.Text = "Class and Object";
                    button3.Text = "Encapsulation, Inheritance and Polymorphism";
                    button4.Text = "Data security and encryption";

                    correctAnswer = 3;

                    break;
                case 2:
                    pictureBox1.Image =TongHop.Properties.Resources.questions;
                    lblQuestion.Text = cauhoi_2;

                    button1.Text = "A global variable";
                    button2.Text = "A method";
                    button3.Text = "A class";
                    button4.Text = "An entity of a class";

                    correctAnswer = 4;

                    break;
                case 3:

                    pictureBox1.Image = TongHop.Properties.Resources.inher;
                    lblQuestion.Text = cauhoi_3;

                    button1.Text = "Encapsulation";
                    button2.Text = "Inheritance";
                    button3.Text = "Polymorphism";
                    button4.Text = "Multi-inheritance";

                    correctAnswer = 2;

                    break;


                case 4:

                    pictureBox1.Image = TongHop.Properties.Resources.questions;
                    lblQuestion.Text = cauhoi_4;
                    button1.Text = "abstract";
                    button2.Text = "new";
                    button3.Text = "virtual";
                    button4.Text = "sealed";

                    correctAnswer = 2;

                    break;

                case 5:

                    pictureBox1.Image = TongHop.Properties.Resources.gf;
                    lblQuestion.Text = cauhoi_5;

                    button1.Text = "Encapsulation";
                    button2.Text = "Inheritance";
                    button3.Text = "Polymorphism";
                    button4.Text = "Multi-inheritanco";

                    correctAnswer = 3;

                    break;

                case 6:

                    pictureBox1.Image = TongHop.Properties.Resources.questions;
                    lblQuestion.Text = cauhoi_6;


                    button1.Text = "Encapsulation";
                    button2.Text = "Inheritance";
                    button3.Text = "Polymorphism";
                    button4.Text = "Interface";

                    correctAnswer = 1;

                    break;

                case 7:

                    pictureBox1.Image = TongHop.Properties.Resources.code;
                    lblQuestion.Text = cauhoi_7;

                    button1.Text = "The animal makes a sound.";
                    button2.Text = "The dog barks.";
                    button3.Text = "The cat meows.";
                    button4.Text = "The animal makes a sound. The dog barks. The cat meows.";

                    correctAnswer = 4;

                    break;

                case 8:

                    pictureBox1.Image = TongHop.Properties.Resources.questions;
                    lblQuestion.Text = cauhoi_8;

                    button1.Text = "When you want to inherit from multiple classes at the same time";
                    button2.Text = "When you want to define methods that don't need to be implemented";
                    button3.Text = "When you want to pack components into a standalone unit";
                    button4.Text = "When you want to connect to the database";

                    correctAnswer = 2;

                    break;




            }




        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void QuizApp_Load(object sender, EventArgs e)
        {

        }
    }
}
