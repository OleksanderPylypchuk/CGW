using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyInitialization
{
    public class LazyClass
    {
        private ExpenciveClass _expenciveClass;
        public ExpenciveClass ExpenciveClass {  get
            {
                if (_expenciveClass == null)
                {
                    _expenciveClass = new ExpenciveClass();
                }
                return _expenciveClass;
            }
        }
    }
}
