using CSharpAssignment.Abstract;
using CSharpAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAssignment.MernisServiceReference;

namespace CSharpAssignment.Adapter
{
    class MernisServiceAdapter : IMemberCheckService
    {
        public bool CheckIfRealPerson(IMember member)
        {
            //Burada ise belirtilen sınıftan bir nesne türetiyoruz.
            // Türetilen nesne sayesinde Mernis sistemine oyuncu bilgilerini gönderiyoruz 
            //Oyuncu bilgilerinde eşleşme sağlanırsa true değer döndürüp gerekli simülasyonların yapılması sağlanacaktır.
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(member.NationalityId), member.FirstName.ToUpper(), member.LastName.ToUpper(), member.DateOfBirth.Year);

        }
    }
}
