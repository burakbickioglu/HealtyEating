using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Core.Utils.Reporter.Abstract;
using Entities.Dto_s;

namespace Core.Utils.Reporter.Concrete
{
    public class HtmlReporter : IReporter
    {
        public void build(PatientToDietDto patientToDietDto , bool select) 
        {
            string patientInfo = "<b>HASTA BİLGİLERİ</b><br><br>Hasta Adı: " + patientToDietDto.FirstName + "<br>Hasta Soyadı: " +
                                 patientToDietDto.LastName + "<br>TC: " + patientToDietDto.NationalIdentity +
                                 "<br>E mail: " + patientToDietDto.Email + "<br>Telefon: " + patientToDietDto.PhoneNumber +
                                 "<br>Şikayet: " + patientToDietDto.PatientDescription + "<br><br><br><br><br>";

            string dietInfo = "<b>DİYET BİLGİLERİ</b><br><br>Diyet adı: " + patientToDietDto.DietName + "<br><br>" + patientToDietDto.Pazartesi +
                              "<br><br>" + patientToDietDto.Sali + "<br><br>" + patientToDietDto.Carsamba +
                              "<br><br>" + patientToDietDto.Persembe + "<br><br>" + patientToDietDto.Cuma +
                              "<br><br>" + patientToDietDto.Cumartesi + "<br><br>" + patientToDietDto.Pazar + "<br><br><br><br><br>";

            if (select) // select true ise önce hasta bilgisi, sonra diyet bilgisi görüntülenecek
            {
                string metin = patientInfo + dietInfo;
                create(metin);
            }
            else // select false ise önce diyet bilgisi, sonra hasta bilgisi görüntülenecek
            {
                string metin = dietInfo + patientInfo;
                create(metin);
            }

        }
        

        public void create(string metin)
        {

            string htmlstring =
                "<html> <body style='background-color:#393e46; color: #f7fd04;'><BIG>" + metin + "</ BIG ></body></html>";

            File.WriteAllText("userData.html", htmlstring);
        }

    }
}
