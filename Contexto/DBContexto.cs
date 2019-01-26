using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PDV_NATANIEL.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PDV_NATANIEL.Contexto
{
    public class DBContexto:DbContext

    {
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Itens> Itens { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}