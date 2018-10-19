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

            save.Click += (sender, e) =>
            {
                Mentes();
            };
            open.Click += (sender, e) =>
            {
                Megnyitas();
            };
        }
        private void Mentes()
        {
            string tartalom = textbox.Text;
            
            var eredmeny = saveFileDialog.ShowDialog(this);
            if(eredmeny == DialogResult.OK)
            {
                string fileNev = saveFileDialog.FileName;
                using (var file = File.CreateText(fileNev))
                {
                    file.Write(tartalom);
                }
                File.WriteAllText(fileNev,tartalom);
            }
        }
        private void Megnyitas()
        {
            if(openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                textbox.Text = File.ReadAllText(openFileDialog.FileName);
                 
            }
        }
    }
}
