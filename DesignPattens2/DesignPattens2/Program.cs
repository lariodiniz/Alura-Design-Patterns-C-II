using DesignPattens2.Capitulo01;
using DesignPattens2.Capitulo02;
using DesignPattens2.Capitulo03;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aula 01
            IDbConnection conexao = new ConnectionFactory().GetConnection();

            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "Select * trom tabela";            
             */

            /* Aula 02
            NotasMusicais notas = new NotasMusicais();

            IList<INota>  musica = new List<INota>()
            { 
                notas.Pega("do"), notas.Pega("re"), notas.Pega("mi"), notas.Pega("fa"),  notas.Pega("fa"),
                notas.Pega("fa"), notas.Pega("do"), notas.Pega("re"), notas.Pega("do"),  notas.Pega("re"),
                notas.Pega("re"), notas.Pega("re"), notas.Pega("do"), notas.Pega("sol"), notas.Pega("fa"),
                notas.Pega("mi"), notas.Pega("mi"), notas.Pega("mi"), notas.Pega("do"),  notas.Pega("re"),
                notas.Pega("mi"), notas.Pega("fa"), notas.Pega("fa"), notas.Pega("fa")
            };

            Piano piano = new Piano();
            piano.Toca(musica);
            */

            /* Aula 03 

            Historico historico = new Historico();
            Contrato c = new Contrato(DateTime.Now,"lario", TipoContrato.Novo);

            historico.Adiciona(c.SalvaEstado());          

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());            

            Console.WriteLine(historico.Pega(0).Contrato.Tipo);
            */
        }
    }
}
