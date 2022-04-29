using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_cartao1.Models
{
    public class Pagamentoo
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string NomeTitular { get; set; }
        [Required]
        [Column(TypeName = "varchar(16)")]
        public string NumeroCartao { get; set; }
        [Required]
        [Column(TypeName = "varchar(5)")]
        public string DataExpiracao { get; set; }
        [Required]
        [Column(TypeName = "varchar(3)")]
        public string CVV { get; set; }

        public Pagamentoo(PagamentoDTO dTO)
        {
          NomeTitular = dTO.NomeTitular;
          NumeroCartao = dTO.NumeroCartao;
          DataExpiracao = dTO.DataExpiracao;
          CVV = dTO.CVV;
        }

        public Pagamentoo()
        {

        }
  }
}
