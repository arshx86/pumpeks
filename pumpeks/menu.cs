using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pumpeks
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        // Make window draggable
        protected override void WndProc(ref Message m)
        {

            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);

        }

        private bool _fileselected = false;

        private void button2_Click_1(object sender, EventArgs e)
        {

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {

                string fileName = openFileDialog1.SafeFileName;
                button2.Text = fileName;
                _fileselected = true;
            }

        }

        private void pompalaStart(object sender, EventArgs e)
        {
            if (!_fileselected)
            {
                MessageBox.Show("You must pick up a file.");
                return;
            }

            int Boyut;
            string Birim;

            if (!int.TryParse(boyut.Text, out Boyut))
            {
                MessageBox.Show("Must entered number to 'Size' field.", "?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hesapla
            Birim = birim.Text;
            switch (Birim)
            {
                case "KB":
                    Boyut = Boyut * 1024;
                    break;
                case "MB":
                    Boyut = Boyut * 1024 * 1024;
                    break;
                case "GB":
                    Boyut = Boyut * 1024 * 1024 * 1024;
                    break;
                default:
                    MessageBox.Show("Select a unit (mb/kb/gb)", "?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }

            DialogResult onayla = MessageBox.Show($"{(ustuneEkle.Checked ? "Expend" : "Set")} file size as {boyut.Text} {birim.Text} ?", "Validate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onayla == DialogResult.No)
            {
                return;
            }


            #region Dosyaya yaz

            var file = File.OpenWrite(openFileDialog1.FileName);
            var siz = file.Seek(0, SeekOrigin.End);

            // Üstüne ekle açıksa
            if (ustuneEkle.Checked)
            {
                byte[] bytes = new byte[Boyut];
                file.Write(bytes, 0, bytes.Length);
            }
            // Belirtilen boyut kadar olacak
            else
            {
                file.SetLength(Boyut);
            }


            file.Close();

            #endregion

            MessageBox.Show("Pumped! follow me on github.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ustuneEkle_CheckedChanged(object sender, EventArgs e)
        {
            bool isc = ustuneEkle.Checked;
            if (isc)
            {
                MessageBox.Show("Expend turned on. Selected size will be added to file's size.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Expend turned off. Select size will be set as exact target file size.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "https://github.com/arshx86");
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
