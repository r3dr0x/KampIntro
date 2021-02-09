using InterfacesAbstractDemo.Abstract;
using InterfacesAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAndAbstractDemo.MernisServiceReference;

namespace InterfacesAbstractDemo.Adaptors
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
