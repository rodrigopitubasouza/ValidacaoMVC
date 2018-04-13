using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidacoesMVC.Models {
    public class Usuario {

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string nome { get; set; }
        [Range(18, 70,ErrorMessage = "A idade tem que estar entre 18 e 70 anos")]
        public int idade { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Digite um e-mail válido")]
        public string email { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}",ErrorMessage = "Somente Letras entre 5 a 15 caracteres")]
        [Required(ErrorMessage = "O login é obrigatoório")]
        public string login { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string senha { get; set; }
        [Compare("senha",ErrorMessage ="As senhas não são iguais")]
        public string confirmasenha { get; set; }
        [StringLength(50,MinimumLength = 5, ErrorMessage = "Insira uma informção de 5 a 50 caracteres")]
        public string observacao { get; set; }
    }





   
}