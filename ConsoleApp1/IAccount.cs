using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IAccount
    {
        decimal Balance { get; set; }
        decimal CalInterst();

    }
}
