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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salvarclick(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string caminho = saveFileDialog1.FileName;
            File.WriteAllText(caminho, Blocodetexto.Text);
        }
    }
}
