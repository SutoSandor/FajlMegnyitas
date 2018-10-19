namespace FajlMegnyitas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.betoltes = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mentes = new System.Windows.Forms.Button();
            this.hozzaad = new System.Windows.Forms.Button();
            this.nev = new System.Windows.Forms.Label();
            this.szuldatum = new System.Windows.Forms.Label();
            this.nem = new System.Windows.Forms.Label();
            this.hobbi = new System.Windows.Forms.Label();
            this.ujhobbi = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ferfi = new System.Windows.Forms.RadioButton();
            this.no = new System.Windows.Forms.RadioButton();
            this.textBox_ujhobbi = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // betoltes
            // 
            this.betoltes.AccessibleName = "";
            this.betoltes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.betoltes.Location = new System.Drawing.Point(463, 264);
            this.betoltes.Name = "betoltes";
            this.betoltes.Size = new System.Drawing.Size(106, 37);
            this.betoltes.TabIndex = 0;
            this.betoltes.Text = "Betöltés";
            this.betoltes.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Szöveges Fájlok|*.txt|Minden fájl|*.* ";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.CheckFileExists = true;
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Szöveges Fájlok|*.txt|Minden fájl|*.* ";
            // 
            // mentes
            // 
            this.mentes.AccessibleName = "";
            this.mentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentes.Location = new System.Drawing.Point(348, 264);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(109, 37);
            this.mentes.TabIndex = 1;
            this.mentes.Text = "Mentés";
            this.mentes.UseVisualStyleBackColor = true;
            this.mentes.Click += new System.EventHandler(this.mentes_Click);
            // 
            // hozzaad
            // 
            this.hozzaad.AccessibleName = "";
            this.hozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hozzaad.Location = new System.Drawing.Point(348, 335);
            this.hozzaad.Name = "hozzaad";
            this.hozzaad.Size = new System.Drawing.Size(221, 37);
            this.hozzaad.TabIndex = 2;
            this.hozzaad.Text = "Hozzáad";
            this.hozzaad.UseVisualStyleBackColor = true;
            this.hozzaad.Click += new System.EventHandler(this.hozzaad_Click);
            // 
            // nev
            // 
            this.nev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nev.Location = new System.Drawing.Point(12, 9);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(274, 25);
            this.nev.TabIndex = 3;
            this.nev.Text = "Név:";
            // 
            // szuldatum
            // 
            this.szuldatum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.szuldatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szuldatum.Location = new System.Drawing.Point(12, 46);
            this.szuldatum.Name = "szuldatum";
            this.szuldatum.Size = new System.Drawing.Size(295, 25);
            this.szuldatum.TabIndex = 4;
            this.szuldatum.Text = "Születési Dátum:";
            // 
            // nem
            // 
            this.nem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nem.Location = new System.Drawing.Point(12, 87);
            this.nem.Name = "nem";
            this.nem.Size = new System.Drawing.Size(295, 25);
            this.nem.TabIndex = 5;
            this.nem.Text = "Nem:";
            // 
            // hobbi
            // 
            this.hobbi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hobbi.Location = new System.Drawing.Point(12, 131);
            this.hobbi.Name = "hobbi";
            this.hobbi.Size = new System.Drawing.Size(295, 25);
            this.hobbi.TabIndex = 6;
            this.hobbi.Text = "Kedvenc hobbi:";
            // 
            // ujhobbi
            // 
            this.ujhobbi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ujhobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujhobbi.Location = new System.Drawing.Point(12, 342);
            this.ujhobbi.Name = "ujhobbi";
            this.ujhobbi.Size = new System.Drawing.Size(295, 25);
            this.ujhobbi.TabIndex = 7;
            this.ujhobbi.Text = "Új hobbi:";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_nev.Location = new System.Drawing.Point(226, 9);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(380, 30);
            this.textBox_nev.TabIndex = 8;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker.Location = new System.Drawing.Point(226, 45);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(380, 30);
            this.dateTimePicker.TabIndex = 9;
            // 
            // ferfi
            // 
            this.ferfi.AutoSize = true;
            this.ferfi.Checked = true;
            this.ferfi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ferfi.Location = new System.Drawing.Point(80, 85);
            this.ferfi.Name = "ferfi";
            this.ferfi.Size = new System.Drawing.Size(71, 29);
            this.ferfi.TabIndex = 10;
            this.ferfi.TabStop = true;
            this.ferfi.Text = "Férfi";
            this.ferfi.UseVisualStyleBackColor = true;
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.no.Location = new System.Drawing.Point(157, 85);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(58, 29);
            this.no.TabIndex = 11;
            this.no.TabStop = true;
            this.no.Text = "Nő";
            this.no.UseVisualStyleBackColor = true;
            // 
            // textBox_ujhobbi
            // 
            this.textBox_ujhobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_ujhobbi.Location = new System.Drawing.Point(107, 342);
            this.textBox_ujhobbi.Name = "textBox_ujhobbi";
            this.textBox_ujhobbi.Size = new System.Drawing.Size(197, 30);
            this.textBox_ujhobbi.TabIndex = 12;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Items.AddRange(new object[] {
            "Úszás",
            "Horgászat",
            "Futás"});
            this.listBox.Location = new System.Drawing.Point(17, 172);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(287, 129);
            this.listBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 387);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBox_ujhobbi);
            this.Controls.Add(this.no);
            this.Controls.Add(this.ferfi);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.ujhobbi);
            this.Controls.Add(this.hobbi);
            this.Controls.Add(this.nem);
            this.Controls.Add(this.szuldatum);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.hozzaad);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.betoltes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button betoltes;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button mentes;
        private System.Windows.Forms.Button hozzaad;
        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.Label szuldatum;
        private System.Windows.Forms.Label nem;
        private System.Windows.Forms.Label hobbi;
        private System.Windows.Forms.Label ujhobbi;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RadioButton ferfi;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.TextBox textBox_ujhobbi;
        private System.Windows.Forms.ListBox listBox;
    }
}

