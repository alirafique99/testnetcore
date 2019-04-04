using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testnetcore.models
{
    public class Values
    {
        private string [] values = new string[] { "value1", "value2" };
        public string[] getValues() {
            return values;
        }

        //public string[] getValue(int id)
        //{
        //    return values[id];
        //}

    }
}
