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
            string patientInfo = "Hasta Adı: " + patientToDietDto.FirstName + "<br>Hasta Soyadı: " +
                                 patientToDietDto.LastName + "<br>TC: " + patientToDietDto.NationalIdentity +
                                 "<br>E mail: " + patientToDietDto.Email + "<br>Telefon: " + patientToDietDto.PhoneNumber +
                                 "<br>Şikayet: " + patientToDietDto.PatientDescription + "<br><br><br><br><br>";

            string dietInfo = "Diyet adı: " + patientToDietDto.DietName + "<br>Pazartesi: " + patientToDietDto.Pazartesi +
                              "<br>Salı: " + patientToDietDto.Sali + "<br>Çarşamba: " + patientToDietDto.Carsamba +
                              "<br>Perşembe: " + patientToDietDto.Persembe + "<br>Cuma: " + patientToDietDto.Cuma +
                              "<br>Cumartesi: " + patientToDietDto.Cumartesi + "<br>Pazar: " + patientToDietDto.Pazar + "<br><br><br><br><br>";

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
                "<html> <body><BIG>" + metin + "</ BIG ></body></html>";

            File.WriteAllText("userData.html", htmlstring);
        }

    }
}
