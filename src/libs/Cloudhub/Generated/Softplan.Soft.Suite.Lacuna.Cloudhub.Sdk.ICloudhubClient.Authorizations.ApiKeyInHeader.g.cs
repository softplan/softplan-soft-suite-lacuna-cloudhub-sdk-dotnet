
#nullable enable

namespace Softplan.Soft.Suite.Lacuna.Cloudhub.Sdk
{
    public partial interface ICloudhubClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingApiKeyInHeader(
            string apiKey);
    }
}