﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeUsuarios.Infra.Data.Contexts
{
    /// <summary>
    /// Classe para injeção de dependência executada toda 
    /// vez que o Migrations for inicializado no projeto 
    /// </summary>
    public class SqlServerContextMigration : IDesignTimeDbContextFactory<SqlServerContext>
    {
        /// <summary>
        /// Classe para injeção de dependência executada toda vez 
        /// que o Migrations for inicializado no projeto
        /// </summary>

        public SqlServerContext CreateDbContext(string[] args)
        {
            #region Localizar o arquivo appsettings.json

            var configurationBuider = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuider.AddJsonFile(path, false);

            #endregion


            #region Captura a connectionstring do arquivo appsettings.json

            var root = configurationBuider.Build();
            var connectionString = root.GetSection("ConnectionStrings").GetSection("CentralDeUsuarios").Value;

            #endregion

            #region Fazer a injeção de  dependência na classe SqlServerContext

            var builder = new DbContextOptionsBuilder<SqlServerContext>();
            builder.UseSqlServer(connectionString); 

            return new SqlServerContext(builder.Options);

            #endregion


        }
    }
}
