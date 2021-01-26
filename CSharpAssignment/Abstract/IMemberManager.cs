using CSharpAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.Abstract
{
   public interface IMemberManager
    {
        //Burada Ekleme,Silme ve Güncelleme fonksiyonlarımızı imzalarını oluşturduk.
        void Save(IMember member);
        void Delete(IMember member);
        void Update(IMember member);
    }
}
