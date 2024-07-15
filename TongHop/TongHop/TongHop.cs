using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxApp;
using hihi;
using AppQLSV;
using ImageProcessing;
using quizGame;
using WindowsFormsApplication1;
namespace TongHop
{
    public partial class TongHop : Form
    {
     
        public TongHop()
        {
            InitializeComponent();
       
        
        }
        
        private void btnLAB2_Click(object sender, EventArgs e)
        {
           TaxApplication taxApplication = new TaxApplication();
            taxApplication.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLAB1_Click(object sender, EventArgs e)
        {
            btntinh btntinh = new btntinh();
            btntinh.Show(); 
        }

        private void btnLAB6_Click(object sender, EventArgs e)
        {
            Can can     =   new Can();
            can.Show();
        }

        private void btnLAB5_Click(object sender, EventArgs e)
        {
           IP iP = new IP();
            iP.Show();
        }

        private void btnLAB7_Click(object sender, EventArgs e)
        {
            Qlsv qlsv = new Qlsv();
            qlsv.Show();
        }

        private void btnLAB4_Click(object sender, EventArgs e)
        {
            QuizApp app = new QuizApp();
            app.Show();
        }

        private void btnLAB3_Click(object sender, EventArgs e)
        {
            frmPuzzleGame frmPuzzleGame = new frmPuzzleGame();  
                frmPuzzleGame.Show();
        }

        private void btnLAB2_KeyDown(object sender, KeyEventArgs e)
        {
           
           
        }

        private void TongHop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F1)
            {
                
                TaxApplication taxApplication = new TaxApplication();
                taxApplication.Show();
            }
            if (e.Control && e.KeyCode == Keys.F2)
            {
                
                frmPuzzleGame frmPuzzleGame = new frmPuzzleGame();
                frmPuzzleGame.Show();
            }
            if (e.Control && e.KeyCode == Keys.F3)
            {

                btntinh btntinh = new btntinh();
                btntinh.Show();
            }
            if (e.Control && e.KeyCode == Keys.F4)
            {

                QuizApp app = new QuizApp();
                app.Show();
            }
            if (e.Control && e.KeyCode == Keys.F5)
            {

                IP iP = new IP();
                iP.Show();
            }
            if (e.Control && e.KeyCode == Keys.F6)
            {
                Can can = new Can();
                can.Show();
            }
            if (e.Control && e.KeyCode == Keys.F7)
            {
                Qlsv qlsv = new Qlsv();
                qlsv.Show();
            }
        }
    }
}
