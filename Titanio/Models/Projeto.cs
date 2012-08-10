using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Titanio.Models
{
    public class Projeto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio{ get; set; }
        public string descricao { get; set; }
        public bool ativo { get; set; }
    }

    public class TitanioDBContext : DbContext
    {
        public DbSet<Projeto> Projetos { get; set; }
    }
}

