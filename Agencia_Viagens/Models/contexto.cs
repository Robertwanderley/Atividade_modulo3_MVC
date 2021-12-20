using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Agencia_Viagens.Models
{
    public class contexto:DbContext
    {
        public DbSet<cliente> clientes { get; set; }
    }
}