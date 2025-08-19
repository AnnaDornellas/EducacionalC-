using System.ComponentModel;

namespace Academico.Models
{
    public class Aluno
    {
        public int Nome { get; set; }
        [DisplayName("e-mail")]
        public int Email { get; set; }
        [DisplayName("CEP")]
        public int Cep { get; set; }


    }
}
