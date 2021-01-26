using CSharpAssignment.Abstract;
using CSharpAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.Adapter
{
    class MemberCheckManager : IMemberCheckService
    {
        //Bool tipinde olma sebebi ise gerçek ise 1 yani true döndürüp kayıt yapması için.
        //Ancak False yani 0 dönerse Mernis ile eşleşmezse hata verecektir.
        public bool CheckIfRealPerson(IMember member)
        {
            return true;
        }
    }
}
