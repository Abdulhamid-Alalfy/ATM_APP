using ATM_APP.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_APP
{
    public class Entry
    {
        static void Main(string[] args)
        {

            Program atmApp = new Program();
            atmApp.InitializeData();
            atmApp.Run();
        }
    }
}
