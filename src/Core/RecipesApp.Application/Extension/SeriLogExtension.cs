using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Sinks.MSSqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application.Extension
{
    public static class SeriLogExtension
    {
        public static void ConfigureLoggin()
        {
            var appSettings = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();

            var sinkOpts = new MSSqlServerSinkOptions { TableName = "Logs", AutoCreateSqlTable = true };

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("Logs/Log.txt")
                .WriteTo.Seq("http://localhost:5341/")
                .WriteTo.MSSqlServer(connectionString: appSettings.GetConnectionString("SqlConnection"),
                sinkOptions: sinkOpts)
                .CreateLogger();
        }


    }
}
