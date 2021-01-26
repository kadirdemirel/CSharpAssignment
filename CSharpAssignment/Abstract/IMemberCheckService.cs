using CSharpAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.Abstract
{
    public interface IMemberCheckService
    {
        //Burada ise bool veri tipinde bir imza oluşturduk.
       
        bool CheckIfRealPerson(IMember member);
    }
}
