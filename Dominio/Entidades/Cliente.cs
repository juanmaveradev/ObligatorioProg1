using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Sistema;

namespace Dominio.Entidades
{
    public class Cliente : Usuario
    {
        public decimal SaldoDisponible { get; set; }

        public Cliente(
            decimal saldoDisponible,
            string nombre
            ) : base(nombre)
        {
            SaldoDisponible = saldoDisponible;

        }

    }
}
