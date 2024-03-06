using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_project
{
    public class oppo
    {
        public string oppoModelName = null;
        public string DisplayModel()
        {
            return oppoModelName;
        }

        public string SetModels(string ModelName)
        {
            oppoModelName = ModelName;
            return ModelName;
        }
    }

}
