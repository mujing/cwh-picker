using CWHPicker.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWHPicker.Middleware
{
    public static class MiddlewareExtensions
    {
        public static async void AddSeedData(this IApplicationBuilder app)
        {
            var seedDataService = app.ApplicationServices.GetRequiredService<ISeedDataService>();
            seedDataService.EnsureSeedData();
        }
    }
}
