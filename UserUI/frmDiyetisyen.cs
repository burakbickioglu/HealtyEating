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

namespace UserUI
{
    public partial class frmDiyetisyen : Form
    {
        private User _diyetisyen;
        User hasta = new User();
        Patient hastaDetay = new Patient();
        Diet hastaDiet = new Diet();
        List<Diet> diets = new List<Diet>();
        DietCalendar hastaDietDetay = new DietCalendar();

        UserManager userManager = new UserManager(new EfUserDal());
        PatientManager patientManager = new PatientManager(new EfPatientDal());
        DietManager dietManager = new DietManager(new EfDietDal());
        DietCalendarManager dietCalendarManager = new DietCalendarManager(new EfDietCalendarDal());

        public frmDiyetisyen(User user)
        {
            _diyetisyen = user;
            InitializeComponent();
        }

        private void frmDiyetisyen_Load(object sender, EventArgs e)
        {
            diyetisyenBilgiDoldur();
            diyetTuruDoldur();
        }

        public void diyetTuruDoldur()
        {
            diets = dietManager.GetAll();
            foreach (var diet in diets)
            {
                cmbDiyetTuru.Items.Add(diet.DietName);
            }
        }
        public void diyetisyenBilgiDoldur()
        {
            lblDiyetisyenAd.Text = ": " + _diyetisyen.FirstName;
            lblDiyetisyenSoyad.Text = ": " + _diyetisyen.LastName;
            lblDiyetisyenTc.Text = ": " + _diyetisyen.NationalIdentity;
            lblDiyetisyenMail.Text = ": " + _diyetisyen.Email;
            lblDiyetisyenTel.Text = ": " + _diyetisyen.PhoneNumber;
        }

        public void hastaBilgiDoldur()
        {
            lblHastaAd.Text = ": " + hasta.FirstName;
            lblHastaSoyad.Text = ": " + hasta.LastName;
            lblHastaMail.Text = ": " + hasta.Email;
            lblHastaTc.Text = ": " + hasta.NationalIdentity;
            lblHastaTel.Text = ": " + hasta.PhoneNumber;

            int hastaId = userManager.GetAll().SingleOrDefault(p => p.NationalIdentity == hasta.NationalIdentity).Id;

            string bosluk = "\n-----------------------------------------------------------------------------------\n";

            hastaDetay = patientManager.Get(new Patient { Id = hastaId });
            rchHastaSikayet.Text = hastaDetay.PatientDescription;
            cmbDiyetTuru.Text = dietManager.Get(new Diet { DietId = hastaDetay.DietId }).DietName;
            hastaDietDetay = dietCalendarManager.Get(new DietCalendar { DietId = hastaDetay.DietId });
            rchDiyet.Text = hastaDietDetay.Pazartesi + bosluk + hastaDietDetay.Sali + bosluk + hastaDietDetay.Carsamba +
                            bosluk + hastaDietDetay.Persembe + bosluk + hastaDietDetay.Cuma + bosluk +
                            hastaDietDetay.Cumartesi + bosluk + hastaDietDetay.Pazar;

        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            frmHastaEkle frmHastaEkle = new frmHastaEkle();
            frmHastaEkle.ShowDialog();
        }

        private void btnHastaAra_Click(object sender, EventArgs e)
        {


            hasta.NationalIdentity = txtHastaTc.Text;
            hasta = userManager.GetAll().SingleOrDefault(p => p.NationalIdentity == hasta.NationalIdentity);
            if (hasta != null)
            {
                hastaBilgiDoldur();
            }

            else
            {
                MessageBox.Show("Hasta bulunamadı !");
            }
        }

        private void btnDiyetGuncelle_Click(object sender, EventArgs e)
        {
            hastaDetay.DietId = dietManager.GetAll().SingleOrDefault(p => p.DietName == cmbDiyetTuru.Text).DietId;
            var result1 = patientManager.Update(hastaDetay);
            if (result1)
            {
                MessageBox.Show("Diyet güncellendi");
                hastaBilgiDoldur();
            }
            else
            {
                MessageBox.Show("Diyet güncellenemedi !");
            }
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            frmRapor frmRapor = new frmRapor(hastaDetay);
            frmRapor.ShowDialog();
        }

        

        private void button1_Click(object sender, EventArgs e)
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
