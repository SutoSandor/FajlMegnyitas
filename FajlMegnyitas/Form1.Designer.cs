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
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.textbox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.AccessibleName = "Open";
            this.open.Location = new System.Drawing.Point(40, 12);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(90, 37);
            this.open.TabIndex = 0;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.AccessibleName = "Save";
            this.save.Location = new System.Drawing.Point(212, 12);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(90, 37);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // textbox
            // 
            this.textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox.Location = new System.Drawing.Point(12, 55);
            this.textbox.Multiline = true;
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(331, 207);
            this.textbox.TabIndex = 2;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 274);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.save);
            this.Controls.Add(this.open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

