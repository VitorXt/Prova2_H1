using Newtonsoft.Json;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Repositories
{
    public class CartaRepository : ICartaRepository

    {
        #region - Construtor

        private readonly string _cartasCaminhoArquivo;
        public CartaRepository()
        {
            _cartasCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "Carta.json");
        }

        #endregion

        #region - Funções do Repositório

        public void Adicionar(Carta carta)
        {
            List<Carta> cartas = new List<Carta>();
            cartas = LerCartasDoArquivo();
            int proximoCodigo = ObterProximoCodigoDisponivel();
            carta.AtribuirCodigo(proximoCodigo);
            cartas.Add(carta);
            EscreverCartasNoArquivo(cartas);
        }

        public void Atualizar(Carta carta)
        {
            throw new NotImplementedException();
        }

        public IList<Carta> ObterTodos()
        {
            return LerCartasDoArquivo();
        }

        public Carta ObterPorCodigo(int CodigoCarta)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region - Funções do Arquivo

        private List<Carta> LerCartasDoArquivo()
        {
            if (!System.IO.File.Exists(_cartasCaminhoArquivo))
            {
                return new List<Carta>();
            }

            string json = System.IO.File.ReadAllText(_cartasCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<Carta>>(json);
        }

        private int ObterProximoCodigoDisponivel()
        {
            List<Carta> cartas = LerCartasDoArquivo();
            if (cartas.Any())
            {
                return cartas.Max(p => p.CodigoCarta) + 1;
            }
            else
            {
                return 1;
            }
        }

        private void EscreverCartasNoArquivo(List<Carta> cartas)
        {
            string json = JsonConvert.SerializeObject(cartas);
            System.IO.File.WriteAllText(_cartasCaminhoArquivo, json);
        }

        #endregion
    }
}
