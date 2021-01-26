using CSharpAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.Abstract
{
    public abstract class MemberManager : IMemberManager
    {
        //Burada Ekleme,Silme ve Güncelleme fonksiyonlarımızı simüle ettik.
        public virtual void Save(IMember member)
        {
            Console.WriteLine("Sisteme kayıt olan oyuncunun Adı : " + member.FirstName + " " + member.LastName);
        }
        public virtual void Delete(IMember member)
        {
            Console.WriteLine("Sistemden silinen oyuncunun Adı: " + member.FirstName + " " + member.LastName);
        }

        public virtual void Update(IMember member)
        {
            Console.WriteLine("Sistemde bilgileri güncellenen oyuncunun Adı: " + member.FirstName + " " + member.LastName);
        }
    }
}
