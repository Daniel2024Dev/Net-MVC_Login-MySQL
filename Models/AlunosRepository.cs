//PACOTE PARA USAR O Console.WriteLine
using System;
//PACOTE PARA USAR O MySql
using MySqlConnector;
//PACOTE PARA USAR O List
using System.Collections.Generic;

namespace Ex_data_base_com_seção.Models
{
        public class AlunosRepository
    {
        //AQUI SERÃO EXECUTADOS OS COMANDOS DO CRUD
        //CRUD = CREATE (INSERIR) READ (LEITURA) UPDATE (EDITAR) DELETE (DELETAR)
        //ESSA CLASSE VAI SERVI PARA FAZER A CONEXÃO COM BANCO DE DADOS 

        //CREDENCIAIS DE ACESSO AO BANCO DE DADOS(private)
        private const string DadosConexao = "Database = Escola; Data Source = localhost; User Id = root";

        //FUNÇÃO QUE TESTA CONEXÃO
        public void TesteConexao()
        {  
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);//NOVO OBJETO MySql SENDO CRIADO COM OS PARÂMETROS DEFINIDOS NA VARIÁVEL DadosConexao 
            Conexao.Open(); //SINTAXE PARA ABRIR CONEXÃO
            //IMPRESSÃO NO TERMINAL
            Console.WriteLine("Conexão ficionando");
            Conexao.Close(); //SINTAXE PARA FECHA CONEXÃO
        }
        //CREATE (INSERIR)

