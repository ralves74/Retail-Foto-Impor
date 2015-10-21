namespace ICGRetailFoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkedListBoxFicheiros = new System.Windows.Forms.CheckedListBox();
            this.textBoxDirectorio = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUnckeckedAll = new System.Windows.Forms.Button();
            this.buttonAllCheck = new System.Windows.Forms.Button();
            this.buttonSeleccao = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.redimensionarBT = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // checkedListBoxFicheiros
            // 
            this.checkedListBoxFicheiros.CheckOnClick = true;
            this.checkedListBoxFicheiros.FormattingEnabled = true;
            this.checkedListBoxFicheiros.Location = new System.Drawing.Point(12, 68);
            this.checkedListBoxFicheiros.Name = "checkedListBoxFicheiros";
            this.checkedListBoxFicheiros.ScrollAlwaysVisible = true;
            this.checkedListBoxFicheiros.Size = new System.Drawing.Size(489, 244);
            this.checkedListBoxFicheiros.TabIndex = 4;
            // 
            // textBoxDirectorio
            // 
            this.textBoxDirectorio.Location = new System.Drawing.Point(13, 42);
            this.textBoxDirectorio.Name = "textBoxDirectorio";
            this.textBoxDirectorio.ReadOnly = true;
            this.textBoxDirectorio.Size = new System.Drawing.Size(488, 20);
            this.textBoxDirectorio.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçãoToolStripMenuItem,
            this.acercaToolStripMenuItem,
            this.aPPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(540, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            this.configuraçãoToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoToolStripMenuItem_Click);
            // 
            // acercaToolStripMenuItem
            // 
            this.acercaToolStripMenuItem.Name = "acercaToolStripMenuItem";
            this.acercaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.acercaToolStripMenuItem.Text = "Acerca";
            this.acercaToolStripMenuItem.Click += new System.EventHandler(this.acercaToolStripMenuItem_Click);
            // 
            // aPPToolStripMenuItem
            // 
            this.aPPToolStripMenuItem.Name = "aPPToolStripMenuItem";
            this.aPPToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aPPToolStripMenuItem.Text = "Intro";
            this.aPPToolStripMenuItem.Click += new System.EventHandler(this.aPPToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Directório de Imagens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "(c) Copyright 2015 - Rui Alves";
            // 
            // buttonUnckeckedAll
            // 
            this.buttonUnckeckedAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonUnckeckedAll.Image")));
            this.buttonUnckeckedAll.Location = new System.Drawing.Point(507, 97);
            this.buttonUnckeckedAll.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUnckeckedAll.Name = "buttonUnckeckedAll";
            this.buttonUnckeckedAll.Size = new System.Drawing.Size(25, 26);
            this.buttonUnckeckedAll.TabIndex = 8;
            this.buttonUnckeckedAll.UseVisualStyleBackColor = true;
            this.buttonUnckeckedAll.Click += new System.EventHandler(this.buttonUnckeckedAll_Click);
            // 
            // buttonAllCheck
            // 
            this.buttonAllCheck.Image = ((System.Drawing.Image)(resources.GetObject("buttonAllCheck.Image")));
            this.buttonAllCheck.Location = new System.Drawing.Point(507, 68);
            this.buttonAllCheck.Name = "buttonAllCheck";
            this.buttonAllCheck.Size = new System.Drawing.Size(25, 26);
            this.buttonAllCheck.TabIndex = 7;
            this.buttonAllCheck.UseVisualStyleBackColor = true;
            this.buttonAllCheck.Click += new System.EventHandler(this.buttonAllCheck_Click);
            // 
            // buttonSeleccao
            // 
            this.buttonSeleccao.Image = ((System.Drawing.Image)(resources.GetObject("buttonSeleccao.Image")));
            this.buttonSeleccao.Location = new System.Drawing.Point(507, 42);
            this.buttonSeleccao.Name = "buttonSeleccao";
            this.buttonSeleccao.Size = new System.Drawing.Size(25, 20);
            this.buttonSeleccao.TabIndex = 6;
            this.buttonSeleccao.UseVisualStyleBackColor = true;
            this.buttonSeleccao.Click += new System.EventHandler(this.buttonSeleccao_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.Location = new System.Drawing.Point(395, 317);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 35);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.okButton.Location = new System.Drawing.Point(285, 318);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(104, 32);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Seguinte";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // redimensionarBT
            // 
            this.redimensionarBT.Location = new System.Drawing.Point(508, 127);
            this.redimensionarBT.Name = "redimensionarBT";
            this.redimensionarBT.Size = new System.Drawing.Size(24, 22);
            this.redimensionarBT.TabIndex = 13;
            this.redimensionarBT.Text = "R";
            this.redimensionarBT.UseVisualStyleBackColor = true;
            this.redimensionarBT.Click += new System.EventHandler(this.redimensionarBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 357);
            this.Controls.Add(this.redimensionarBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUnckeckedAll);
            this.Controls.Add(this.buttonAllCheck);
            this.Controls.Add(this.buttonSeleccao);
            this.Controls.Add(this.textBoxDirectorio);
            this.Controls.Add(this.checkedListBoxFicheiros);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Retail Foto Import v.1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckedListBox checkedListBoxFicheiros;
        private System.Windows.Forms.TextBox textBoxDirectorio;
        private System.Windows.Forms.Button buttonSeleccao;
        private System.Windows.Forms.Button buttonAllCheck;
        private System.Windows.Forms.Button buttonUnckeckedAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem aPPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.Button redimensionarBT;
    }
}

