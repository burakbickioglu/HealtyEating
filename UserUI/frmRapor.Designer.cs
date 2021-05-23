
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
            this.cmbSiralama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRapor = new System.Windows.Forms.ComboBox();
            this.btnRaporAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbSiralama
            // 
            this.cmbSiralama.FormattingEnabled = true;
            this.cmbSiralama.Items.AddRange(new object[] {
            "Önce hasta bilgisi, sonra diyet",
            "Önce diyet, sonra hasta bilgisi"});
            this.cmbSiralama.Location = new System.Drawing.Point(125, 9);
            this.cmbSiralama.Name = "cmbSiralama";
            this.cmbSiralama.Size = new System.Drawing.Size(240, 39);
            this.cmbSiralama.TabIndex = 0;
            this.cmbSiralama.SelectedIndexChanged += new System.EventHandler(this.cmbSiralama_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sıralama: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rapor Tipi: ";
            // 
            // cmbRapor
            // 
            this.cmbRapor.FormattingEnabled = true;
            this.cmbRapor.Items.AddRange(new object[] {
            "JSON",
            "HTML"});
            this.cmbRapor.Location = new System.Drawing.Point(125, 65);
            this.cmbRapor.Name = "cmbRapor";
            this.cmbRapor.Size = new System.Drawing.Size(96, 39);
            this.cmbRapor.TabIndex = 2;
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.Location = new System.Drawing.Point(239, 65);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(126, 33);
            this.btnRaporAl.TabIndex = 4;
            this.btnRaporAl.Text = "Rapor Al";
            this.btnRaporAl.UseVisualStyleBackColor = true;
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 112);
            this.Controls.Add(this.btnRaporAl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRapor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSiralama);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmRapor";
            this.Text = "frmRapor";
            this.Load += new System.EventHandler(this.frmRapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSiralama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRapor;
        private System.Windows.Forms.Button btnRaporAl;
    }
}