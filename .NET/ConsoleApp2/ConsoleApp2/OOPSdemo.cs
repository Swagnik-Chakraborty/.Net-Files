using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class OOPSdemo
    {
          int CustId;
        string CustName;
        string Address;

        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return CustId;
                }
                else if (index == 1)
                {
                    return CustName;
                }
                else if (index == 2)
                {
                    return Address;
                }
                else
                    return null;
            }
            set
            {
                if (index == 0)
                {
                    CustId = Convert.ToInt32(value);

                }
                else if (index == 1)
                {
                   
                    CustName = value.ToString();
                }
                else if (index == 2)
                {
                   
                    Address = value.ToString();
                }
            }
        }





       





    }
}
