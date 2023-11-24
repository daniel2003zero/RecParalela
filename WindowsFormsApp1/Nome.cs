using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Nome
    {

        public string nome { get; set; }

        // Construtor para inicialização
        public Nome(string Nome)
        {
            nome = Nome;

        }

        // Método para obter o nome completo
        public string ObterNomeCompleto()
        {
            return $"Daniel";
        }
    }
}
