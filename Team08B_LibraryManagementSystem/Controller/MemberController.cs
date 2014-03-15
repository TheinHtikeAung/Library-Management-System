using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Team08B_LibraryManagementSystem
{
    class MemberController
    {

       public bool IsEnglishletters(string input)              //Bool for Name Check
        {
            Regex rex = new Regex("^[a-zA-Z]+$");
            Match ma = rex.Match(input);
            if (!ma.Success)
            {
                return false;
            }
            return true;
        }


       public bool IsNumeric(string str)          // Bool for PhoneNo. Check
       {
           if (str == null || str.Length == 0)
               return false;
           ASCIIEncoding ascii = new ASCIIEncoding();
           byte[] bytestr = ascii.GetBytes(str);

           foreach (byte c in bytestr)
           {
               if (c < 48 || c > 57)
               {
                   return false;
               }
           }
           return true;
       }

    }
}
