﻿using Microsoft.Extensions.Configuration;
using System;
using System.Text.RegularExpressions;

namespace DemoHabitTracker.Models
{
    public static class HabitDB
    {

        private static string connectionString;

        public static string GetConnectionStringFromHerokuEnv(int db)
        {
            switch (db)
            {
                case 0:
                    {
                        var configuration = new ConfigurationBuilder().AddEnvironmentVariables().Build();
                        string DATABASE_URL = configuration.GetSection("DATABASE_URL").Value;

                        if (DATABASE_URL == null)
                        {
                            Console.Write("reading DATABASE_URL locally.. ");
                            configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                            DATABASE_URL = configuration.GetConnectionString("DATABASE_URL");
                        }
                        else
                            Console.WriteLine("reading from Environment *heroku");

                        Console.WriteLine("DATABASE_URL={0}", DATABASE_URL);

                        connectionString = "bla";

                        string pattern = @"\bpostgres:\/\/(\w+):(\w+)@(\S+):(\d+)\/(\w+)\b";
                        foreach (Match match in Regex.Matches(DATABASE_URL, pattern))
                        {
                            connectionString = $"Server={match.Groups[3].Value};Port={match.Groups[4].Value};Database={match.Groups[5].Value};User Id={match.Groups[1].Value};Password={match.Groups[2].Value};SSL Mode=Require;Trust Server Certificate=True;Include Error Detail=True;";
                            Console.WriteLine(match.Index);
                        }
                        break;
                    }
                case 1:
                    {
                        var configuration = new ConfigurationBuilder().AddEnvironmentVariables().Build();
                        string DATABASE_URL = configuration.GetSection("HEROKU_POSTGRESQL_BLACK_URL").Value;

                        if (DATABASE_URL == null)
                        {
                            Console.Write("reading DATABASE_URL locally.. ");
                            configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                            DATABASE_URL = configuration.GetConnectionString("DATABASE_URL");
                        }
                        else
                            Console.WriteLine("reading from Environment *heroku");

                        Console.WriteLine("DATABASE_URL={0}", DATABASE_URL);

                        connectionString = "bla";

                        string pattern = @"\bpostgres:\/\/(\w+):(\w+)@(\S+):(\d+)\/(\w+)\b";
                        foreach (Match match in Regex.Matches(DATABASE_URL, pattern))
                        {
                            connectionString = $"Server={match.Groups[3].Value};Port={match.Groups[4].Value};Database={match.Groups[5].Value};User Id={match.Groups[1].Value};Password={match.Groups[2].Value};SSL Mode=Require;Trust Server Certificate=True;Include Error Detail=True;";
                            Console.WriteLine(match.Index);
                        }
                        break;
                    }
            }

            return connectionString;

        }
    }
}
