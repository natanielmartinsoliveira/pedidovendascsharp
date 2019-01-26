using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDV_NATANIEL.Models
{
    public class Itens
    {
        public int ItenID { get; set; }
        public Pedido PedidoId { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public Decimal valor { get; set; }
        public Decimal valorTotal { get; set; }
    }
}