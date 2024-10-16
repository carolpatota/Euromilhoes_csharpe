using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3935_Carolina_T02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Random euro = new Random();

            int n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0, e1 = 0, e2 = 0;

            n1 = euro.Next(1, 51);
            do { n2 = euro.Next(1, 51); } while (n2 == n1);
            do { n3 = euro.Next(1, 51); } while (n3 == n1 || n3 == n2);
            do { n4 = euro.Next(1, 51); } while (n4 == n1 || n4 == n2 || n4 == n3);
            do { n5 = euro.Next(1, 51); } while (n5 == n1 || n5 == n2 || n5 == n3 || n5 == n4);

            e1 = euro.Next(1, 13);
            do { e2 = euro.Next(1, 13); } while (e2 == e1);

            //exibir nas labels
            lbl_n1.Text = n1.ToString();
            lbl_n2.Text = n2.ToString();
            lbl_n3.Text = n3.ToString();
            lbl_n4.Text = n4.ToString();
            lbl_n5.Text = n5.ToString();
            lbl_e1.Text = e1.ToString();
            lbl_e2.Text = e2.ToString();
        }
    }
}
