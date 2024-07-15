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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string flag;
        DataTable dtSV;
        int index;
        int maxID = 0;
        public void LockControl()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtTen.ReadOnly = true;
            //  txtNgaySinh.ReadOnly = true;
            dtpNgaySinh.Enabled = false;
            cbbxGioiTinh.Enabled = false;
            txtToan.ReadOnly = true;
            txtHoa.ReadOnly = true;
            txtLy.ReadOnly = true;

            btnThem.Focus();
        }
        public void UnlockControl()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtTen.ReadOnly = false;
            // txtNgaySinh.ReadOnly = false;
            dtpNgaySinh.Enabled = true;
            cbbxGioiTinh.Enabled = true;
            txtToan.ReadOnly = false;
            txtHoa.ReadOnly = false;
            txtLy.ReadOnly = false;

            lblID.Focus();

        }
        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return false;
            }

            string gt = cbbxGioiTinh.Text;
            if (gt != "Nam" && gt != "Nữ")
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbxGioiTinh.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(dtpNgaySinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpNgaySinh.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtToan.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm Toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtToan.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLy.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm Lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLy.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHoa.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm Hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoa.Focus();
                return false;
            }
            return true;
        }
        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("TenSV");
            dt.Columns.Add("NgaySinh");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("DiemToan");
            dt.Columns.Add("DiemLy");
            dt.Columns.Add("DiemHoa");
            dt.Columns.Add("DiemTrungBinh");
            dt.Columns.Add("HocLuc");
            return dt;
        }

        private double TinhDTB()
        {

            double Toan = double.Parse(txtToan.Text);
            double Ly = double.Parse(txtLy.Text);
            double Hoa = double.Parse(txtHoa.Text);

            double DiemTB = (Toan + Ly + Hoa) / 3;
            DiemTB = Math.Round(DiemTB, 2, MidpointRounding.AwayFromZero);
            return DiemTB;

        }

        private string XepLoaiHocLuc()
        {
            string kq;
            if (TinhDTB() >= 8)
            {
                kq = "Giỏi";
            }
            else if (TinhDTB() >= 6.5)
            {
                kq = "Khá";
            }
            else if (TinhDTB() >= 5)
            {
                kq = "Trung Bình";
            }
            else
            {
                kq = "Yếu";
            }
            return kq;
        }
        private void ClearGD()
        {
            lblID.Text = string.Empty;
            txtTen.Text = "";
            // txtNgaySinh.Text = "";
            cbbxGioiTinh.Text = string.Empty;
            txtToan.Text = "";
            txtLy.Text = "";
            txtHoa.Text = "";
            lblDTB.Text = string.Empty;
            lblHocLuc.Text = string.Empty;
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
                    if (txtNhapTen.Text == dataGridViewSV[1, i].Value.ToString())
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
        public bool checkkieudulieu()
        {
            // Other validations...

            // Check if Toan score is a valid numeric value
            if (!double.TryParse(txtToan.Text, out double toanScore) || toanScore < 0 || toanScore > 10)
            {

                MessageBox.Show("Điểm Toán phải là một số (0->10)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtToan.Focus();
                return false;

            }

            // Check if Ly score is a valid numeric value
            if (!double.TryParse(txtLy.Text, out double lyScore) || lyScore < 0 || lyScore > 10)
            {
                MessageBox.Show("Điểm Lý phải là một số (0->10)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLy.Focus();
                return false;
            }

            // Check if Hoa score is a valid numeric value
            if (!double.TryParse(txtHoa.Text, out double hoaScore) || hoaScore < 0 || hoaScore > 10)
            {
                MessageBox.Show("Điểm Hoa phải là một số (0->10)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoa.Focus();
                return false;
            }

            // Perform other validations...

            return true;
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

            lblID.Text = "N/A";
            txtTen.Text = "";
            // txtNgaySinh.Text = "";

            cbbxGioiTinh.Text = "Chọn";
            txtToan.Text = "";
            txtLy.Text = "";
            txtHoa.Text = "";
            lblDTB.Text = "N/A";
            lblHocLuc.Text = "N/A";


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkData())
            { 
            UnlockControl();
            flag = "edit";
        }
        }
        int max = 0;

        private void btnLuu_Click(object sender, EventArgs e)
        {
            max = max + 1;
            if (flag == "add")
            {
                if (checkData())
                {
                    if (checkkieudulieu())
                    {
                        lblDTB.Text = TinhDTB().ToString();
                        lblHocLuc.Text = XepLoaiHocLuc().ToString();
                        lblID.Text = max.ToString();
                        dtSV.Rows.Add(lblID.Text, txtTen.Text, dtpNgaySinh.Text, cbbxGioiTinh.Text, txtToan.Text, txtLy.Text, txtHoa.Text, lblDTB.Text, lblHocLuc.Text);
                        dataGridViewSV.DataSource = dtSV;
                        dataGridViewSV.RefreshEdit();
                    }
                }
            }
            else if (flag == "edit")
            {
                if (checkData())
                {
                    if (checkkieudulieu())
                    {
                        lblDTB.Text = TinhDTB().ToString();
                        lblHocLuc.Text = XepLoaiHocLuc().ToString();
                        dtSV.Rows[index][1] = txtTen.Text;
                        dtSV.Rows[index][2] = dtpNgaySinh.Text;
                        dtSV.Rows[index][3] = cbbxGioiTinh.Text;
                        dtSV.Rows[index][4] = txtToan.Text;
                        dtSV.Rows[index][5] = txtLy.Text;
                        dtSV.Rows[index][6] = txtHoa.Text;
                        dtSV.Rows[index][7] = TinhDTB().ToString();
                        dtSV.Rows[index][8] = XepLoaiHocLuc().ToString();
                        dataGridViewSV.RefreshEdit();
                    }
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
                lblID.Text = dataGridViewSV.Rows[index].Cells[0].Value.ToString();
                txtTen.Text = dataGridViewSV.Rows[index].Cells[1].Value.ToString();
                dtpNgaySinh.Text = dataGridViewSV.Rows[index].Cells[2].Value.ToString();
                cbbxGioiTinh.Text = dataGridViewSV.Rows[index].Cells[3].Value.ToString();
                txtToan.Text = dataGridViewSV.Rows[index].Cells[4].Value.ToString();
                txtLy.Text = dataGridViewSV.Rows[index].Cells[5].Value.ToString();
                txtHoa.Text = dataGridViewSV.Rows[index].Cells[6].Value.ToString();
                lblDTB.Text = dataGridViewSV.Rows[index].Cells[7].Value.ToString();
                lblHocLuc.Text = dataGridViewSV.Rows[index].Cells[8].Value.ToString();
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
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                            MessageBox.Show("Không tìm thấy sinh viên với ID: " + idToDelete, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            if (txtNhapTen.Text == dataGridViewSV[1, i].Value.ToString())
                            {

                                dataGridViewTK.Rows.Add(dataGridViewSV[0, i].Value, dataGridViewSV[1, i].Value, dataGridViewSV[2, i].Value, dataGridViewSV[3, i].Value, dataGridViewSV[4, i].Value, dataGridViewSV[5, i].Value, dataGridViewSV[6, i].Value, dataGridViewSV[7, i].Value, dataGridViewSV[8, i].Value);

                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tên sinh viên này không tồn tại trong danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Danh sách rỗng không thể tìm kiếm sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtNhapID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSapXepGPAgiam_Click(object sender, EventArgs e)
        {
            if (Checkrong())
            {
                this.dataGridViewSV.Sort(this.dataGridViewSV.Columns["colDTB"], ListSortDirection.Descending);
            }
            else
            {
                MessageBox.Show("Danh sách rỗng không thể sắp xếp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSapXepGPAtang_Click(object sender, EventArgs e)
        {

            if (Checkrong())
            {
                this.dataGridViewSV.Sort(this.dataGridViewSV.Columns["colDTB"], ListSortDirection.Ascending);
            }
            else
            {
                MessageBox.Show("Danh sách rỗng không thể sắp xếp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSapXepTheoIDtang_Click(object sender, EventArgs e)
        {
            if (Checkrong())
            {
                this.dataGridViewSV.Sort(this.dataGridViewSV.Columns["colID"], ListSortDirection.Ascending);
            }
            else
            {
                MessageBox.Show("Danh sách rỗng không thể sắp xếp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSapXepIDgiam_Click(object sender, EventArgs e)
        {
            if (Checkrong())
            {
                this.dataGridViewSV.Sort(this.dataGridViewSV.Columns["colID"], ListSortDirection.Descending);
            }
            else
            {
                MessageBox.Show("Danh sách rỗng không thể sắp xếp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSapXepTentang_Click(object sender, EventArgs e)
        {
            if (Checkrong())
            {
                this.dataGridViewSV.Sort(this.dataGridViewSV.Columns["colTen"], ListSortDirection.Ascending);
            }
            else
            {
                MessageBox.Show("Danh sách rỗng không thể sắp xếp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSapXepTengiam_Click(object sender, EventArgs e)
        {
            if (Checkrong())
            {
                this.dataGridViewSV.Sort(this.dataGridViewSV.Columns["colTen"], ListSortDirection.Descending);
            }
            else
            {
                MessageBox.Show("Danh sách rỗng không thể sắp xếp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtToan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExportToTxt_Click(object sender, EventArgs e)
        {
            // Check if the DataGridView has data
            if (dataGridViewSV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Create a SaveFileDialog to allow the user to choose the file location and name
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files|*.txt";
                    saveFileDialog.Title = "Export Data to Text File";
                    saveFileDialog.FileName = "student_data.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Get the chosen file path
                        string filePath = saveFileDialog.FileName;

                        // Create a StreamWriter to write the data to the file
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            // Write the column headers to the file
                            for (int i = 0; i < dataGridViewSV.Columns.Count; i++)
                            {
                                writer.Write(dataGridViewSV.Columns[i].HeaderText);
                                if (i < dataGridViewSV.Columns.Count - 1)
                                {
                                    writer.Write("\t");
                                }
                            }
                            writer.WriteLine();

                            // Write each row of data to the file
                            foreach (DataGridViewRow row in dataGridViewSV.Rows)
                            {
                                for (int i = 0; i < dataGridViewSV.Columns.Count; i++)
                                {
                                    object cellValue = row.Cells[i].Value;
                                    string cellText = cellValue == null ? string.Empty : cellValue.ToString();
                                    writer.Write(cellText);
                                    if (i < dataGridViewSV.Columns.Count - 1)
                                    {
                                        writer.Write("\t");
                                    }
                                }
                                writer.WriteLine();
                            }
                        }

                        MessageBox.Show("Lưu file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
