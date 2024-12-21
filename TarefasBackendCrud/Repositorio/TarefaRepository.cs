using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TarefasBackendCrud.Models;
using TarefasBackendCrud.Repositorio;
namespace TarefasBackendCrud.Repositorio
{
    public interface ItarefaRepository
    {
        List<Tarefa> Read();
        void Creat(Tarefa tarefa);
        void Delete(Guid id);
        void Update(Tarefa tarefa);
    }

    public class TarefaRepository : ItarefaRepository
    {
        private readonly DataContext _context;

        public TarefaRepository(DataContext context)
        {
            _context = context;
        }
        public void Creat(Tarefa tarefa)
        {
            tarefa.Id = Guid.NewGuid();
            _context.Add(tarefa);
            _context.SaveChanges();
        }

        public void Delete(Guid Id)
        {
            Tarefa? tarefa = _context.Tarefa!.Find(Id);
            if (tarefa != null)
            {
                _context.Entry(tarefa).State = EntityState.Deleted;
            }
            else
            {
                throw new Exception("Tarefa não encontrada");
            }
        }
        public List<Tarefa> Read()
        {
            return _context.Tarefa!.ToList();
        }

        public void Update(Tarefa tarefa)
        {
            _context.Entry(tarefa).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}