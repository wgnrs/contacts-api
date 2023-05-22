using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contatos.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Contatos.Infra.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {            
        }
        public DbSet<Contato> Contatos { get; set; }
    }
}