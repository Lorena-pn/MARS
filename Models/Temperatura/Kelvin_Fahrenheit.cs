using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARS.Models.Temperatura
{
    public class Kelvin_Fahrenheit
    {
        public static string Operacao(float num1)
        {
            string url = @"C:\Users\felip\Documents\UFS\4 - Quarto Periodo\OAC\Trabalho de OAC\Temperatura\Kelvin_fahrenheit.asm";
            return EntradaPadrao.MARS(url, num1);
        }         
    }
}