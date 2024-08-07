using System.Globalization;

namespace CSharp_TinhLaiSuat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (double i = 0.01; i <= 0.101; i += 0.001)
            {
                cbxLaiSuat.Items.Add(string.Format("{0:P1}", Math.Round(i, 3)));
            }
            txtSoTien.Text = "10000000";
            cbxLaiSuat.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            lsbKetqua.Items.Clear();
            double sotien = Convert.ToInt64(txtSoTien.Text);
            int sonam = (int)nudSoNam.Value;
            double laiSuat = Double.Parse(cbxLaiSuat.SelectedItem.ToString().Replace("%", "")) / 100;
            MessageBox.Show("lai Suat " + laiSuat);
            for (int i = 1; i <= sonam; i++)
            {
                double tienlai = sotien * laiSuat;
                lsbKetqua.Items.Add("Năm " + i + " Tiền gốc: " + sotien.ToString("N", new CultureInfo("en-US")) + " - Lãi: " + tienlai.ToString("N", new CultureInfo("en-US")));
                sotien += tienlai;
            }
        }
    }
}
