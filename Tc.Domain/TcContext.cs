using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tc.Domain.Models;

namespace Tc.Domain
{
    public class TcContext:DbContext
    {
        public TcContext():base("TcContext")
        {

        }

        public DbSet<Voter> Voters { get; set; }


    }
}
