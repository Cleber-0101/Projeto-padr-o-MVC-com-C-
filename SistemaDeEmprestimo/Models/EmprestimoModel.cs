namespace SistemaDeEmprestimo.Models
{

    //Tabela de usuarios
    public class EmprestimoModel
    {
        public int id { get; set; }
        public string Recebedor { get; set; }
        public string Fornecedor { get; set; }
        public string LivroEmprestado { get; set; }
        public DateTime dataUltimaAtualizacao { get; set; } = DateTime.Now;

    }
}


























// Use uma migrations para passar essas informações pro banco de dados 

//Dentro da model criamos a estrutura do banco de dados 
