using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThanksgivingScramble
{
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        string wordsPath = @"C:\Users\DeltaDizzy\Documents";
        List<string> words = new List<string>();
        private void GetWords()
        {
            words.Clear();
            words = File.ReadAllLines(wordsPath).ToList();
            util.unscrambledWords = words;
            File.WriteAllLines(wordsPath, words.ToArray());

        }
    }
}
