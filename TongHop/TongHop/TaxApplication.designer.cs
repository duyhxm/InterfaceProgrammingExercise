namespace TaxApp
{
    partial class TaxApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_TAm = new System.Windows.Forms.TextBox();
            this.txtb_TDu = new System.Windows.Forms.TextBox();
            this.lbl_taxper = new System.Windows.Forms.Label();
            this.btn_Com = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(285, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tax Calculation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(129, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(129, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tax Percentage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(129, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Due";
            // 
            // txtb_TAm
            // 
            this.txtb_TAm.Location = new System.Drawing.Point(376, 134);
            this.txtb_TAm.Name = "txtb_TAm";
            this.txtb_TAm.Size = new System.Drawing.Size(100, 22);
            this.txtb_TAm.TabIndex = 1;
            this.txtb_TAm.TextChanged += new System.EventHandler(this.txtb_TAm_TextChanged);
            // 
            // txtb_TDu
            // 
            this.txtb_TDu.Location = new System.Drawing.Point(376, 272);
            this.txtb_TDu.Name = "txtb_TDu";
            this.txtb_TDu.Size = new System.Drawing.Size(100, 22);
            this.txtb_TDu.TabIndex = 1;
            // 
            // lbl_taxper
            // 
            this.lbl_taxper.AutoSize = true;
            this.lbl_taxper.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_taxper.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_taxper.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_taxper.Location = new System.Drawing.Point(385, 198);
            this.lbl_taxper.Name = "lbl_taxper";
            this.lbl_taxper.Size = new System.Drawing.Size(71, 29);
            this.lbl_taxper.TabIndex = 2;
            this.lbl_taxper.Text = "7.5%";
            // 
            // btn_Com
            // 
            this.btn_Com.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Com.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Com.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Com.Location = new System.Drawing.Point(358, 332);
            this.btn_Com.Name = "btn_Com";
            this.btn_Com.Size = new System.Drawing.Size(153, 41);
            this.btn_Com.TabIndex = 3;
            this.btn_Com.Text = "Compute";
            this.btn_Com.UseVisualStyleBackColor = false;
            this.btn_Com.Click += new System.EventHandler(this.btn_Com_Click);
            // 
            // TaxApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Com);
            this.Controls.Add(this.lbl_taxper);
            this.Controls.Add(this.txtb_TDu);
            this.Controls.Add(this.txtb_TAm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "TaxApplication";
            this.Text = "Windows Tax App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_TAm;
        private System.Windows.Forms.TextBox txtb_TDu;
        private System.Windows.Forms.Label lbl_taxper;
        private System.Windows.Forms.Button btn_Com;
    }
}

