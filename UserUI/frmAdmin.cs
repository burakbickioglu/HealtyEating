using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entities.Concrete;

namespace UserUI
{
    public partial class frmAdmin : Form
    {
        User _user;
        public frmAdmin(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            adminBilgiDoldur();
            

        }

        void adminBilgiDoldur()
        {
            lblAdminAd.Text = _user.FirstName;
            lblAdminSoyad.Text = _user.LastName;
            lblAdminMail.Text = _user.Email;
            lblAdminTc.Text = _user.NationalIdentity;
            lblAdminTel.Text = _user.PhoneNumber;
        }
    }
}
