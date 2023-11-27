using System.Configuration;

namespace FireDesk.DAO
{
    public class Dashboard
    {
        private readonly IConfiguration _configuration;

        public Dashboard(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}