using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TaskApp.Model;

namespace TaskApp.DAL
{
  
        public class TaskApplicationContext : DbContext
        {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
          //  optionsBuilder.UseSqlServer("Server=LAPTOP-40DQMB81\\SQLEXPRESS; Database=Task;Trusted_Connection=True;");

        //}
            public TaskApplicationContext(DbContextOptions<TaskApplicationContext> options): base(options)
            {

            }
            public DbSet<TaskModel> Tasks { get; set; }

            public DbSet<UserModel> Users { get; set; }

            public DbSet<CategoryModel> Categories { get; set; }

        //fluentAPI
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
          //  base.OnModelCreating(modelBuilder)
            //    .HasOne(t => t.User)
              //  .WithOne(t => t.task);
        //}


        }

    }

