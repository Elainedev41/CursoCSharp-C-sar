using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendasSalas
{
    internal class Sala
    {
        int _id;
        int _descricao;
        string _identificacao;
        int _estado;
        int medidaLado1Metros;
        int medidaLado2Metros;
        int _numeroMaximoPessoas;
        int _janelas;
        Endereco _localizacao;        
        bool _temBaheiro;
        bool _temEstacionamento;
        bool _temArCondicionado;
            List<string> _fotos;

    }
}
