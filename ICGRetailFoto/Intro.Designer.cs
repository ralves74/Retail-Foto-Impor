namespace ICGRetailFoto
{
    partial class Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.serialTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.licenseTB = new System.Windows.Forms.TextBox();
            this.licenciarBT = new System.Windows.Forms.Button();
            this.entrarBT = new System.Windows.Forms.Button();
            this.aplicenciadaLB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialTB
            // 
            this.serialTB.Location = new System.Drawing.Point(119, 273);
            this.serialTB.Name = "serialTB";
            this.serialTB.ReadOnly = true;
            this.serialTB.Size = new System.Drawing.Size(259, 20);
            this.serialTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "License Key  :";
            // 
            // licenseTB
            // 
            this.licenseTB.Location = new System.Drawing.Point(119, 303);
            this.licenseTB.Name = "licenseTB";
            this.licenseTB.Size = new System.Drawing.Size(259, 20);
            this.licenseTB.TabIndex = 3;
            // 
            // licenciarBT
            // 
            this.licenciarBT.Location = new System.Drawing.Point(380, 273);
            this.licenciarBT.Name = "licenciarBT";
            this.licenciarBT.Size = new System.Drawing.Size(65, 50);
            this.licenciarBT.TabIndex = 4;
            this.licenciarBT.Text = "Licenciar";
            this.licenciarBT.UseVisualStyleBackColor = true;
            this.licenciarBT.Click += new System.EventHandler(this.licenciarBT_Click);
            // 
            // entrarBT
            // 
            this.entrarBT.Location = new System.Drawing.Point(29, 329);
            this.entrarBT.Name = "entrarBT";
            this.entrarBT.Size = new System.Drawing.Size(416, 33);
            this.entrarBT.TabIndex = 5;
            this.entrarBT.Text = "Entrar na Aplicação";
            this.entrarBT.UseVisualStyleBackColor = true;
            this.entrarBT.Click += new System.EventHandler(this.entrarBT_Click);
            // 
            // aplicenciadaLB
            // 
            this.aplicenciadaLB.AutoSize = true;
            this.aplicenciadaLB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aplicenciadaLB.Location = new System.Drawing.Point(115, 246);
            this.aplicenciadaLB.Name = "aplicenciadaLB";
            this.aplicenciadaLB.Size = new System.Drawing.Size(227, 24);
            this.aplicenciadaLB.TabIndex = 6;
            this.aplicenciadaLB.Text = "Aplicação Licenciada";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "RETAIL FOTO IMPORT V.1.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "(c) Copyright 2015 - Rui Alves";
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 383);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aplicenciadaLB);
            this.Controls.Add(this.entrarBT);
            this.Controls.Add(this.licenciarBT);
            this.Controls.Add(this.licenseTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serialTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Intro";
            this.Text = "Intro";
            this.Load += new System.EventHandler(this.Intro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serialTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox licenseTB;
        private System.Windows.Forms.Button licenciarBT;
        private System.Windows.Forms.Button entrarBT;
        private System.Windows.Forms.Label aplicenciadaLB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}