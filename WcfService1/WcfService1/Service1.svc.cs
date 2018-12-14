using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    
    public class Service1 : IService1
    {
        public int getwether(string a)
        {
            if(a=="bangalore")
            {
                return (20);
            }
            if(a=="kerala")
            {
                return (30);
            }
            if(a=="andra pradesh")
            {
                return (28);
            }
            else
            {
                return (0);
            }

        }

       
    }
}
