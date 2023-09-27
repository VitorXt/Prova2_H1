using Revisao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Interfaces
{
    public interface ICartaService
    {
        public void Adicionar(NovoRegistraCartaViewModel carta);
        public void Atualizar(EditaRegistraCartaViewModel carta);
        public IList<RegistraCartaViewModel> ObterTodos();
        public RegistraCartaViewModel ObterPorCodigo(int CodigoCarta);
    }
}
