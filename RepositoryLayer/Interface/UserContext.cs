using CommonLayer;
using CommonLayer.DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interface
{
   public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //note and users
            modelBuilder.Entity<UserNotes>()
                  .HasOne(n => n.Note)
                  .WithMany(l => l.User_Notes)
                  .HasForeignKey(nl => nl.NoteId);

            modelBuilder.Entity<UserNotes>()
                .HasOne(n => n.Label)
                .WithMany(l => l.User_Notes)
                .HasForeignKey(nl => nl.LabelId);

            //label and users
         

            modelBuilder.Entity<LabelNotes>()
               .HasOne(n => n.Label)
               .WithMany(l => l.Label_Note)
               .HasForeignKey(nl => nl.LabelId);


        }
        public DbSet<Users> User { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<LabelNotes> LabelNote { get; set; }
        public DbSet<UserNotes> UserNote { get; set; }

    }
}
