using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy.Services.Interfaces;

namespace Proxy.Service
{
    public class Proxy : IService
    {
        private Service _service;
        public Proxy(Service service)
        {
            _service = service;
        }
        public void Action(object Data)
        {
            if (Data != null)
            {
                _service.Action(Data);
                return;
            }
            throw new NotImplementedException();
        }
    }
}
