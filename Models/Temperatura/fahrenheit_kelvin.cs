using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARS.Models.Temperatura
{
    public class fahrenheit_kelvin
    {
        public static string Operacao(float num1)
        {
            string url = @"C:\Users\felip\Documents\UFS\4 - Quarto Periodo\OAC\Trabalho de OAC\Temperatura\fahrenheit_para_kelvin.asm";
            return EntradaPadrao.MARS(url, num1);
        }         
    }
}