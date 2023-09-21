namespace pumpeks
{
    partial class menu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.button2 = new Guna.UI2.WinForms.Guna2Button();
            this.boyut = new Guna.UI2.WinForms.Guna2TextBox();
            this.birim = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pompala = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ustuneEkle = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All Files|*.*";
            this.openFileDialog1.Title = "Pick up a file";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(224, 57);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(129, 42);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "pumpeks";
            // 
            // button2
            // 
            this.button2.Animated = true;
            this.button2.BorderRadius = 15;
            this.button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(199, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Choose a File";
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // boyut
            // 
            this.boyut.Animated = true;
            this.boyut.BorderRadius = 15;
            this.boyut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.boyut.DefaultText = "";
            this.boyut.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.boyut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.boyut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.boyut.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.boyut.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boyut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boyut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.boyut.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boyut.Location = new System.Drawing.Point(43, 131);
            this.boyut.Name = "boyut";
            this.boyut.PasswordChar = '\0';
            this.boyut.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.boyut.PlaceholderText = "Size";
            this.boyut.SelectedText = "";
            this.boyut.Size = new System.Drawing.Size(150, 36);
            this.boyut.TabIndex = 8;
            this.boyut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // birim
            // 
            this.birim.BackColor = System.Drawing.Color.Transparent;
            this.birim.BorderRadius = 15;
            this.birim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.birim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birim.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.birim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.birim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.birim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.birim.ItemHeight = 30;
            this.birim.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB"});
            this.birim.Location = new System.Drawing.Point(375, 131);
            this.birim.Name = "birim";
            this.birim.Size = new System.Drawing.Size(140, 36);
            this.birim.StartIndex = 0;
            this.birim.TabIndex = 9;
            this.birim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pompala
            // 
            this.pompala.Animated = true;
            this.pompala.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pompala.BorderRadius = 10;
            this.pompala.BorderThickness = 1;
            this.pompala.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pompala.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pompala.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pompala.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pompala.FillColor = System.Drawing.Color.Transparent;
            this.pompala.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pompala.ForeColor = System.Drawing.Color.White;
            this.pompala.Location = new System.Drawing.Point(177, 203);
            this.pompala.Name = "pompala";
            this.pompala.Size = new System.Drawing.Size(219, 38);
            this.pompala.TabIndex = 10;
            this.pompala.Text = "Pump";
            this.pompala.Click += new System.EventHandler(this.pompalaStart);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(532, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 13;
            // 
            // ustuneEkle
            // 
            this.ustuneEkle.Animated = true;
            this.ustuneEkle.AutoSize = true;
            this.ustuneEkle.Checked = true;
            this.ustuneEkle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ustuneEkle.CheckedState.BorderRadius = 0;
            this.ustuneEkle.CheckedState.BorderThickness = 0;
            this.ustuneEkle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ustuneEkle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ustuneEkle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ustuneEkle.ForeColor = System.Drawing.Color.White;
            this.ustuneEkle.Location = new System.Drawing.Point(224, 256);
            this.ustuneEkle.Name = "ustuneEkle";
            this.ustuneEkle.Size = new System.Drawing.Size(122, 23);
            this.ustuneEkle.TabIndex = 14;
            this.ustuneEkle.Text = "Add to File Size";
            this.ustuneEkle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ustuneEkle.UncheckedState.BorderRadius = 0;
            this.ustuneEkle.UncheckedState.BorderThickness = 0;
            this.ustuneEkle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ustuneEkle.CheckedChanged += new System.EventHandler(this.ustuneEkle_CheckedChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 14;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.DimGray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::pumpeks.Properties.Resources.github_PNG40_1417037603;
            this.guna2Button1.Location = new System.Drawing.Point(12, 289);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(109, 30);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "arshx86";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(589, 331);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.ustuneEkle);
            this.Controls.Add(this.birim);
            this.Controls.Add(this.boyut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.pompala);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button button2;
        private Guna.UI2.WinForms.Guna2TextBox boyut;
        private Guna.UI2.WinForms.Guna2ComboBox birim;
        private Guna.UI2.WinForms.Guna2Button pompala;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2CheckBox ustuneEkle;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

