using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace UserUI
{
    public partial class frmHastaEkle : Form
    {
        illnessManager illnesManager = new illnessManager(new EfillnesDal());
        DietManager dietManager = new DietManager(new EfDietDal());
        UserManager userManager = new UserManager(new EfUserDal());
        PatientManager patientManager = new PatientManager(new EfPatientDal());

        public frmHastaEkle()
        {
            
            InitializeComponent();
        }

        private void frmHastaEkle_Load(object sender, EventArgs e)
        {
            cmbDiyetDoldur();
            cmbHastalikDoldur();
        }

        void cmbDiyetDoldur()
        {
            List<Diet> _diets = new List<Diet>();
            _diets = dietManager.GetAll();
            foreach (var diet in _diets)
            {
                //MessageBox.Show(diet.DietName);
                cmbDiyet.Items.Add(diet.DietName);
            }
        }

        void cmbHastalikDoldur()
        {
            List<illness> _illness = new List<illness>();
            _illness = illnesManager.GetAll();
            foreach (var illness in _illness)
            {
                cmbHastalık.Items.Add(illness.illnessName);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            User hasta = new User();
            hasta.FirstName = txtAd.Text;
            hasta.LastName = txtSoyad.Text;
            hasta.NationalIdentity = txtTc.Text;
            hasta.Email = txtMail.Text;
            hasta.PhoneNumber = txtTel.Text;
            var result1 = userManager.Add(hasta);

            hasta = userManager.GetAll().SingleOrDefault(p => p.NationalIdentity == txtTc.Text);

            Patient hastaDetay = new Patient();
            hastaDetay.Id = hasta.Id;
            hastaDetay.illnessid =
                illnesManager.GetAll().SingleOrDefault(p => p.illnessName == cmbHastalık.Text).illnessid;
            hastaDetay.DietId = dietManager.GetAll().SingleOrDefault(p => p.DietName == cmbDiyet.Text).DietId;
            hastaDetay.PatientDescription = rchSikayet.Text;
            var result2 = patientManager.Add(hastaDetay);

            if (result1 && result2)
            {
                MessageBox.Show("Hasta eklendi !");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hasta eklenemedi !");
            }



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
    }
}
