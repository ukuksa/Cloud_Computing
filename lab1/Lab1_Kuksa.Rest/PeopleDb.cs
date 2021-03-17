using lab1_Kuksa.Rest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1_Kuksa.Rest
{
    public class PeopleDb : DbContext
    {
        public PeopleDb(DbContextOptions<PeopleDb> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
    }
}
