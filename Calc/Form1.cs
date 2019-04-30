using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }
        public string base162(string st)
        {
            string ntfs = " ";
            switch (st)
            {
                case "0": ntfs = "0000"; break;
                case "1": ntfs = "0001"; break;
                case "2": ntfs = "0010"; break;
                case "3": ntfs = "0011"; break;
                case "4": ntfs = "0100"; break;
                case "5": ntfs = "0101"; break;
                case "6": ntfs = "0110"; break;
                case "7": ntfs = "0111"; break;
                case "8": ntfs = "1000"; break;
                case "9": ntfs = "1001"; break;
                case "A": ntfs = "1010"; break;
                case "B": ntfs = "1011"; break;
                case "C": ntfs = "1100"; break;
                case "D": ntfs = "1101"; break;
                case "E": ntfs = "1110"; break;
                case "F": ntfs = "1111"; break;
            }

            return ntfs;
        }
        public string base82(string st)
        {
            string rtur = " ";
            switch (st)
            {
                case "0": rtur = "000"; break;
                case "1": rtur = "001"; break;
                case "2": rtur = "010"; break;
                case "3": rtur = "011"; break;
                case "4": rtur = "100"; break;
                case "5": rtur = "101"; break;
                case "6": rtur = "110"; break;
                case "7": rtur = "111"; break;
            }

            return rtur;
        }
        public string base8(string st)
        {
            string rtur = " ";
            switch (st)
            {
                case "000": rtur = "0"; break;
                case "001": rtur = "1";
                    break;
                case "011": rtur = "3"; break;
                case "100": rtur = "4"; break;
                case "101": rtur = "5"; break;
                case "110": rtur = "6"; break;
                case "111": rtur = "7"; break;
            }

            return rtur;
        }

        public string base16(string st)
        {
            string ntfs = " ";
            switch (st)
            {
                case "0000": ntfs = "0"; break;
                case "0001": ntfs = "1"; break;
                case "0010": ntfs = "2"; break;
                case "0011": ntfs = "3"; break;
                case "0100": ntfs = "4"; break;
                case "0101": ntfs = "5"; break;
                case "0110": ntfs = "6"; break;
                case "0111": ntfs = "7"; break;
                case "1000": ntfs = "8"; break;
                case "1001": ntfs = "9"; break;
                case "1010": ntfs = "A"; break;
                case "1011": ntfs = "B"; break;
                case "1100": ntfs = "C"; break;
                case "1101": ntfs = "D"; break;
                case "1110": ntfs = "E"; break;
                case "1111": ntfs = "F"; break;
            }

            return ntfs;
        }
        public double transf10(string st, int bas)
        {
            double jj;
            string s = null;
            List<int> tabj = new List<int>();
            int kj = Convert.ToInt32(st);
            while (kj / bas != 0)
            {
                tabj.Add(kj % bas);
                kj = kj / bas;

            }
            if (kj < bas && kj != 0)
            {
                tabj.Add(kj);
            }

            int din = tabj.Count - 1;
            for (int k = tabj.Count - 1; k >= 0; k--)
            {
                s += Convert.ToString(tabj[k]);
            }

            jj = Convert.ToDouble(s);
            return jj;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }



        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

            string st;
            double j = 0;
            string n = " ";
            st = textBox1.Text;
            string s = null;
            #region Base2

            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1 && textBox1.Text != "")
            {
                string stockbase = null;
                int remp = st.Length;
                int index = remp - 3;
                string str = null;
                string remplace = null;
                do
                {
                    str = null;

                    for (int i = index; i < remp; i++)
                    {
                        str += st[i];
                    }

                    int kap;
                    if (str == null)
                    {
                        kap = 0;
                    }
                    else
                    {
                        kap = str.Length;
                    }

                    if (kap < 3 && kap > 0)
                    {
                        string re = str;
                        str = null;
                        if (re != null)
                        {
                            for (int jIndex = re.Length; jIndex < 3; jIndex++)
                            {
                                str += "0";
                            }
                        }
                        str += re;
                        remplace += base8(str);
                    }
                    else
                    {
                        remplace += base8(str);
                    }

                    remp = index;
                    if (index > 3)
                    {
                        index -= 3;
                    }
                    else
                    {
                        index = 0;
                    }

                } while (str != null);

                for (int i = remplace.Length - 1; i >= 0; i--)
                {
                    stockbase += remplace[i];
                }

                j = Convert.ToDouble(stockbase);
            }

            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3 && textBox1.Text != "")
            {
                string stockbase = null;
                int remp = st.Length;
                int index = remp - 4;
                string str = null;
                string remplace = null;
                do
                {
                    str = null;

                    for (int i = index; i < remp; i++)
                    {
                        str += st[i];
                    }

                    int kap;
                    if (str == null)
                    {
                        kap = 0;
                    }
                    else
                    {
                        kap = str.Length;
                    }

                    if (kap < 4 && kap > 0)
                    {
                        string re = str;
                        str = null;
                        if (re != null)
                        {
                            for (int jIndex = re.Length; jIndex < 4; jIndex++)
                            {
                                str += "0";
                            }
                        }
                        str += re;
                        remplace += base16(str);
                    }
                    else
                    {
                        remplace += base16(str);
                    }

                    remp = index;
                    if (index > 4)
                    {
                        index -= 4;
                    }
                    else
                    {
                        index = 0;
                    }

                } while (str != null);

                for (int i = remplace.Length - 1; i >= 0; i--)
                {
                    stockbase += remplace[i];
                }
                s = stockbase;
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2 && textBox1.Text != "")
            {
                int hum = 0;
                for (int i = st.Length - 1; i >= 0; i--)
                {
                    if (st[i] == '1' || st[i] == '0')
                    {
                        n = Convert.ToString(st[i]);
                        int a = Convert.ToInt32(n);
                        j += a * Math.Pow(2, hum);
                        hum++;
                    }
                }
            }
            #endregion

            #region Base8
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 && textBox1.Text != "")
            {
                string stockbase = null;
                string str;
                for (int i = 0; i < st.Length; i++)
                {
                    str = Convert.ToString(st[i]);
                    stockbase += base82(str);
                }
                j = Convert.ToDouble(stockbase);
            }

            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3 && textBox1.Text != "")
            {
                string stockbase = null;
                string str;
                for (int i = 0; i < st.Length; i++)
                {
                    str = Convert.ToString(st[i]);
                    stockbase += base82(str);
                }

                string save = stockbase;
                int remp = save.Length;
                int index = remp - 4;
                str = null;
                string remplace = null;

                do
                {
                    str = null;

                    for (int i = index; i < remp; i++)
                    {
                        str += save[i];
                    }

                    int kap;
                    if (str == null)
                    {
                        kap = 0;
                    }
                    else
                    {
                        kap = str.Length;
                    }

                    if (kap < 4 && kap > 0)
                    {
                        string re = str;
                        str = null;
                        if (re != null)
                        {
                            for (int jIndex = re.Length; jIndex < 4; jIndex++)
                            {
                                str += "0";
                            }
                        }
                        str += re;
                        remplace += base16(str);
                    }
                    else
                    {
                        remplace += base16(str);
                    }

                    remp = index;
                    if (index > 4)
                    {
                        index -= 4;
                    }
                    else
                    {
                        index = 0;
                    }

                } while (str != null);
                string captch = null;
                for (int i = remplace.Length - 1; i >= 0; i--)
                {
                    captch += remplace[i];
                }
                s = captch;
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2 && textBox1.Text != "")
            {
                int numLength = st.Length;
                for (int i = 0; i < st.Length; i++)
                {
                    if (st[i] == '0' || st[i] == '1' || st[i] == '2' || st[i] == '3' || st[i] == '4' || st[i] == '5' || st[i] == '6' || st[i] == '7')
                    {
                        n = Convert.ToString(st[i]);
                        int a = Convert.ToInt32(n);
                        j += a * Math.Pow(8, numLength - 1);
                    }

                    numLength--;
                }
            }
            #endregion

            #region Base10

            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0 && textBox1.Text != "")
            {
                j = transf10(st, 2);
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1 && textBox1.Text != "")
            {
                j = transf10(st, 8);
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 3 && textBox1.Text != "")
            {
                List<int> tabj = new List<int>();
                int kj = Convert.ToInt32(st);
                while (kj / 16 != 0)
                {
                    tabj.Add(kj % 16);
                    kj = kj / 16;

                }
                if (kj < 16 && kj != 0)
                {
                    tabj.Add(kj);
                }

                int din = tabj.Count - 1;
                for (int k = tabj.Count - 1; k >= 0; k--)
                {
                    if (tabj[k] > 9)
                    {
                        if (tabj[k] == 10)
                        {
                            s += "A";
                        }
                        else if (tabj[k] == 11)
                        {
                            s += "B";
                        }
                        else if (tabj[k] == 12)
                        {
                            s += "C";
                        }
                        else if (tabj[k] == 13)
                        {
                            s += "D";
                        }
                        else if (tabj[k] == 14)
                        {
                            s += "E";
                        }
                        else if (tabj[k] == 15)
                        {
                            s += "F";
                        }
                    }
                    else
                    {
                        s += Convert.ToString(tabj[k]);
                    }
                }
            }


            #endregion

            #region Base16

            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 0 && textBox1.Text != "")
            {
                string stockbase = null;
                string str;
                for (int i = 0; i < st.Length; i++)
                {
                    str = Convert.ToString(st[i]);
                    stockbase += base162(str);
                }
                j = Convert.ToDouble(stockbase);
            }


            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 1 && textBox1.Text != "")
            {
                string stockbase = null;
                string str;
                for (int i = 0; i < st.Length; i++)
                {
                    str = Convert.ToString(st[i]);
                    stockbase += base162(str);
                }

                string save = stockbase;
                int remp = save.Length;
                int index = remp - 3;
                string remplace = null;
                do
                {
                    str = null;

                    for (int i = index; i < remp; i++)
                    {
                        str += save[i];
                    }

                    int kap;
                    if (str == null)
                    {
                        kap = 0;
                    }
                    else
                    {
                        kap = str.Length;
                    }

                    if (kap < 3 && kap > 0)
                    {
                        string re = str;
                        str = null;
                        if (re != null)
                        {
                            for (int jIndex = re.Length; jIndex < 3; jIndex++)
                            {
                                str += "0";
                            }
                        }
                        str += re;
                        remplace += base8(str);
                    }
                    else
                    {
                        remplace += base8(str);
                    }

                    remp = index;
                    if (index > 3)
                    {
                        index -= 3;
                    }
                    else
                    {
                        index = 0;
                    }

                } while (str != null);

                string captch = null;
                for (int i = remplace.Length - 1; i >= 0; i--)
                {
                    captch += remplace[i];
                }

                j = Convert.ToDouble(captch);
            }


            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 2 && textBox1.Text != "")
            {
                int numLength = st.Length;
                for (int i = 0; i < st.Length; i++)
                {
                    switch (st[i])
                    {
                        case '0': n = "0"; break;
                        case '1': n = "1"; break;
                        case '2': n = "2"; break;
                        case '3': n = "3"; break;
                        case '4': n = "4"; break;
                        case '5': n = "5"; break;
                        case '6': n = "6"; break;
                        case '7': n = "7"; break;
                        case '8': n = "8"; break;
                        case '9': n = "9"; break;
                        case 'a': n = "10"; break;
                        case 'b': n = "11"; break;
                        case 'c': n = "12"; break;
                        case 'd': n = "13"; break;
                        case 'e': n = "14"; break;
                        case 'f': n = "15"; break;
                    }

                    int a = Convert.ToInt32(n);
                    j += a * Math.Pow(16, numLength - 1);
                    numLength--;
                }


            }

            #endregion
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Entrer une valeur s'il-vous-plait !!", "Erreur", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else if (comboBox1.SelectedIndex == comboBox2.SelectedIndex)
            {
                j = Convert.ToDouble(textBox1.Text);
            }


            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 3 || comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3 || comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3)
            {
                textBox2.Visible = true;
                textBox2.Text = s;
            }
            else
            {
                textBox2.Visible = true;
                textBox2.Text = Convert.ToString(j);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
