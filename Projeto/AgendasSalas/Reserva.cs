using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendasSalas
{
    internal class Reserva
    {
        List<DisponibilidadeSala> _salasAlugadas;
        List<Equipamento> _equipamentos;
        List<Servico> _servicos;
        List<Objetos> _objetos;

        public bool RealizarContratacao()
        {
            return true;
        }

    }
}
