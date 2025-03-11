using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameWork.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connections.ConnectionString);
        }



        public DbSet<Club> Clubs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<MentorStudent> MentorStudents { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<MentorStudent>().Property((e) => e.SignDate).HasDefaultValueSql("GETDATE()");

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var ForeignKey in entity.GetForeignKeys())
                {
                    ForeignKey.DeleteBehavior = DeleteBehavior.Restrict;
                }
            }



        }


    }
}
