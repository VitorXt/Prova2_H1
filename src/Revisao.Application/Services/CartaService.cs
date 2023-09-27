using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
    public class CartaService : ICartaService
    {
        private readonly ICartaRepository _cartaRepository;
        private readonly IMapper _mapper;

        public CartaService(ICartaRepository cartaRepository, IMapper mapper)
        {
            _cartaRepository = cartaRepository;
            _mapper = mapper;
        }

        public void Adicionar(NovoRegistraCartaViewModel carta)
        {
            _cartaRepository.Adicionar(_mapper.Map<Carta>(carta));
        }

        public void Atualizar(EditaRegistraCartaViewModel carta)
        {
            throw new NotImplementedException();
        }

        public RegistraCartaViewModel ObterPorCodigo(int CodigoCarta)
        {
            throw new NotImplementedException();
        }

        public IList<RegistraCartaViewModel> ObterTodos()
        {
            return _mapper.Map<List<RegistraCartaViewModel>>(_cartaRepository.ObterTodos());
        }
    }
}
