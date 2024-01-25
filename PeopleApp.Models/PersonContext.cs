using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp.Models
{
	public class PersonContext:DbContext
	{
        public DbSet<Person> People { get; set; }
        public PersonContext(DbContextOptions options):base(options)
        {
            
        }
    }
}
