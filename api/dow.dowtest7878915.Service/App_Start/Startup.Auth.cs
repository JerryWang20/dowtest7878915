using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.ActiveDirectory;
using System.Configuration;
using System.IdentityModel.Tokens;
using dow.dowtest7878915.Common;

namespace dow.dowtest7878915.Service
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            app.UseWindowsAzureActiveDirectoryBearerAuthentication(
                new WindowsAzureActiveDirectoryBearerAuthenticationOptions
                {
                    TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidAudience = CommonConfig.ClientID
                    },
                    Tenant = CommonConfig.Tenant,
                });
        }
    }
}
