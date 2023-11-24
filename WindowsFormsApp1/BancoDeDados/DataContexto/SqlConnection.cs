using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BancoDeDados.DataContexto
{
    internal static  class SqlConnection
    {
        /// <summary>
        /// Propriedade <c>Conexao</c> retorna a string que foi definida no arquivo App.config.
        /// </summary>
        internal static string Conexao => @"Data Source=.\sqlexpress;Initial Catalog=RecParalela;User ID=sa;Password=sql2022";

    }
 }