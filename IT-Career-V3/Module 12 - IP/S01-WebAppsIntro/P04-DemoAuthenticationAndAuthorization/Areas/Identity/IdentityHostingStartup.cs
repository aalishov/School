using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using P04_DemoAuthenticationAndAuthorization.Data;
using P04_DemoAuthenticationAndAuthorization.Data.Models;

[assembly: HostingStartup(typeof(P04_DemoAuthenticationAndAuthorization.Areas.Identity.IdentityHostingStartup))]
namespace P04_DemoAuthenticationAndAuthorization.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}