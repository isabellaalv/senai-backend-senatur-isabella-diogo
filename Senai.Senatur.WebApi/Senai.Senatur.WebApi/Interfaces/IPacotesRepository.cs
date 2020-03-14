﻿using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    public interface IPacotesRepository
    {
        List<Pacotes> Get();
        Pacotes BuscarPorId(int Id);
        void Cadastrar(Pacotes pacotes);
        void Atualizar(Pacotes pacotes);
        void Deletar(Pacotes pacotes);
        List<Pacotes> Ativos();
        List<Pacotes> Inativos();
        List<Pacotes> PorCidade(int Id);
        List<Pacotes> PorAsc();
        List<Pacotes> PorDes();
    }
}
