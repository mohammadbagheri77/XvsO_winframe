using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xowinframe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int count = 1;
        public int count_x = 0;
        public int count_o = 0;
        ///------------------سطر
        public string add_a;
        public string add_b;
        public string add_c;
        ///------------------ستون
        public string add_x;
        public string add_y;
        public string add_z;
        ///------------------قطر
        public string add_m;
        public string add_n;

        ////////////////////////////////////////////////////////

        private void Btn_1_Click(object sender, EventArgs e)
        {
            if (count <= 9)
            {
                if (!btn_1.Text.Contains("_"))
                {
                    btn_1.Text = Pub(count) + "_".ToString();
                    add_a += Pub(count);
                    add_x += Pub(count);
                    add_m += Pub(count);
                    count++;
                    lbl_1.Text = is_por().ToString();
                    if(is_por() == "--OOO--")
                    {
                        MessageBox.Show("برنده ");
                        rest(true);
                        count_o++;
                    }else if (is_por() == "--XXX--")
                    {
                        MessageBox.Show("برنده ");
                        rest(true);
                        count_x++;
                    }
                }
            }
        }
        private void Btn_2_Click(object sender, EventArgs e)
        {
            if (count <= 9)
            {
                if (!btn_2.Text.Contains("_"))
                {
                    btn_2.Text = Pub(count) + "_".ToString();
                    add_a += Pub(count);
                    add_y += Pub(count);
                    count++;
                    lbl_1.Text = is_por().ToString();
                    if (is_por() == "--OOO--")
                    {
                        MessageBox.Show("برنده ");
                        rest(true);
                        count_o++;
                    }
                    else if (is_por() == "--XXX--")
                    {
                        MessageBox.Show("برنده ");
                        rest(true);
                        count_x++;
                    }
                }
            }
        }
        private void Btn_3_Click(object sender, EventArgs e)
        {
            if (count <= 9)
            {
                if (!btn_3.Text.Contains("_"))
                {
                    btn_3.Text = Pub(count) + "_".ToString();
                    add_a += Pub(count);
                    add_z += Pub(count);
                    add_n += Pub(count);
                    count++;
                    lbl_1.Text = is_por().ToString();
                    if (is_por() == "--OOO--")
                    {
                        MessageBox.Show("برنده ");
                        rest(true);
                        count_o++;
                    }
                    else if (is_por() == "--XXX--")
                    {
                        MessageBox.Show("برنده ");
                        rest(true);
                        count_x++;
                    }
                }
            }
        }
        private void Btn_4_Click(object sender, EventArgs e)
        {
            if (count <= 9)
            {
                if (!btn_4.Text.Contains("_"))
                {
                    btn_4.Text = Pub(count) + "_".ToString();
                    add_b += Pub(count);
                    add_x += Pub(count);
                    count++;
                    lbl_1.Text = is_por().ToString();
                    if (is_por() == "--OOO--")
                    {
                        MessageBox.Show("برنده ");
                        rest(true);
                        count_o++;
                    }
                    else if (is_por() == "--XXX--")
                    {
                        MessageBox.Show("برنده ");
                        rest(true);
                        count_x++;
                    }
                }
            }
        }
        private void Btn_5_Click(object sender, EventArgs e)
        {
            if (count <= 9)
            {
                if (!btn_5.Text.Contains("_"))
                {
                    btn_5.Text = Pub(count) + "_".ToString();
                    add_b += Pub(count);
                    add_y += Pub(count);
                    add_m += Pub(count);
                    add_n += Pub(count);
                    count++;
                    lbl_1.Text = is_por().ToString();
                    if (is_por() == "--OOO--")
                    {
                        MessageBox.Show("برنده ");
                        rest(true);
                        count_o++;
                    }
                    else if (is_por() == "--XXX--")
                    {
                        MessageBox.Show("برنده ");
                        rest(true);
                        count_x++;
                    }
                }
            }
        }
        private void Btn_6_Click(object sender, EventArgs e)
        {
            if (count <= 9)
            {
                if (!btn_6.Text.Contains("_"))
                {
                    btn_6.Text = Pub(count) + "_".ToString();
                    add_b += Pub(count);
                    add_z += Pub(count);
                    count++;
                    lbl_1.Text = is_por().ToString();
                    if (is_por() == "--OOO--")
                    {
                        MessageBox.Show("برنده ");
                        rest(true);
                        count_o++;
                    }
                    else if (is_por() == "--XXX--")
                    {
                        MessageBox.Show("برنده ");
                        rest(true);
                        count_x++;
                    }
                }
            }
        }
        private void Btn_7_Click(object sender, EventArgs e)
        {
            if (count <= 9)
            {
                if (!btn_7.Text.Contains("_"))
                {
                    btn_7.Text = Pub(count) + "_".ToString();
                    add_c += Pub(count);
                    add_x += Pub(count);
                    add_n += Pub(count);
                    count++;
                    lbl_1.Text = is_por().ToString();
                    if (is_por() == "--OOO--")
                    {
                        MessageBox.Show("برنده ");
                        rest(true);
                        count_o++;
                    }
                    else if (is_por() == "--XXX--")
                    {
                        MessageBox.Show("برنده ");
                        rest(true);
                        count_x++;
                    }
                }
            }
        }
        private void Btn_8_Click(object sender, EventArgs e)
        {
            if (count <= 9)
            {
                if (!btn_8.Text.Contains("_"))
                {
                    btn_8.Text = Pub(count) + "_".ToString();
                    add_c += Pub(count);
                    add_y += Pub(count);
                    count++;
                    lbl_1.Text = is_por().ToString();
                    if (is_por() == "--OOO--")
                    {
                        MessageBox.Show("برنده ");
                        rest(true);
                        count_o++;
                    }
                    else if (is_por() == "--XXX--")
                    {
                        MessageBox.Show("برنده ");
                        rest(true);
                        count_x++;
                    }
                }
            }
        }
        private void Btn_9_Click(object sender, EventArgs e)
        {
            if (count <= 9)
            {
                if (!btn_9.Text.Contains("_"))
                {
                    btn_9.Text = Pub(count) + "_".ToString();
                    add_c += Pub(count);
                    add_z += Pub(count);
                    add_m += Pub(count);
                    count++;
                    lbl_1.Text = is_por().ToString();
                    if (is_por() == "--OOO--")
                    {
                        MessageBox.Show("برنده ");
                        rest(true);
                        count_o++;
                    }
                    else if (is_por() == "--XXX--")
                    {
                        MessageBox.Show("برنده ");
                        rest(true);
                        count_x++;
                    }
                }
            }
        }
        private void Btn_rest_Click(object sender, EventArgs e)
        {
            rest(true);
        }
        ////////////////////////////////////////////////////////
        private void TableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {


        }
        private void Lbl_1_Click(object sender, EventArgs e)
        {

        }
        ////////////////////////////////////////////////////////
       
        ///////////////////////////////////////////////////////
        string Res = "";
        string Res2 = "";
       
        public string Pub(int First)
        {
            if (First == 1)
            {
                return Res = "O";
            }
            else if (First == 2)
            {
                return Res = "X";
            }
            else if (First == 3)
            {
                return Res = "O";
            }
            else if (First == 4)
            {
                return Res = "X";
            }
            else if (First == 5)
            {
                return Res = "O";
            }
            else if (First == 6)
            {
                return Res = "X";
            }
            else if (First == 7)
            {
                return Res = "O";
            }
            else if (First == 8)
            {
                return Res = "X";
            }
            else if (First == 9)
            {
                return Res = "O";
            }
            return Res;
        }
        public string is_por()
        {
            if (add_a == "OOO")
            {
                return Res2 = "--OOO--";

            }
            else if (add_b == "OOO")
            {
                return Res2 = "--OOO--";

            }
            else if (add_c == "OOO")
            {
                return Res2 = "--OOO--";

            }
            else if (add_x == "OOO")
            {
                return Res2 = "--OOO--";

            }
            else if (add_y == "OOO")
            {
                return Res2 = "--OOO--";

            }
            else if (add_z == "OOO")
            {
                return Res2 = "--OOO--";

            }
            else if (add_m == "OOO")
            {
                return Res2 = "--OOO--";
            }
            else if (add_n == "OOO")
            {
                return Res2 = "--OOO--";
            }
            else if (add_a == "XXX")
            {
                return Res2 = "--XXX--";

            }
            else if (add_b == "XXX")
            {
                return Res2 = "--XXX--";

            }
            else if (add_c == "XXX")
            {
                return Res2 = "--XXX--";

            }
            else if (add_x == "XXX")
            {
                return Res2 = "--XXX--";

            }
            else if (add_y == "XXX")
            {
                return Res2 = "--XXX--";

            }
            else if (add_z == "XXX")
            {
                return Res2 = "--XXX--";

            }
            else if (add_m == "XXX")
            {
                return Res2 = "--XXX--";

            }
            else if (add_n == "XXX")
            {
                return Res2 = "--XXX--";

            }

            return Res2 = "------O : " + count_o +" VS "+count_x+" : X------";
        }
        public bool rest (bool rest)
        {   if(rest == true)
            {
            count = 1;
            ///------------------کلید
            btn_1.Text = "".ToString();
            btn_2.Text = "".ToString();
            btn_3.Text = "".ToString();
            btn_4.Text = "".ToString();
            btn_5.Text = "".ToString();
            btn_6.Text = "".ToString();
            btn_7.Text = "".ToString();
            btn_8.Text = "".ToString();
            btn_9.Text = "".ToString();
            ///------------------سطر
            add_a = "";
            add_b = "";
            add_c = "";
            ///------------------ستون
            add_x = "";
            add_y = "";
            add_z = "";
            ///------------------قطر
            add_m = "";
            add_n = "";
            }
            return rest;
        }

       
    }
}
