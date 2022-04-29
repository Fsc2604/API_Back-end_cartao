using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_cartao1.Models
{
  public class PagamentoDTO
  {
    public int? Id { get; set; }
    public string NomeTitular { get; set; }
    public string NumeroCartao { get; set; }
    public string DataExpiracao { get; set; }
    public string CVV { get; set; }
  }
}