        //FUNÇÕES VOID SOMENTE EXECUTAM INFORMAÇÕES E NÃO RETORNAM INFORMAÇÕES
        public void Inserir(Alunos aluno)//RECEBENDO OS VALORES DE Alunos PARA aluno POR PARÂMETRO
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            string Query = "INSERT INTO Alunos(Nome, Usuario, Senha, DataNasc) VALUES (@Nome, @Usuario, @Senha, @DataNasc);";//Query >> SINTAXE USADA PARA INSERÇÃO DE INFORMAÇÃO NO BANCO DE DADOS
            //OBJETO Comando QUE RECEBE Query E Conexao,A VARIÁVEL Comando RECEBE Query,Conexao POR PARÂMETRO
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);//E OS VALORES DA Query É ENVIADO PARA Conexao

            Comando.Parameters.AddWithValue("@Nome",aluno.Nome);//PASSANDO VALORES POR PARÂMETRO DE aluno PARA @Nome
            Comando.Parameters.AddWithValue("@Usuario",aluno.Usuario);
            Comando.Parameters.AddWithValue("@Senha",aluno.Senha);
            Comando.Parameters.AddWithValue("@DataNasc",aluno.DataNasc);


            //SINTAXE QUE EXECUTA O COMANDO Query
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }
        //READ (LEITURA)
        public List<Alunos> Listar()
        {
            List<Alunos> Lista = new List<Alunos>();
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM Alunos;";//SINTAXE PARA SELECIONAR A TABELA Alunos
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            //AS INFORMAÇÕES SÃO GUARDADAS DENTRO DO Reader E ATRIBUIDO A VARIÁVEL Reader
            MySqlDataReader Reader = Comando.ExecuteReader();//COMANDO DE LEITURA DA Query COM O SELECT
            //ACESSANDO AS INFORMAÇÕES DE Reader
            while(Reader.Read())
            {
                Alunos aluno = new Alunos();
                aluno.IdAluno = Reader.GetInt32("IdAluno");

                if(! Reader.IsDBNull(Reader.GetOrdinal("Nome")))//TESTE PARA VER SE O CAMPO NO BANCO DE DADOS É NULO OU NÃO
                {
                    aluno.Nome = Reader.GetString("Nome");
                }
                if(! Reader.IsDBNull(Reader.GetOrdinal("Usuario")))//TESTE PARA VER SE O CAMPO NO BANCO DE DADOS É NULO OU NÃO
                {
                    aluno.Usuario = Reader.GetString("Usuario");
                }
                if(! Reader.IsDBNull(Reader.GetOrdinal("Senha")))//TESTE PARA VER SE O CAMPO NO BANCO DE DADOS É NULO OU NÃO
                {
                    aluno.Senha = Reader.GetString("Senha");
                }
                if(! Reader.IsDBNull(Reader.GetOrdinal("DataNasc")))//TESTE PARA VER SE O CAMPO NO BANCO DE DADOS É NULO OU NÃO
                {
                    aluno.DataNasc = Reader.GetDateTime("DataNasc");
                }
                //INCLUINDO INFORMAÇÕES DOS VALORES NA LISTA
                Lista.Add(aluno);
            }
            Conexao.Close();
            return Lista;
        }
        //UPDATE (EDITAR) 
        public void Editar(Alunos aluno)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "UPDATE Alunos SET Nome = @Nome, Usuario = @Usuario, Senha = @Senha, DataNasc = @DataNasc WHERE IdAluno = @IdAluno";//SINTAXE PARA EDIÇÃO DE REGISTROS DA TABELA Alunos
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@Nome",aluno.Nome);//SINTAXE QUE FAZ A SUBSTITUIÇÃO DE VALORES DE @Nome POR aluno.Nome INFORMADO PELO USUÁRIO
            Comando.Parameters.AddWithValue("@Usuario",aluno.Usuario);
            Comando.Parameters.AddWithValue("@Senha",aluno.Senha);
            Comando.Parameters.AddWithValue("@DataNasc",aluno.DataNasc.ToString("yyyy-MM-dd"));//CONVERSÃO DE FORMATO DE DATA PARA O BANCO DE DADOS
            Comando.Parameters.AddWithValue("@IdAluno",aluno.IdAluno);

            Comando.ExecuteNonQuery();
            Conexao.Close();
        }
        //BUSCA POR ID COM INFORMAÇÕES
        public Alunos BuscaPorId(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM Alunos WHERE IdAluno = @IdAluno";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@IdAluno",Id);
            MySqlDataReader Reader = Comando.ExecuteReader();
            Alunos aluno = new Alunos();
            while(Reader.Read())
            {
                aluno.IdAluno = Reader.GetInt32("IdAluno");

                if(! Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    aluno.Nome = Reader.GetString("Nome");
                }
                if(! Reader.IsDBNull(Reader.GetOrdinal("Usuario")))
                {
                    aluno.Usuario = Reader.GetString("Usuario");
                }
                if(! Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                {
                    aluno.Senha = Reader.GetString("Senha");
                }
                if(! Reader.IsDBNull(Reader.GetOrdinal("DataNasc")))
                {
                    aluno.DataNasc = Reader.GetDateTime("DataNasc");
                }
            }
            Conexao.Close();
            return aluno;
        }
        //DELETE (DELETAR)
        public void Deletar(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "DELETE FROM Alunos WHERE IdAluno = @IdAluno";//SINTAXE PARA DELETAR REGISTROS DA TABELA Alunos
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@IdAluno",Id);//SINTAXE QUE FAZ A SUBSTITUIÇÃO DE VALORES DE @IdAluno POR Id
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public Alunos ValidarLogin(Alunos a)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM Alunos WHERE Usuario = @Usuario AND Senha = @Senha";//AND >> AS DUAS TEM QUE SER VERDADEIRAS
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@Usuario",a.Usuario);
            Comando.Parameters.AddWithValue("@Senha",a.Senha);
            MySqlDataReader Reader = Comando.ExecuteReader();

            Alunos aluno = new Alunos();

            while(Reader.Read())
            {
                aluno.IdAluno = Reader.GetInt32("IdAluno");

                if(! Reader.IsDBNull(Reader.GetOrdinal("Nome")))//TESTE PARA VER SE O CAMPO NO BANCO DE DADOS É NULO OU NÃO
                {
                    aluno.Nome = Reader.GetString("Nome");
                }
                if(! Reader.IsDBNull(Reader.GetOrdinal("Usuario")))//TESTE PARA VER SE O CAMPO NO BANCO DE DADOS É NULO OU NÃO
                {
                    aluno.Usuario = Reader.GetString("Usuario");
                }
                if(! Reader.IsDBNull(Reader.GetOrdinal("Senha")))//TESTE PARA VER SE O CAMPO NO BANCO DE DADOS É NULO OU NÃO
                {
                    aluno.Senha = Reader.GetString("Senha");
                }
                if(! Reader.IsDBNull(Reader.GetOrdinal("DataNasc")))//TESTE PARA VER SE O CAMPO NO BANCO DE DADOS É NULO OU NÃO
                {
                    aluno.DataNasc = Reader.GetDateTime("DataNasc");
                }
            }
            Conexao.Close();
            return aluno;
        }
    }
}