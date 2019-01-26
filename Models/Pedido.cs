using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDV_NATANIEL.Models
{
    public class Pedido
    {
        public int Numero { get; set; }
        public DateTime DataEntrega { get; set; }
        public string cliente { get; set; }
        public Decimal ValorPedido { get; set; }
    }
}