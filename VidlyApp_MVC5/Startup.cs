﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyApp_MVC5.Startup))]
namespace VidlyApp_MVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
