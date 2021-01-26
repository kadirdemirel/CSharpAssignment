using CSharpAssignment.Abstract;
using CSharpAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.Concrete
{
    class SystemMemberManager:MemberManager
    {
        //Burada ise oyuncu kayıt işlemi vardır.
        //Ancak burada Kontrol işlemi yapıyoruz.
        //Yapılan kontrol doğruysa kayıt yapılır.
        private IMemberCheckService _memberCheckService;
        public SystemMemberManager(IMemberCheckService memberCheckService)
        {
            _memberCheckService = memberCheckService;
        }
        public override void Save(IMember member)
        {
            if(_memberCheckService.CheckIfRealPerson(member))
            {
                base.Save(member);
            }
            else
            {
                throw new Exception("Böyle bir oyuncu bulunamadı,kayıt etme işlemi başarısız.");
            }
         
        }
        //Burada da silme işlemini yapıyoruz.
        public override void Delete(IMember member)
        {
            if (_memberCheckService.CheckIfRealPerson(member))
            {
                base.Delete(member);
            }
            else
            {
                throw new Exception("Böyle bir oyuncu bulunamadı,silme işlemi başarısız.");
            }
        
        }
        //Burada ise güncelleme işlemini yapıyoruz.
        public override void Update(IMember member)
        {
            if (_memberCheckService.CheckIfRealPerson(member))
            {
                base.Update(member);
            }
            else
            {
                throw new Exception("Böyle bir oyuncu bulunamadı,güncelleme işlemi başarısız.");
            }
           
        }



    }
}
