using Microsoft.EntityFrameworkCore;
using SistemaGerenciamentoTarefas.Models;

namespace SistemaGerenciamentoTarefas.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {

        }

        public DbSet<Tarefas> Tarefas { get; set; }
    }
}
