using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_C_
{
    public partial class Form_DK : Form
    {
        private String taikhoan;

        private String matkhau;
        private String sdt;

        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Sdt { get => sdt; set => sdt = value; }

        public Form_DK()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_DKTK.Text) || string.IsNullOrEmpty(txt_DKMK.Text) || string.IsNullOrEmpty(txt_SDT.Text))
            {
                MessageBox.Show("Vui long nhap day du thong tin !!!", "Canh bao", MessageBoxButtons.OK);
            }
            else
            {
                taikhoan = txt_TK.Text;
                if (txt_DKMK.Text.Length < 8 || !Regex.IsMatch(txt_DKMK.Text, "[A-Z]") || !Regex.IsMatch(txt_DKMK.Text, "[a-z]") || !Regex.IsMatch(txt_DKMK.Text, "[0-9]"))
                {
                    MessageBox.Show("Vui long nhap password 8 ki tu co so [0->9] va ki tu[A->Z]", "Canh bao", MessageBoxButtons.OK);
                }
                else { matkhau = txt_DKMK.Text; }
                if(txt_SDT.Text.Length !=10 ||  !Regex.IsMatch(txt_DKMK.Text, "[0-9]"))
                {
                    MessageBox.Show("Vui long nhap dung sdt  !!!", "Canh bao", MessageBoxButtons.OK);
                }
                sdt = txt_SDT.Text;
                MessageBox.Show("Dang ky tai khoan thanh cong !!!", "Canh bao", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void Form_DK_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
