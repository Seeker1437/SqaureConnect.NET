using System.Threading.Tasks;
using SquareConnect.Rest;
using SquareConnect.V1.Types;

namespace SquareConnect.Client
{
    public partial class SquareClient
    {
        public async Task<Merchant> GetBusinessAsync()
        {
            RestRequest restRequest = _client.Create("v1/me");

            RestResponse<Merchant> restResponse = await restRequest.ExecuteGet<Merchant>();

            Merchant merchant = await restResponse.GetDataObject().ConfigureAwait(false);

            return merchant;
        }

        public async Task<Merchant[]> GetLocationListAsync()
        {
            RestRequest restRequest = _client.Create("v1/me/locations");

            RestResponse<Merchant[]> restResponse = await restRequest.ExecuteGet<Merchant[]>();

            Merchant[] merchants = await restResponse.GetDataObject().ConfigureAwait(false);

            return merchants;
        }
    }
}
