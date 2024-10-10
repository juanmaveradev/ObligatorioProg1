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
            int IdUsuario,
            string NombreUser,
            string ApellidoUser,
            string EmailUser,
            string PasswordUser,

           decimal saldoDisponible

            ) : base(IdUsuario, NombreUser, ApellidoUser, EmailUser, PasswordUser)
        {
            SaldoDisponible = saldoDisponible;

        }

        public override string ToString()
        {
            string respuesta = string.Empty;
            respuesta += $" ----> ID: {IdUsuario} <-----\n";
            respuesta += $" Nombre y Apellido: {NombreUser} {ApellidoUser}\n";
            respuesta += $" Email: {EmailUser} \n";
            respuesta += $" Password: {PasswordUser} \n";
            respuesta += $" Saldo Disponible: {SaldoDisponible} \n ";
            respuesta += $"------------------------------";

            return respuesta;
        }


    }
}