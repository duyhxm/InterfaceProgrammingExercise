using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hihi
{
    public partial class btntinh : Form
    {
        public btntinh()
        {
            InitializeComponent();
        }
        double a, b, c;

        private void btntinh_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double delta,x1,x2,x;
            string kq = "";
            try
            {
                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);
                c = Convert.ToDouble(txtc.Text);
            }
            catch
            {
                MessageBox.Show("Bạn nhập sai kiểu dữ liệu", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        kq = "Phương trình có vô số nghiệm ";
                    }
                    else
                    {
                        kq = " Phương trình vô nghiệm ";
                    }
                }
                else
                {
                    kq = String.Format(" Phương trình có nghiệm {0}", ((-c) / b));
                }
            }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    kq = " Phương trình vô nghiệm ";
                }    
                else if (delta == 0 ) 
                {
                    x = (-b) / (2 * a);
                    kq =String.Format("Phương trình có nghiệm kép x = {0}", x);
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    kq = String.Format("Phương trình có 2 nghiệm phân biệt là x1={0}, x2={1}", x1, x2);
                }
            }
            txtkq.Text = kq;
        }

    }
}
