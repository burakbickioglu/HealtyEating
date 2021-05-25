using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Concrete;
using Core.Utils.Reporter.Abstract;
using Core.Utils.Reporter.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.Dto_s;

namespace UserUI
{
    public partial class frmRapor : Form
    {
        Patient _hastaDetay;
        PatientToDietDto patientToDietDto = new PatientToDietDto();
        DietToPatientDto dietToPatientDto = new DietToPatientDto();

        PatientManager patientManager = new PatientManager(new EfPatientDal());

        UserManager userManager = new UserManager(new EfUserDal());
        public frmRapor(Patient hastaDetay)
        {
            _hastaDetay = hastaDetay;
            InitializeComponent();
        }
        private void frmRapor_Load(object sender, EventArgs e)
        {

        }

        private void cmbSiralama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btnRaporAl_Click_1(object sender, EventArgs e)
        {

            dietToPatientDto = patientManager.GetDietToPatientDto(_hastaDetay.Id);
            patientToDietDto = patientManager.GetPatientToDietDto(_hastaDetay.Id);

            if (cmbRapor.Text == "JSON")
            {
                JsonReporter jsonReporter = new JsonReporter();


                if (cmbSiralama.Text == "Önce hasta bilgisi, sonra diyet")
                {
                    jsonReporter.CreateJson(patientToDietDto, "userData.json");

                }
                else
                {
                    jsonReporter.CreateJson(dietToPatientDto, "userData.json");
                }
            }

            else if (cmbRapor.Text == "HTML")
            {
                HtmlReporter htmlReporter = new HtmlReporter();
                if (cmbSiralama.Text == "Önce hasta bilgisi, sonra diyet")
                {
                    htmlReporter.build(patientToDietDto, true);

                }
                else
                {
                    htmlReporter.build(patientToDietDto, false);

                }
            }
            
        }
    }
}
