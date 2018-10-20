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
        private DateTime now = DateTime.Now;
        private string [] tartalom = new string[4];
        //Getek
        private string get_nev()
        {
            return textBox_nev.Text;
        }
        private DateTime get_dateTime()
        {
            return dateTimePicker.Value.Date;
        }
        private string get_nem()
        {
            string nem;
            if (ferfi.Checked == true)
            {
                nem = ("Férfi");
            }
            else
            {
                nem = ("Nő");
            }
            return nem;
        }
        private string get_listBox()
        {
            return Convert.ToString(listBox.SelectedItem);
        }
        //Setek
        private void set_nev(string nev)
        {
            textBox_nev.Text = nev;
        }
        private void set_dateTime(DateTime date)
        {
            dateTimePicker.Value = date;
        }
        private void set_nem(string nem)
        {
            if (nem == "Férfi")
            {
                ferfi.Checked = true;
            }
            else
            {
                no.Checked = true;
            }
        }
        private void set_listBox(string item)
        {
            if (listBox.Items.Contains(item))
            {
                listBox.SelectedItem = item;
            }
            else
            {
                listBox.Items.Add(item);
                listBox.SelectedItem = item;
            }
        }
        //Gomb funckiók
        private void hozzaad_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Contains(textBox_ujhobbi.Text))
            {
                MessageBox.Show("Ez már létezik!");
            }
            else
            {
                listBox.Items.Add(textBox_ujhobbi.Text);
                listBox.SelectedItem = textBox_ujhobbi.Text;
                textBox_ujhobbi.Text = "";
            }
        }
        private void mentes_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(get_nev()) || get_dateTime()>now || String.IsNullOrEmpty(get_listBox()))
            {
                MessageBox.Show("Nem megfelelően megadott adatok!");
            }
            else
            {
                try
                {
                    tartalom[0] += get_nev();
                    tartalom[1] += get_dateTime();
                    tartalom[2] += get_nem();
                    tartalom[3] += get_listBox();
                    var eredmeny = saveFileDialog.ShowDialog(this);
                    if (eredmeny == DialogResult.OK)
                    {
                        string fileNev = saveFileDialog.FileName;
                        using (var file = File.CreateText(fileNev))
                        {
                            file.Write(tartalom);
                        }
                        File.WriteAllLines(fileNev,tartalom);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
                Array.Clear(tartalom, 0, 4);
            }
        }
        private void betoltes_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                set_nev(File.ReadAllLines(openFileDialog.FileName)[0]);
                set_dateTime(Convert.ToDateTime(File.ReadAllLines(openFileDialog.FileName)[1]));
                set_nem(File.ReadAllLines(openFileDialog.FileName)[2]);
                set_listBox(File.ReadAllLines(openFileDialog.FileName)[3]);
            }
        }
    }
}
