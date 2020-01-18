﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira um maximo de 50 e minimo de 5 caracteres")]
        public string Observacoes { get; set; }
        [Range(18,70, ErrorMessage = "A idade tem que estar entre 18 e 70 anos")]
        public int Idade { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Digite um email valido")]
        public string Email { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Caracteres invalidos")]
        [Required(ErrorMessage = "O Login é obrigatório")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Este login já existe")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A Senha é obrigatória")]
        public string Senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "Senha diferentes")]
        public string ConfirmarSenha { get; set; }
    }
}