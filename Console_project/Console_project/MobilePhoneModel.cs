using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_project
{
    public class MobilePhoneModel :oppo 
    {
        public string WhatIsMyPhoneModel(oppo oppoObj, samsung samsungObj)
        {
            string oppoModel = oppoObj.DisplayModel();
            string samsungModel = samsungObj.DisplayModel();

            return oppoModel + samsungModel;
        }
    }

}
