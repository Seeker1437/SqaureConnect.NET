using SquareConnect.Client;

namespace SquareConnectTestApplication
{
    public class UserClient
    {
        public static readonly UserClient Instance = new UserClient();

        public string AccessToken { get; set; }
        private SquareClient _client;

        public UserClient()
        {
            AccessToken = "sq0atp-MliszJ0T1MWnn8cHUTKYow";
            _client = new SquareClient(AccessToken);
        }

        public void Run()
        {
            var merchant = _client.GetBusinessAsync().Result;
            var locations = _client.GetLocationListAsync().Result;
        }
    }
}
