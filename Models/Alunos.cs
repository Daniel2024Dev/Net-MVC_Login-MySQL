using System;

namespace Ex_data_base_com_seção.Models
{
    //classe que vai gerar objetos para ser inserido no banco de dados
    public class Alunos
    {
        public int IdAluno {get;set;}
        public string Nome {get;set;} 
        public string Usuario {get;set;}
        public string Senha {get;set;}
        public DateTime DataNasc {get;set;}
    }
}