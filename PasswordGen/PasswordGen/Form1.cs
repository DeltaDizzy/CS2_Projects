using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGen
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        static string letterstring = "abcdefghijklmnopqrstuvwxyz0123456789";
        List<string> charlist = SplitString(letterstring).ToList();
        List<string> specialChars = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private string GetRandomChar()
        {
            int charclass;
            if (txtSpecialChars.TextLength == 0)
            {
                charclass = r.Next(0, 2);
            }
            else
            {
                charclass = r.Next(0, 3);
            }
            switch (charclass)
            {
                case 0:
                    int upper = r.Next(0, 2);
                    if (upper == 0)
                    {
                        return charlist[r.Next(0, 25)];
                    }
                    else
                    {
                        return charlist[r.Next(0, 25)].ToUpper();
                    }
                case 1:
                    return charlist[r.Next(26, charlist.IndexOf(charlist.Last()) + 1)];
                case 2:
                    return specialChars[r.Next(0, specialChars.Count)];
                default:
                    return null;
            }
        }

        private static string[] SplitString(string toSplit)
        {
            string[] array = new string[toSplit.Length];
            for (int i = 0; i < toSplit.Length; i++)
            {
                array[i] = toSplit[i].ToString();
            }
            return array;
        }

        private static string CombineString(string[] array)
        {
            string res = string.Empty;
            foreach (string item in array)
            {
                res += item;
            }
            return res;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nudNumChars.Minimum = 8;
            //txtSpecialChars.Text = "!,@,#,$,%,^,&,*";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            specialChars = SplitString(txtSpecialChars.Text).ToList();
            string[] msg = new string[(int)nudNumChars.Value];
            for (int i = 0; i < msg.Length; i++)
            {
                msg[i] = GetRandomChar();
            }
            MessageBox.Show(CombineString(msg));
        }
    }
}
