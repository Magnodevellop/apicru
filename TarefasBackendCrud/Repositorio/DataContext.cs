using System;
using Microsoft.EntityFrameworkCore;
using TarefasBackendCrud.Models;

namespace TarefasBackendCrud.Repositorio
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<Tarefa>? Tarefa { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }

        public static implicit operator string?(DataContext? v)
        {
            throw new NotImplementedException();
        }
    }
}