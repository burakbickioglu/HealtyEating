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
    public partial class frmDiyetisyen : Form
    {
        private User _user;
        public frmDiyetisyen(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void frmDiyetisyen_Load(object sender, EventArgs e)
        {
            diyetisyenBilgiDoldur();
            

        }

        public void diyetisyenBilgiDoldur()
        {
            lblDiyetisyenAd.Text = _user.FirstName;
            lblDiyetisyenSoyad.Text = _user.LastName;
            lblDiyetisyenTc.Text = _user.NationalIdentity;
            lblDiyetisyenMail.Text = _user.Email;
            lblDiyetisyenTel.Text = _user.PhoneNumber;
        }
    }
}
