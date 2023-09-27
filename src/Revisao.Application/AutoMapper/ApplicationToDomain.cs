using AutoMapper;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.AutoMapper
{
	public class ApplicationToDomain : Profile
	{
        public ApplicationToDomain()
        {

         CreateMap<NovoRegistraCartaViewModel, Carta>()
         .ConstructUsing(carta => new Carta(0, carta.Nome, carta.Rua, carta.Numero, carta.Bairro, carta.Cidade, carta.Idade, carta.Texto , carta.Ativo));

        }
    }
}
