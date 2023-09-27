using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
    public class Carta
    {

        #region - Construtores

        public Carta(int codigoCarta, string nome, string rua, int numero, string bairro, string cidade, int idade, string texto, bool ativo)
        {
            CodigoCarta = codigoCarta;
            Nome = nome;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Idade = idade;
            Texto = texto;
            Ativo = ativo;
        }

        #endregion

        #region - Propriedades

        public int CodigoCarta { get; private set; }
        public string Nome { get; private set; }
        public string Rua { get; private set; }
        public int Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public int Idade { get; private set; }
        public string Texto { get; private set; }
        public bool Ativo { get; private set; }

        #endregion

        #region - Comportamentos

        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;
        public void AtribuirCodigo(int codigo) => CodigoCarta = codigo;

        #endregion
    }
}
