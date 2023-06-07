namespace MASTER_MINDx
{
    partial class ustawienia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ustawienia));
            this.jezyk = new System.Windows.Forms.Label();
            this.polish_language = new System.Windows.Forms.RadioButton();
            this.english_language = new System.Windows.Forms.RadioButton();
            this.german_language = new System.Windows.Forms.RadioButton();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hard_lvl = new System.Windows.Forms.RadioButton();
            this.easy_lvl = new System.Windows.Forms.RadioButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.trudnosc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // jezyk
            // 
            this.jezyk.AutoSize = true;
            this.jezyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jezyk.ForeColor = System.Drawing.Color.White;
            this.jezyk.Location = new System.Drawing.Point(12, 9);
            this.jezyk.Name = "jezyk";
            this.jezyk.Size = new System.Drawing.Size(126, 29);
            this.jezyk.TabIndex = 0;
            this.jezyk.Text = "Language:";
            // 
            // polish_language
            // 
            this.polish_language.AutoSize = true;
            this.polish_language.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.polish_language.Location = new System.Drawing.Point(17, 36);
            this.polish_language.Name = "polish_language";
            this.polish_language.Size = new System.Drawing.Size(17, 16);
            this.polish_language.TabIndex = 1;
            this.polish_language.UseVisualStyleBackColor = true;
            this.polish_language.CheckedChanged += new System.EventHandler(this.polish_language_CheckedChanged);
            // 
            // english_language
            // 
            this.english_language.AutoSize = true;
            this.english_language.Location = new System.Drawing.Point(17, 97);
            this.english_language.Name = "english_language";
            this.english_language.Size = new System.Drawing.Size(17, 16);
            this.english_language.TabIndex = 2;
            this.english_language.UseVisualStyleBackColor = true;
            // 
            // german_language
            // 
            this.german_language.AutoSize = true;
            this.german_language.Location = new System.Drawing.Point(17, 151);
            this.german_language.Name = "german_language";
            this.german_language.Size = new System.Drawing.Size(17, 16);
            this.german_language.TabIndex = 3;
            this.german_language.UseVisualStyleBackColor = true;
            // 
            // confirm_btn
            // 
            this.confirm_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirm_btn.Location = new System.Drawing.Point(12, 265);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(146, 53);
            this.confirm_btn.TabIndex = 7;
            this.confirm_btn.Text = "CONFIRM";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close_btn.Location = new System.Drawing.Point(176, 265);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(151, 53);
            this.close_btn.TabIndex = 8;
            this.close_btn.Text = "CLOSE";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.polish_language);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.english_language);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.german_language);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 199);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MASTER_MINDx.Properties.Resources.Poland_flag_waving_vector_on_transparent_background_PNG_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 53);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::MASTER_MINDx.Properties.Resources.Germany_flag_waving_vector_on_transparent_background_PNG_1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(45, 128);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 50);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MASTER_MINDx.Properties.Resources._174_1743780_united_kingdom_flag_png_transparent_images_uk_flag;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(45, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 39);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hard_lvl);
            this.groupBox2.Controls.Add(this.easy_lvl);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Location = new System.Drawing.Point(176, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 196);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // hard_lvl
            // 
            this.hard_lvl.AutoSize = true;
            this.hard_lvl.Location = new System.Drawing.Point(27, 139);
            this.hard_lvl.Name = "hard_lvl";
            this.hard_lvl.Size = new System.Drawing.Size(17, 16);
            this.hard_lvl.TabIndex = 3;
            this.hard_lvl.TabStop = true;
            this.hard_lvl.UseVisualStyleBackColor = true;
            // 
            // easy_lvl
            // 
            this.easy_lvl.AutoSize = true;
            this.easy_lvl.Location = new System.Drawing.Point(27, 46);
            this.easy_lvl.Name = "easy_lvl";
            this.easy_lvl.Size = new System.Drawing.Size(17, 16);
            this.easy_lvl.TabIndex = 2;
            this.easy_lvl.TabStop = true;
            this.easy_lvl.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::MASTER_MINDx.Properties.Resources.hqdefault;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(68, 106);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(68, 69);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::MASTER_MINDx.Properties.Resources.d2b2229b4b33288eb8bcd05c543e7596;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(68, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 66);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // trudnosc
            // 
            this.trudnosc.AutoSize = true;
            this.trudnosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trudnosc.ForeColor = System.Drawing.Color.White;
            this.trudnosc.Location = new System.Drawing.Point(171, 9);
            this.trudnosc.Name = "trudnosc";
            this.trudnosc.Size = new System.Drawing.Size(108, 29);
            this.trudnosc.TabIndex = 11;
            this.trudnosc.Text = "Difficulty:";
            // 
            // ustawienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(339, 332);
            this.Controls.Add(this.trudnosc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.jezyk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ustawienia";
            this.Text = "Master_Mind_Settings";
            this.Load += new System.EventHandler(this.ustawienia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jezyk;
        private System.Windows.Forms.RadioButton polish_language;
        private System.Windows.Forms.RadioButton english_language;
        private System.Windows.Forms.RadioButton german_language;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label trudnosc;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.RadioButton hard_lvl;
        private System.Windows.Forms.RadioButton easy_lvl;
    }
}