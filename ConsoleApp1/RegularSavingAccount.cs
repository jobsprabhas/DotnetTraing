using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.IAccount

namespace ConsoleApp1
{
    class RegularSavingAccount:IAccount
    {
        public decimal Balance { get; set; } = 1000;

         public decimal CalInterst()
        {
            decimal Interst = (Convert.ToInt32(400)* 4) / 100;
         //   if (Balance < 100) Interst -= (Balance * 2) / 100;
          //  if (Balance < 500) Interst += (Balance * 4) / 100;
            return Interst;
            //throw new NotImplementedException();
        }

        //internal void Balance()
        //{
        //  //  throw new NotImplementedException();
        //}
    }
}
