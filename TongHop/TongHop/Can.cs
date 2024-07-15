using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppQLSV
{
    public partial class Can : Form
    {
        public Can()
        {
            InitializeComponent();
        }

        string flag;
        DataTable dtSV;
        int index;
    
        public void LockControl()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtID.ReadOnly = true;
            txtTen.ReadOnly = true;
            txtAdd.ReadOnly= true;
            txtPri.ReadOnly = true;
        

            btnThem.Focus();
        }
        public void UnlockControl()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtID.ReadOnly = false;
            txtTen.ReadOnly = false;
            txtAdd.ReadOnly = false;
            txtPri.ReadOnly = false;

            txtID.Focus();

        }
        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("You have not entered the name", "Infomantion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("You have not entered the ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
       
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAdd.Text))
            {
                MessageBox.Show("You have not entered the address", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAdd.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPri.Text))
            {
                MessageBox.Show("You have not entered the priority", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPri.Focus();
                return false;
            }
            if (!rbtnCanA.Checked & !rbtnCanB.Checked & !rbtnCanC.Checked)
            {
                MessageBox.Show("You have not chosen candidate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rbtnCanA.Focus();
                rbtnCanB.Focus();
                rbtnCanC.Focus();
                return false;
            }
        
           return true;
        }
        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("TenSV");
            dt.Columns.Add("Address");
            dt.Columns.Add("Priority");
            dt.Columns.Add("TypeCan");
            dt.Columns.Add("Subject1");
            dt.Columns.Add("Subject2");
            dt.Columns.Add("Subject3");
    
            return dt;
        }
    
        private void ClearGD()
        {
            txtID.Text = "";
            txtTen.Text = "";
            txtAdd.Text = "";
            txtPri.Text = "";
            type_can.Text = "N/A";
            lblSub1.Text = "N/A";
            lblSub2.Text = "N/A";
            lblSub3.Text = "N/A";
         
        }
        public bool checkTonTaiSV()
        {
            int ing = dataGridViewSV.Rows.Count;
            bool kq = false;
            index = dataGridViewSV.CurrentCell == null ? -1 : dataGridViewSV.CurrentCell.RowIndex;
            if (index != -1)
            {
                for (int i = 0; i < ing - 1; i++)
                {
                    if (txtID.Text == dataGridViewSV[0, i].Value.ToString())
                    {

                        kq = true;
                        break;

                    }

                }
            }
            return kq;
        }
        public bool Checkrong()
        {
            int ing = dataGridViewSV.Rows.Count;
            index = dataGridViewSV.CurrentCell == null ? -1 : dataGridViewSV.CurrentCell.RowIndex;
            bool kt = false;
            if (index != -1)
            {
                for (int i = 0; i < ing - 1; i++)
                {
                    kt = true;
                }
            }
            return kt;
        }
      
        public void TypeCan()
        {
          
            if (rbtnCanA.Checked)
            {
                lblSub1.Text = "Mon Toan";
                lblSub2.Text = "Mon Ly";
                lblSub3.Text = "Mon Hoa";

              
            }    
            if (rbtnCanB.Checked)
            {
                lblSub1.Text = "Mon Toan";
                lblSub2.Text = "Mon Sinh";
                lblSub3.Text = "Mon Hoa";

              
            }    
            if (rbtnCanC.Checked)
            {
                lblSub1.Text = "Mon Van";
                lblSub2.Text = "Mon Su";
                lblSub3.Text = "Mon Dia";
         
            }
        }
        //-----------------------------------------//
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LockControl();
            dtSV = createTable();
            foreach (DataGridViewColumn column in dataGridViewSV.Columns)
            {
                column.ReadOnly = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnlockControl();
            flag = "add";
            txtID.Text = "";
           
            txtTen.Text = "";
         
            txtAdd.Text = "";
            txtPri.Text = "";
            type_can.Text = "";
            lblSub1.Text = "N/A";
            lblSub2.Text = "N/A";
            lblSub3.Text = "N/A";

        

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
            flag = "edit";
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
        
            if (flag == "add")
            {
                if (checkData())
                {
                    TypeCan();
                   
                    if (rbtnCanA.Checked)
                    {
                        
                        type_can.Text=rbtnCanA.Text.Trim();
                    }    
                    else if (rbtnCanB.Checked)
                    {
                       
                        type_can.Text = rbtnCanB.Text.Trim();
                  
                    }    
                    else if (rbtnCanC.Checked)
                    {
                        type_can.Text =rbtnCanC.Text.Trim();
                     
                    }
                
                 
                    dtSV.Rows.Add(txtID.Text, txtTen.Text, txtAdd.Text, txtPri.Text,type_can.Text,lblSub1.Text, lblSub2.Text, lblSub3.Text);
                        dataGridViewSV.DataSource = dtSV;
                        dataGridViewSV.RefreshEdit();
                
                }
            }
            else if (flag == "edit")
            {
                if (checkData())
                {
                    TypeCan();
                    if (rbtnCanA.Checked)
                    {

                        type_can.Text = rbtnCanA.Text.Trim();
                    }
                    else if (rbtnCanB.Checked)
                    {

                        type_can.Text = rbtnCanB.Text.Trim();

                    }
                    else if (rbtnCanC.Checked)
                    {
                        type_can.Text = rbtnCanC.Text.Trim();

                    }
                    if (rbtnCanA.Checked)
                    {
                        type_can.Text = rbtnCanA.Text;
                    }
                    else if (rbtnCanB.Checked)
                    {
                        type_can.Text = rbtnCanB.Text;
                    }
                    else if (rbtnCanC.Checked)
                    {
                        type_can.Text = (rbtnCanC.Text);
                    }
                 
                    dtSV.Rows[index][0] = txtID.Text;
                        dtSV.Rows[index][1] = txtTen.Text;
                        dtSV.Rows[index][2] = txtAdd.Text;
                        dtSV.Rows[index][3] = txtPri.Text;
                    dtSV.Rows[index][4] = type_can;
                    dtSV.Rows[index][5] = lblSub1.Text;
                        dtSV.Rows[index][6] = lblSub2.Text;
                        dtSV.Rows[index][7] = lblSub3.Text;
                     
                        dataGridViewSV.RefreshEdit();
             
                }
            }
            LockControl();
        }



        private void lblID_Click(object sender, EventArgs e)
        {


        }

        private void dataGridViewSV_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewSV.DataSource = dtSV;
            dataGridViewSV.RefreshEdit();

            index = dataGridViewSV.CurrentCell == null ? -1 : dataGridViewSV.CurrentCell.RowIndex;

            if (index != -1)
            {
                txtID.Text = dataGridViewSV.Rows[index].Cells[0].Value.ToString();
                txtTen.Text = dataGridViewSV.Rows[index].Cells[1].Value.ToString();
                txtAdd.Text = dataGridViewSV.Rows[index].Cells[2].Value.ToString();
                txtPri.Text = dataGridViewSV.Rows[index].Cells[3].Value.ToString();
                type_can.Text = dataGridViewSV.Rows[index].Cells[4].Value.ToString();
                lblSub1.Text = dataGridViewSV.Rows[index].Cells[5].Value.ToString();
                lblSub2.Text = dataGridViewSV.Rows[index].Cells[6].Value.ToString();
                lblSub3.Text = dataGridViewSV.Rows[index].Cells[7].Value.ToString();
            
            }

        }

        private void dataGridViewSV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Checkrong())
            {
                if (!string.IsNullOrEmpty(txtNhapID.Text))
                {
                    DialogResult result = MessageBox.Show("Do you want to remove this candidate", "Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int idToDelete = int.Parse(txtNhapID.Text);

                        DataRow[] rowsToDelete = dtSV.Select("ID = " + idToDelete);
                        if (rowsToDelete.Length > 0)
                        {
                            foreach (DataRow row in rowsToDelete)
                            {
                                dtSV.Rows.Remove(row);
                            }

                            dataGridViewSV.RefreshEdit();
                            ClearGD();
                            LockControl();
                        }
                        else
                        {
                            MessageBox.Show("Not found candidate with this ID: " + idToDelete, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LockControl();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (Checkrong())
            {
                if (checkTonTaiSV())
                {
                    int ing = dataGridViewSV.Rows.Count;
                    index = dataGridViewSV.CurrentCell == null ? -1 : dataGridViewSV.CurrentCell.RowIndex;
                    if (index != -1)
                    {
                        dataGridViewTK.Rows.Clear();
                        for (int i = 0; i < ing - 1; i++)
                        {
                            if (txtNhapID.Text == dataGridViewSV[0, i].Value.ToString())
                            {

                                dataGridViewTK.Rows.Add(dataGridViewSV[0, i].Value, dataGridViewSV[1, i].Value, dataGridViewSV[2, i].Value, dataGridViewSV[3, i].Value, dataGridViewSV[4, i].Value, dataGridViewSV[5, i].Value, dataGridViewSV[6, i].Value, dataGridViewSV[7, i].Value);

                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("This student ID does not exist in the list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The empty list cannot be searched", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtNhapID_TextChanged(object sender, EventArgs e)
        {

        }

     
        private void txtToan_TextChanged(object sender, EventArgs e)
        {

        }

 

        private void dataGridViewSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
