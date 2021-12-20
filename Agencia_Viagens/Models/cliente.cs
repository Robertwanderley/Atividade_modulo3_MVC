using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agencia_Viagens.Models
{
    public class cliente
    {
        [Key]
        public int codigo { get; set; }
        public string nome { get; set; }
        public string email { get; set;}

    }
}