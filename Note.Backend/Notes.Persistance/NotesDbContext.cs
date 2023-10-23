using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Notes.Application.Interfaces;
using System.Text;
using System.Threading.Tasks;
using Notes.Domain;
using Notes.Persistance.EntityTypeConfiguration;

namespace Notes.Persistance
{
    public class NotesDbContext : DbContext, INotesDbContext
    {
        public DbSet<Note> Notes { get; set; }
        public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
