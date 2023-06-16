namespace fitness
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.kuladtb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sifretb = new System.Windows.Forms.TextBox();
            this.girisbt = new System.Windows.Forms.Button();
            this.resetbt = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fitness Center";
            // 
            // kuladtb
            // 
            this.kuladtb.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kuladtb.Location = new System.Drawing.Point(290, 120);
            this.kuladtb.Multiline = true;
            this.kuladtb.Name = "kuladtb";
            this.kuladtb.Size = new System.Drawing.Size(305, 47);
            this.kuladtb.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(592, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::fitness.Properties.Resources.png_transparent_password_manager_computer_icons_password_strength_password_safe_chang_miscellaneous_password_strength_password_safe_thumbnail;
            this.pictureBox2.Location = new System.Drawing.Point(592, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // sifretb
            // 
            this.sifretb.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sifretb.Location = new System.Drawing.Point(290, 191);
            this.sifretb.Multiline = true;
            this.sifretb.Name = "sifretb";
            this.sifretb.PasswordChar = '*';
            this.sifretb.Size = new System.Drawing.Size(305, 47);
            this.sifretb.TabIndex = 4;
            // 
            // girisbt
            // 
            this.girisbt.BackColor = System.Drawing.Color.Red;
            this.girisbt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.girisbt.ForeColor = System.Drawing.Color.Black;
            this.girisbt.Location = new System.Drawing.Point(290, 286);
            this.girisbt.Name = "girisbt";
            this.girisbt.Size = new System.Drawing.Size(104, 61);
            this.girisbt.TabIndex = 6;
            this.girisbt.Text = "LOGIN";
            this.girisbt.UseVisualStyleBackColor = false;
            this.girisbt.Click += new System.EventHandler(this.girisbt_Click);
            // 
            // resetbt
            // 
            this.resetbt.BackColor = System.Drawing.Color.Red;
            this.resetbt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetbt.ForeColor = System.Drawing.Color.Black;
            this.resetbt.Location = new System.Drawing.Point(491, 286);
            this.resetbt.Name = "resetbt";
            this.resetbt.Size = new System.Drawing.Size(104, 61);
            this.resetbt.TabIndex = 7;
            this.resetbt.Text = "RESET";
            this.resetbt.UseVisualStyleBackColor = false;
            this.resetbt.Click += new System.EventHandler(this.resetbt_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::fitness.Properties.Resources.fitness_logo__gym_logo__fitness_center_logo_design_template_ee502c447776d7537ac35f02d0efa0ac_screen;
            this.pictureBox3.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(135, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.resetbt);
            this.Controls.Add(this.girisbt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sifretb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kuladtb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox kuladtb;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox sifretb;
        private Button girisbt;
        private Button resetbt;
        private PictureBox pictureBox3;
    }
}