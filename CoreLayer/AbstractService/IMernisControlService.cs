using CoreLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.AbstractService
{
    public interface IMernisControlService
    {
        public Task<bool> IsTheCustomerRegisteredInMernis(MernisDto mernisDto);
    }
}
