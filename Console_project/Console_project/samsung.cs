using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_project
{
    public class samsung            
    {
        public string samsungModelName = null;
        public string DisplayModel()
        {
            return samsungModelName;
        }

        public string SetModels(string ModelName)
        {
            samsungModelName = ModelName;
            return ModelName;
        }
    }
}
