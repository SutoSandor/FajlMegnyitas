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

namespace FajlMegnyitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static StreamWriter writer = new StreamWriter("cucc.txt");
        private void hozzaad_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Contains(textBox_ujhobbi.Text))
            {
                MessageBox.Show("Ez már létezik!");
            }
            else
            {
                listBox.Items.Add(textBox_ujhobbi.Text);
                textBox_ujhobbi.Text = "";
            }


        }

        private void mentes_Click(object sender, EventArgs e)
        {
            writer.WriteLine(textBox_nev.Text+";");
            writer.WriteLine(dateTimePicker.Value+";");
            if(ferfi.Checked == true)
            {
                writer.WriteLine("Férfi;");
            }
            if(no.Checked == true)
            {
                writer.WriteLine("Nő;");
            }
            writer.WriteLine(listBox.SelectedItem+";");
            writer.Close();
        }
    }
}
