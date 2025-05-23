﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;
using Persistencia.DataBase;
using Negocio;


namespace Negocio
{
    public class ContrasenaNegocio
    {
        public bool CambiarContrasena(Credencial credencial, string actual, string nueva)
        {
            if (credencial.Contrasena != actual)
            {
                return false;
            }

            if (!EsValida(nueva, actual))
            {
                return false;
            }

            credencial.Contrasena = nueva;
            credencial.FechaUltimoLogin = DateTime.Now;

            DataBaseUtils db = new DataBaseUtils();
            db.ActualizarCredencial(credencial, "credenciales.csv");

            return true;
        }
        public bool EsValida(string nueva, string actual)
        {
            if (nueva.Length >= 8 && nueva != actual)
            {
                return true;
            }
            else
            {  return false; }

        }

        public bool DebeForzarCambio(Credencial credencial)
        {
            // Si no hay fecha de último login, forzar el cambio
            if (!credencial.FechaUltimoLogin.HasValue)
            {
                return true;
            }

            if (EstaExpirada(credencial.FechaUltimoLogin.Value))
            {
                return true;
            }

            return false;
        }

        public bool EstaExpirada(DateTime fechaUltimoLogin)
        {
           
            if ((DateTime.Now - fechaUltimoLogin).TotalDays > 30)
            {
                return true;
            }
            return false;
        }
    }
}
