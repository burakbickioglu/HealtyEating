using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace UserUI
{
    public partial class frmGiris : Form
    {
        AccountManager accountManager = new AccountManager(new EfAccountDal());
        UserTypeManager userTypeManager = new UserTypeManager(new EfUserTypeDal());
        UserManager userManager = new UserManager(new EfUserDal());

        public frmGiris()
        {
            InitializeComponent();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.UserName = txtKullaniciAd.Text;
            account.Password = txtSifre.Text;
            account = accountManager.getByUserName(account);

            

            

            if (account!=null &&  account.UserName == txtKullaniciAd.Text && account.Password == txtSifre.Text)
            {
                User user = new User();
                user.Id = account.Id;
                user = userManager.Get(user);
                if (userTypeManager.Get(new UserType { UserTypeId = account.UserTypeId }).UserTypeName == "Admin")
                {
                    frmAdmin frmAdmin = new frmAdmin(user);
                    frmAdmin.ShowDialog();
                }
                else if (userTypeManager.Get(new UserType { UserTypeId = account.UserTypeId }).UserTypeName == "Diyetisyen")
                {
                    frmDiyetisyen frmDiyetisyen = new frmDiyetisyen(user);
                    frmDiyetisyen.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Malesef, giriş yetkiniz bulunmamakta !");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış !");
            }
         
            
        }
    }
}
