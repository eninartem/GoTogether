using IdentityModel;

using IdentityServer4.Models;

namespace Identity
{
    public static class Config
    {
        public static IEnumerable<Client> GetClients() => new List<Client>
        {
            new Client
            {
                ClientId="client_id",
                ClientSecrets = { new Secret("client_secret".ToSha256()) },
                AllowedGrantTypes =  GrantTypes.ClientCredentials,
                AllowedScopes =
                {
                    "PeoplesAPI", "IventsAPI", "PlacesAPI", "SupportAPI"
                }
            }
        };

        public static IEnumerable<IdentityResource> GetIdentityResources() => new List<IdentityResource>
        {
            new IdentityResources.OpenId()
        };

        public static IEnumerable<ApiResource> GetApiResources() => new List<ApiResource>
        {
            new ApiResource("PeoplesAPI"),
            new ApiResource("IventsAPI"),
            new ApiResource("PlacesAPI"),
            new ApiResource("SupportAPI")
        };
    }
}
