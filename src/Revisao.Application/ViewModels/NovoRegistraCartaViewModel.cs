﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.ViewModels
{
    public class NovoRegistraCartaViewModel
    {
        [Required(ErrorMessage = "O Nome é obrigatório.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O Nome deve ter no mínimo 3 caracteres e no máximo 255 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A Rua é obrigatória.")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "O Numero do endereço é obrigatório.")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "O Bairro é obrigatório.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "A Cidade é obrigatória.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "A Idade é obrigatório.")]
        [Range(1, 15, ErrorMessage = "Não é permitido maiores de 15 anos")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "A Carta é obrigatória.")]
        [MaxLength(500, ErrorMessage = "A Carta tem que ter no máximo 500 caractéres.")]
        public string Texto { get; set; }
        public bool Ativo { get; set; }
    }
}
