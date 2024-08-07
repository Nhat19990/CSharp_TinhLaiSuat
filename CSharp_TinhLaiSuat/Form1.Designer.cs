namespace CSharp_TinhLaiSuat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSoTien = new TextBox();
            cbxLaiSuat = new ComboBox();
            nudSoNam = new NumericUpDown();
            btnTinh = new Button();
            label5 = new Label();
            lsbKetqua = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudSoNam).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(207, 21);
            label1.Name = "label1";
            label1.Size = new Size(343, 28);
            label1.TabIndex = 0;
            label1.Text = "ỨNG DỤNG TÍNH LÃI SUẤT TIẾP KIỆM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(80, 81);
            label2.Name = "label2";
            label2.Size = new Size(53, 13);
            label2.TabIndex = 1;
            label2.Text = "SỐ TIỀN:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F);
            label3.Location = new Point(80, 123);
            label3.Name = "label3";
            label3.Size = new Size(58, 13);
            label3.TabIndex = 2;
            label3.Text = "LÃI SUẤT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F);
            label4.Location = new Point(80, 160);
            label4.Name = "label4";
            label4.Size = new Size(74, 13);
            label4.TabIndex = 3;
            label4.Text = "SỐ NĂM GỬI:";
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(220, 77);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(189, 23);
            txtSoTien.TabIndex = 4;
            // 
            // cbxLaiSuat
            // 
            cbxLaiSuat.FormattingEnabled = true;
            cbxLaiSuat.Location = new Point(220, 120);
            cbxLaiSuat.Name = "cbxLaiSuat";
            cbxLaiSuat.Size = new Size(189, 23);
            cbxLaiSuat.TabIndex = 5;
            // 
            // nudSoNam
            // 
            nudSoNam.Location = new Point(220, 157);
            nudSoNam.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudSoNam.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoNam.Name = "nudSoNam";
            nudSoNam.Size = new Size(189, 23);
            nudSoNam.TabIndex = 6;
            nudSoNam.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(342, 204);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(96, 28);
            btnTinh.TabIndex = 7;
            btnTinh.Text = "TÍNH";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 249);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 8;
            label5.Text = "KẾT QUẢ";
            // 
            // lsbKetqua
            // 
            lsbKetqua.FormattingEnabled = true;
            lsbKetqua.ItemHeight = 15;
            lsbKetqua.Location = new Point(49, 276);
            lsbKetqua.Name = "lsbKetqua";
            lsbKetqua.Size = new Size(739, 229);
            lsbKetqua.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 517);
            Controls.Add(lsbKetqua);
            Controls.Add(label5);
            Controls.Add(btnTinh);
            Controls.Add(nudSoNam);
            Controls.Add(cbxLaiSuat);
            Controls.Add(txtSoTien);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudSoNam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSoTien;
        private ComboBox cbxLaiSuat;
        private NumericUpDown nudSoNam;
        private Button btnTinh;
        private Label label5;
        private ListBox lsbKetqua;
    }
}
