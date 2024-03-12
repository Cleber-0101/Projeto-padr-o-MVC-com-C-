using Microsoft.EntityFrameworkCore;
using SistemaDeEmprestimo.Models;

namespace SistemaDeEmprestimo.Data

    //Usando framework context
{
    public class ApplicationDbContext  : DbContext
    {
        //construtor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base( options ) 
        {

        }


        //Criando uma tabela no banco de dados 
        public DbSet<EmprestimoModel> Emprestimos { get; set; }




    }
}
