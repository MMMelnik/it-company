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