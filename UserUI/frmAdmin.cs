using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.Dto_s;

namespace UserUI
{
    public partial class frmAdmin : Form
    {
        User _admin;
        List<DietitianDto> _dietitians;

        UserManager usermanager = new UserManager(new EfUserDal());
        public frmAdmin(User admin)
        {
            _admin = admin;
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            adminBilgiDoldur();
            diyetisyenGetir();
        }

        public void diyetisyenGetir()
        {
            cmbDiyetisyen.Items.Clear();
            _dietitians = usermanager.GetDietitianDetail();
            foreach (var dietitians in _dietitians)
            {
                cmbDiyetisyen.Items.Add(dietitians.FirstName + " " + dietitians.LastName);
            }

            cmbDiyetisyen.Text = "";
        }

        public void adminBilgiDoldur()
        {
            lblAdminAd.Text = ": "+_admin.FirstName;
            lblAdminSoyad.Text = ": " + _admin.LastName;
            lblAdminMail.Text = ": " + _admin.Email;
            lblAdminTc.Text = ": " + _admin.NationalIdentity;
            lblAdminTel.Text = ": " + _admin.PhoneNumber;
        }

        private void cmbDiyetisyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            DietitianDto selectedDietitian;
            selectedDietitian = _dietitians.SingleOrDefault(p => p.FirstName + " " + p.LastName == cmbDiyetisyen.Text);
            lblDiyetisyenAd.Text = ": " + selectedDietitian.FirstName;
            lblDiyetisyenSoyad.Text = ": " + selectedDietitian.LastName;
            lblDiyetisyenTc.Text = ": " + selectedDietitian.NationalIdentity;
            lblDiyetisyenMail.Text = ": " + selectedDietitian.Email;
            lblDiyetisyenTel.Text = ": " + selectedDietitian.PhoneNumber;
        }

        private void btnDiyetisyenEkle_Click(object sender, EventArgs e)
        {
            frmDiyetisyenEkle frmDiyetisyenEkle = new frmDiyetisyenEkle();
            frmDiyetisyenEkle.ShowDialog();
            lblTemizle();
        }

        private void lblTemizle()
        {
            lblDiyetisyenAd.ResetText();
            lblDiyetisyenSoyad.ResetText();
            lblDiyetisyenMail.ResetText();
            lblDiyetisyenTc.ResetText();
            lblDiyetisyenTel.ResetText();
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int Mouse_X;
        private int Mouse_Y;
        private int Move;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1; 
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1) { this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y); }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
