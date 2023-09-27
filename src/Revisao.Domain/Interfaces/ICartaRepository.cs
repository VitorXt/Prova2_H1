using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Interfaces
{
    public interface ICartaRepository
    {
        public void Adicionar(Carta carta);
        public void Atualizar(Carta carta);
        public IList<Carta> ObterTodos();
        public Carta ObterPorCodigo(int CodigoCarta);
    }
}
