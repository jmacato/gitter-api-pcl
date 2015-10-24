﻿using System.Threading.Tasks;

namespace GitterSharp.Services
{
    public partial class GitterApiService : BaseGitterApiService
    {
        #region Authentication

        public override async Task<bool?> LoginAsync(string oauthKey, string oauthSecret)
        {
            return await WindowsAuthenticationService.ExecuteLoginAsync(oauthKey, oauthSecret);
        }

        #endregion
    }
}