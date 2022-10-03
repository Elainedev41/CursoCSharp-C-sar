using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendasSalas
{
    enum DiaSemana
    {
        Domingo = 1,
        Segunda_Feira = 2,
        Terca_Feira = 3,
        Quarta_Feira = 4,
        Quinta_Feira = 5,
        Sexta_feira = 6,
        Sabado = 7,
    }

    internal class Periodo
    {
        DiaSemana diaSemana;
        Horario _horario;
        float _preco;
        bool _estaAtiva;
    }
}
