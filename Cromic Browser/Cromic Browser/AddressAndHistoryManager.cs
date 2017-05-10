using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cromic_Browser
{
    class AddressAndHistoryManager
    {
        public int forward;
        public int backward;
        public string[] Address;
        public int addressSavePoint;
        public Boolean IncoginitoModeStatus;

        public AddressAndHistoryManager()
        {
            forward = 0;
            backward = 0;
            Address = new string[1000];
            addressSavePoint = 0;
            IncoginitoModeStatus = false;
            
        }
        //-----------------------
    public void OnForwardNavigation(String currentAddOfWebsite)
        {
            backward++;    //it means it can Go backward
         if(IncoginitoModeStatus==false)
            {     for (int a = 1; a <= Address.Length-1; a++ )
                    {   if (Address[a] == null || Address[a] == "")
                              {
                               Address[a] = currentAddOfWebsite;
                               addressSavePoint = a;
                               break;
                              }
                     }
            }
        }

        //-------------
    }
}
