using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MARS.Models.Operações.Float
{
    public class Diminuição_F
    {
        public static string Operacao(float num1, float num2)
        {
            string url = @"C:/Users/felip/Documents/UFS/4 - Quarto Periodo/OAC/Trabalho de OAC/Operações/Subtração_F.asm";
            return EntradaPadrao.MARS(url, num1, num2);
        } 
    }
}