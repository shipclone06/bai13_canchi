using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai13_canchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            string[] canArr = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ki" };
            string[] chiArr = { "Than", "Dau", "Tuat", "Hoi", "Ty", " Suu", "Dan", "Mao", "Thin", "Ty", "Ngon", "Mui" };

            string giatritrave = canArr[Convert.ToInt32(txtnam.Text) % 10] + " " + chiArr[Convert.ToInt32(txtnam.Text) % 12];
            txtcanchi.Text = giatritrave;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           for (int i = 2000; i <= 2050; i++) {
                lstnam.Items.Add(i+ "-" + );
        }
    }

        private void nam_Click(object sender, EventArgs e)
        {

        }
    }
