using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PrototypeAbstract
{
    public abstract class CloneablePrototype<T>
    {

        //Shallow copy
        public T Clone()
        {
            return (T) this.MemberwiseClone();
        }

        //Deep copy
        public T DeepCopy()
        {
            string result = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
