using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using it_company.ItCompanyServiceClient;

namespace it_company
{
    public static class ClientWcf
    {
        public static void Connect()
        {
            var clientWcf = new ServiceItCompanyClient();
            clientWcf.DoWork();
        }
    }
}