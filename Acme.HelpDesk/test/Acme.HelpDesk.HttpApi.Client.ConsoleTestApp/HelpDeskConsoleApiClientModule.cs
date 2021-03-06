﻿using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Acme.HelpDesk.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(HelpDeskHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class HelpDeskConsoleApiClientModule : AbpModule
    {
        
    }
}
