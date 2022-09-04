using CoreLayer.AbstractService;
using CoreLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ConcreteService
{
    public class MernisControlService : IMernisControlService
    {
        public async Task<bool> IsTheCustomerRegisteredInMernis(MernisDto mernisDto)
        {
            var client = new MerniceService.KPSPublicSoapClient(MerniceService.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var response = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(mernisDto.TCKNo), mernisDto.Name, mernisDto.Surname, mernisDto.BirthYear);
            var result = response.Body.TCKimlikNoDogrulaResult;
            return result;
        }
    }
}
