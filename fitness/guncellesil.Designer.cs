namespace fitness
{
    partial class guncellesil
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
            this.geribtn = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.zamancb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ucrettb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cinsiyetcb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adsoyadtb = new System.Windows.Forms.TextBox();
            this.teltb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yastb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uyedvg = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.uyedvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // geribtn
            // 
            this.geribtn.BackColor = System.Drawing.Color.Red;
            this.geribtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.geribtn.ForeColor = System.Drawing.Color.Black;
            this.geribtn.Location = new System.Drawing.Point(341, 557);
            this.geribtn.Name = "geribtn";
            this.geribtn.Size = new System.Drawing.Size(204, 41);
            this.geribtn.TabIndex = 40;
            this.geribtn.Text = "GERİ";
            this.geribtn.UseVisualStyleBackColor = false;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Red;
            this.reset.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset.ForeColor = System.Drawing.Color.Black;
            this.reset.Location = new System.Drawing.Point(462, 490);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(104, 61);
            this.reset.TabIndex = 38;
            this.reset.Text = "RESET";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // guncellebtn
            // 
            this.guncellebtn.BackColor = System.Drawing.Color.Red;
            this.guncellebtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guncellebtn.ForeColor = System.Drawing.Color.Black;
            this.guncellebtn.Location = new System.Drawing.Point(311, 490);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(145, 61);
            this.guncellebtn.TabIndex = 37;
            this.guncellebtn.Text = "GÜNCELLE";
            this.guncellebtn.UseVisualStyleBackColor = false;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // zamancb
            // 
            this.zamancb.FormattingEnabled = true;
            this.zamancb.Items.AddRange(new object[] {
            "06:00-08:00",
            "08:00-10:00",
            "18:00-20:00",
            "20:00-22:00"});
            this.zamancb.Location = new System.Drawing.Point(30, 520);
            this.zamancb.Name = "zamancb";
            this.zamancb.Size = new System.Drawing.Size(168, 23);
            this.zamancb.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(30, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 22);
            this.label8.TabIndex = 35;
            this.label8.Text = "ZAMANLAMA";
            // 
            // ucrettb
            // 
            this.ucrettb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucrettb.Location = new System.Drawing.Point(21, 443);
            this.ucrettb.Multiline = true;
            this.ucrettb.Name = "ucrettb";
            this.ucrettb.Size = new System.Drawing.Size(168, 37);
            this.ucrettb.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(21, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "AYLIK ÜCRET";
            // 
            // cinsiyetcb
            // 
            this.cinsiyetcb.FormattingEnabled = true;
            this.cinsiyetcb.Items.AddRange(new object[] {
            "BAY",
            "BAYAN"});
            this.cinsiyetcb.Location = new System.Drawing.Point(21, 377);
            this.cinsiyetcb.Name = "cinsiyetcb";
            this.cinsiyetcb.Size = new System.Drawing.Size(168, 23);
            this.cinsiyetcb.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(21, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "CİNSİYET";
            // 
            // adsoyadtb
            // 
            this.adsoyadtb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adsoyadtb.Location = new System.Drawing.Point(21, 131);
            this.adsoyadtb.Multiline = true;
            this.adsoyadtb.Name = "adsoyadtb";
            this.adsoyadtb.Size = new System.Drawing.Size(168, 37);
            this.adsoyadtb.TabIndex = 30;
            // 
            // teltb
            // 
            this.teltb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teltb.Location = new System.Drawing.Point(21, 214);
            this.teltb.Multiline = true;
            this.teltb.Name = "teltb";
            this.teltb.Size = new System.Drawing.Size(168, 37);
            this.teltb.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(21, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "YAŞ";
            // 
            // yastb
            // 
            this.yastb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yastb.Location = new System.Drawing.Point(21, 298);
            this.yastb.Multiline = true;
            this.yastb.Name = "yastb";
            this.yastb.Size = new System.Drawing.Size(168, 37);
            this.yastb.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(21, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "TELEFON NUMARASI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(21, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "AD SOYAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(268, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "ÜYE GÜNCELLE VE SİL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(268, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fitness Center";
            // 
            // uyedvg
            // 
            this.uyedvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uyedvg.Location = new System.Drawing.Point(229, 146);
            this.uyedvg.Name = "uyedvg";
            this.uyedvg.RowTemplate.Height = 25;
            this.uyedvg.Size = new System.Drawing.Size(559, 334);
            this.uyedvg.TabIndex = 41;
            this.uyedvg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uyedvg_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(394, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 22);
            this.label9.TabIndex = 42;
            this.label9.Text = "SİLİNECEK  ÜYEYE TIKLAYIN";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::fitness.Properties.Resources.fitness_logo__gym_logo__fitness_center_logo_design_template_ee502c447776d7537ac35f02d0efa0ac_screen;
            this.pictureBox3.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(135, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // guncellesil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uyedvg);
            this.Controls.Add(this.geribtn);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.guncellebtn);
            this.Controls.Add(this.zamancb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ucrettb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cinsiyetcb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adsoyadtb);
            this.Controls.Add(this.teltb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yastb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "guncellesil";
            this.Text = "guncellesil";
            this.Load += new System.EventHandler(this.guncellesil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uyedvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button geribtn;
        private Button reset;
        private Button guncellebtn;
        private ComboBox zamancb;
        private Label label8;
        private TextBox ucrettb;
        private Label label7;
        private ComboBox cinsiyetcb;
        private Label label6;
        private TextBox adsoyadtb;
        private TextBox teltb;
        private Label label5;
        private TextBox yastb;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView uyedvg;
        private Label label9;
        private PictureBox pictureBox3;
    }
}