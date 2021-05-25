
namespace UserUI
{
    partial class frmRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRapor));
            this.cmbSiralama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRapor = new System.Windows.Forms.ComboBox();
            this.btnRaporAl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSiralama
            // 
            this.cmbSiralama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSiralama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSiralama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSiralama.FormattingEnabled = true;
            this.cmbSiralama.Items.AddRange(new object[] {
            "Önce hasta bilgisi, sonra diyet",
            "Önce diyet, sonra hasta bilgisi"});
            this.cmbSiralama.Location = new System.Drawing.Point(125, 88);
            this.cmbSiralama.Name = "cmbSiralama";
            this.cmbSiralama.Size = new System.Drawing.Size(377, 33);
            this.cmbSiralama.TabIndex = 0;
            this.cmbSiralama.SelectedIndexChanged += new System.EventHandler(this.cmbSiralama_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sıralama: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rapor Tipi: ";
            // 
            // cmbRapor
            // 
            this.cmbRapor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRapor.FormattingEnabled = true;
            this.cmbRapor.Items.AddRange(new object[] {
            "JSON",
            "HTML"});
            this.cmbRapor.Location = new System.Drawing.Point(125, 144);
            this.cmbRapor.Name = "cmbRapor";
            this.cmbRapor.Size = new System.Drawing.Size(96, 33);
            this.cmbRapor.TabIndex = 2;
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.btnRaporAl.FlatAppearance.BorderSize = 0;
            this.btnRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporAl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRaporAl.ForeColor = System.Drawing.Color.White;
            this.btnRaporAl.Location = new System.Drawing.Point(376, 143);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(126, 33);
            this.btnRaporAl.TabIndex = 4;
            this.btnRaporAl.Text = "Rapor Al";
            this.btnRaporAl.UseVisualStyleBackColor = false;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 60);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.ForeColor = System.Drawing.Color.Transparent;
            this.btnCikis.Location = new System.Drawing.Point(470, 9);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(37, 47);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 3);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rapor Paneli";
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(514, 189);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRaporAl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRapor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSiralama);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmRapor";
            this.Text = "frmRapor";
            this.Load += new System.EventHandler(this.frmRapor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSiralama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRapor;
        private System.Windows.Forms.Button btnRaporAl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label3;
    }
}