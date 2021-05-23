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
    public partial class frmDiyetisyenEkle : Form
    {
        User user = new User();
        Account account = new Account();

        UserManager userManager = new UserManager(new EfUserDal());
        AccountManager accountManager = new AccountManager(new EfAccountDal());

        public frmDiyetisyenEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            user.FirstName = txtAd.Text;
            user.LastName = txtSoyad.Text;
            user.NationalIdentity = txtTc.Text;
            user.Email = txtMail.Text;
            user.PhoneNumber = txtTelefon.Text;
            var result1 = userManager.Add(user);

            user = userManager.GetAll().SingleOrDefault(p=>p.NationalIdentity == txtTc.Text);
            account.Id = user.Id;
            account.UserName = txtKullaniciAd.Text;
            account.Password = txtSifre.Text;
            account.UserTypeId = 2;
            var result2 = accountManager.Add(account);

            if (result1 && result2)
            {
                MessageBox.Show("Diyetisyen başarıyla eklendi !");
                var mfrm = (frmAdmin)Application.OpenForms["frmAdmin"];
                if (mfrm != null)
                    mfrm.diyetisyenGetir();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Diyetisyen eklenemedi !");
            }


        }

        private void frmDiyetisyenEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
