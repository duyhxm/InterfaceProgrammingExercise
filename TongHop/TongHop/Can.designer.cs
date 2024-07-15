namespace AppQLSV
{
    partial class Can
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Can));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapID = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridViewSV = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeCan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSub1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSub2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblSub3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.dataGridViewTK = new System.Windows.Forms.DataGridView();
            this.colIDtk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTentk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddresstk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrioritytk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeCantk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject1tk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject2tk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject3tk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtnCanA = new System.Windows.Forms.RadioButton();
            this.rbtnCanB = new System.Windows.Forms.RadioButton();
            this.rbtnCanC = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPri = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.type_can = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(644, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Candidate";
            // 
            // txtNhapID
            // 
            this.txtNhapID.Location = new System.Drawing.Point(931, 217);
            this.txtNhapID.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhapID.Name = "txtNhapID";
            this.txtNhapID.Size = new System.Drawing.Size(136, 27);
            this.txtNhapID.TabIndex = 1;
            this.txtNhapID.TextChanged += new System.EventHandler(this.txtNhapID_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Navy;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThem.Location = new System.Drawing.Point(265, 217);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridViewSV
            // 
            this.dataGridViewSV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTen,
            this.colAdd,
            this.colPriority,
            this.ColTypeCan,
            this.colSubject1,
            this.colSubject2,
            this.colSubject3});
            this.dataGridViewSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewSV.Location = new System.Drawing.Point(0, 373);
            this.dataGridViewSV.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSV.Name = "dataGridViewSV";
            this.dataGridViewSV.RowHeadersWidth = 51;
            this.dataGridViewSV.RowTemplate.Height = 24;
            this.dataGridViewSV.Size = new System.Drawing.Size(1513, 355);
            this.dataGridViewSV.TabIndex = 4;
            this.dataGridViewSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSV_CellContentClick);
            this.dataGridViewSV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSV_CellDoubleClick);
            this.dataGridViewSV.SelectionChanged += new System.EventHandler(this.dataGridViewSV_SelectionChanged);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.Width = 75;
            // 
            // colTen
            // 
            this.colTen.DataPropertyName = "TenSV";
            this.colTen.HeaderText = "Name";
            this.colTen.MinimumWidth = 6;
            this.colTen.Name = "colTen";
            this.colTen.Width = 300;
            // 
            // colAdd
            // 
            this.colAdd.DataPropertyName = "Address";
            this.colAdd.HeaderText = "Address";
            this.colAdd.MinimumWidth = 6;
            this.colAdd.Name = "colAdd";
            this.colAdd.Width = 200;
            // 
            // colPriority
            // 
            this.colPriority.DataPropertyName = "Priority";
            this.colPriority.HeaderText = "Priority";
            this.colPriority.MinimumWidth = 6;
            this.colPriority.Name = "colPriority";
            this.colPriority.Width = 125;
            // 
            // ColTypeCan
            // 
            this.ColTypeCan.DataPropertyName = "TypeCan";
            this.ColTypeCan.HeaderText = "Type Candidate";
            this.ColTypeCan.MinimumWidth = 6;
            this.ColTypeCan.Name = "ColTypeCan";
            this.ColTypeCan.Width = 200;
            // 
            // colSubject1
            // 
            this.colSubject1.DataPropertyName = "Subject1";
            this.colSubject1.HeaderText = "Subject 1";
            this.colSubject1.MinimumWidth = 6;
            this.colSubject1.Name = "colSubject1";
            this.colSubject1.Width = 180;
            // 
            // colSubject2
            // 
            this.colSubject2.DataPropertyName = "Subject2";
            this.colSubject2.HeaderText = "Subject 2";
            this.colSubject2.MinimumWidth = 6;
            this.colSubject2.Name = "colSubject2";
            this.colSubject2.Width = 180;
            // 
            // colSubject3
            // 
            this.colSubject3.DataPropertyName = "Subject3";
            this.colSubject3.HeaderText = "Subject 3";
            this.colSubject3.MinimumWidth = 6;
            this.colSubject3.Name = "colSubject3";
            this.colSubject3.Width = 180;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(459, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // lblSub1
            // 
            this.lblSub1.AutoSize = true;
            this.lblSub1.ForeColor = System.Drawing.Color.Navy;
            this.lblSub1.Location = new System.Drawing.Point(1044, 94);
            this.lblSub1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSub1.Name = "lblSub1";
            this.lblSub1.Size = new System.Drawing.Size(37, 20);
            this.lblSub1.TabIndex = 0;
            this.lblSub1.Text = "N/A";
            this.lblSub1.Click += new System.EventHandler(this.lblID_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(459, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(459, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(459, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Priority:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(1201, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Subjects";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(1017, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Type Candidate:";
            this.label8.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblSub2
            // 
            this.lblSub2.AutoSize = true;
            this.lblSub2.ForeColor = System.Drawing.Color.Navy;
            this.lblSub2.Location = new System.Drawing.Point(1217, 94);
            this.lblSub2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSub2.Name = "lblSub2";
            this.lblSub2.Size = new System.Drawing.Size(37, 20);
            this.lblSub2.TabIndex = 0;
            this.lblSub2.Text = "N/A";
            this.lblSub2.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Navy;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSua.Location = new System.Drawing.Point(383, 217);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Navy;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoa.Location = new System.Drawing.Point(1192, 215);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 29);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Navy;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLuu.Location = new System.Drawing.Point(495, 217);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Navy;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHuy.Location = new System.Drawing.Point(606, 217);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 29);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Navy;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTimKiem.Location = new System.Drawing.Point(1086, 215);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(84, 29);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblSub3
            // 
            this.lblSub3.AutoSize = true;
            this.lblSub3.ForeColor = System.Drawing.Color.Navy;
            this.lblSub3.Location = new System.Drawing.Point(1390, 101);
            this.lblSub3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSub3.Name = "lblSub3";
            this.lblSub3.Size = new System.Drawing.Size(37, 20);
            this.lblSub3.TabIndex = 0;
            this.lblSub3.Text = "N/A";
            this.lblSub3.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(568, 87);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(246, 27);
            this.txtTen.TabIndex = 1;
            // 
            // dataGridViewTK
            // 
            this.dataGridViewTK.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDtk,
            this.colTentk,
            this.colAddresstk,
            this.colPrioritytk,
            this.ColTypeCantk,
            this.colSubject1tk,
            this.colSubject2tk,
            this.colSubject3tk});
            this.dataGridViewTK.Location = new System.Drawing.Point(278, 253);
            this.dataGridViewTK.Name = "dataGridViewTK";
            this.dataGridViewTK.RowHeadersWidth = 51;
            this.dataGridViewTK.RowTemplate.Height = 24;
            this.dataGridViewTK.Size = new System.Drawing.Size(946, 82);
            this.dataGridViewTK.TabIndex = 6;
            // 
            // colIDtk
            // 
            this.colIDtk.HeaderText = "ID";
            this.colIDtk.MinimumWidth = 6;
            this.colIDtk.Name = "colIDtk";
            this.colIDtk.Width = 50;
            // 
            // colTentk
            // 
            this.colTentk.HeaderText = "Họ Tên";
            this.colTentk.MinimumWidth = 6;
            this.colTentk.Name = "colTentk";
            this.colTentk.Width = 250;
            // 
            // colAddresstk
            // 
            this.colAddresstk.HeaderText = "Address";
            this.colAddresstk.MinimumWidth = 6;
            this.colAddresstk.Name = "colAddresstk";
            this.colAddresstk.Width = 150;
            // 
            // colPrioritytk
            // 
            this.colPrioritytk.HeaderText = "Priority";
            this.colPrioritytk.MinimumWidth = 6;
            this.colPrioritytk.Name = "colPrioritytk";
            this.colPrioritytk.Width = 75;
            // 
            // ColTypeCantk
            // 
            this.ColTypeCantk.HeaderText = "Type Candidate";
            this.ColTypeCantk.MinimumWidth = 6;
            this.ColTypeCantk.Name = "ColTypeCantk";
            this.ColTypeCantk.Width = 125;
            // 
            // colSubject1tk
            // 
            this.colSubject1tk.HeaderText = "Subject 1";
            this.colSubject1tk.MinimumWidth = 6;
            this.colSubject1tk.Name = "colSubject1tk";
            this.colSubject1tk.Width = 80;
            // 
            // colSubject2tk
            // 
            this.colSubject2tk.HeaderText = "Subject 2";
            this.colSubject2tk.MinimumWidth = 6;
            this.colSubject2tk.Name = "colSubject2tk";
            this.colSubject2tk.Width = 80;
            // 
            // colSubject3tk
            // 
            this.colSubject3tk.HeaderText = "Subject 3";
            this.colSubject3tk.MinimumWidth = 6;
            this.colSubject3tk.Name = "colSubject3tk";
            this.colSubject3tk.Width = 80;
            // 
            // rbtnCanA
            // 
            this.rbtnCanA.AutoSize = true;
            this.rbtnCanA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnCanA.Location = new System.Drawing.Point(278, 99);
            this.rbtnCanA.Name = "rbtnCanA";
            this.rbtnCanA.Size = new System.Drawing.Size(121, 24);
            this.rbtnCanA.TabIndex = 14;
            this.rbtnCanA.TabStop = true;
            this.rbtnCanA.Text = "Candidate A";
            this.rbtnCanA.UseVisualStyleBackColor = true;
            // 
            // rbtnCanB
            // 
            this.rbtnCanB.AutoSize = true;
            this.rbtnCanB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnCanB.Location = new System.Drawing.Point(278, 133);
            this.rbtnCanB.Name = "rbtnCanB";
            this.rbtnCanB.Size = new System.Drawing.Size(122, 24);
            this.rbtnCanB.TabIndex = 15;
            this.rbtnCanB.TabStop = true;
            this.rbtnCanB.Text = "Candidate B";
            this.rbtnCanB.UseVisualStyleBackColor = true;
            // 
            // rbtnCanC
            // 
            this.rbtnCanC.AutoSize = true;
            this.rbtnCanC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnCanC.Location = new System.Drawing.Point(278, 169);
            this.rbtnCanC.Name = "rbtnCanC";
            this.rbtnCanC.Size = new System.Drawing.Size(122, 24);
            this.rbtnCanC.TabIndex = 15;
            this.rbtnCanC.TabStop = true;
            this.rbtnCanC.Text = "Candidate C";
            this.rbtnCanC.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(568, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 27);
            this.txtID.TabIndex = 16;
            // 
            // txtPri
            // 
            this.txtPri.Location = new System.Drawing.Point(568, 173);
            this.txtPri.Name = "txtPri";
            this.txtPri.Size = new System.Drawing.Size(100, 27);
            this.txtPri.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(274, 62);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Type Candidate:";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(568, 127);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(100, 27);
            this.txtAdd.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(838, 220);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Enter ID:";
            this.label13.Click += new System.EventHandler(this.label7_Click);
            // 
            // type_can
            // 
            this.type_can.AutoSize = true;
            this.type_can.ForeColor = System.Drawing.Color.Navy;
            this.type_can.Location = new System.Drawing.Point(1217, 146);
            this.type_can.Name = "type_can";
            this.type_can.Size = new System.Drawing.Size(37, 20);
            this.type_can.TabIndex = 17;
            this.type_can.Text = "N/A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(1364, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Subject 3";
            this.label11.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1201, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subject 2";
            this.label3.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(1024, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Subject 1";
            this.label10.Click += new System.EventHandler(this.label7_Click);
            // 
            // Can
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1513, 728);
            this.Controls.Add(this.type_can);
            this.Controls.Add(this.txtPri);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.rbtnCanC);
            this.Controls.Add(this.rbtnCanB);
            this.Controls.Add(this.rbtnCanA);
            this.Controls.Add(this.dataGridViewTK);
            this.Controls.Add(this.dataGridViewSV);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtNhapID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblSub3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblSub2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSub1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Can";
            this.Text = "APP CANDIDATE MANAGER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapID;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridViewSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSub1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSub2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblSub3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DataGridView dataGridViewTK;
        private System.Windows.Forms.RadioButton rbtnCanA;
        private System.Windows.Forms.RadioButton rbtnCanB;
        private System.Windows.Forms.RadioButton rbtnCanC;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPri;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDtk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTentk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddresstk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrioritytk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeCantk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject1tk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject2tk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject3tk;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label type_can;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeCan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject3;
    }
}

