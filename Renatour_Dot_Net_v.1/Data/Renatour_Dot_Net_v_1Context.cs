using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Renatour_Dot_Net_v._1.Views.Destinos;

namespace Renatour_api
{
    public class Renatour_Dot_Net_v_1Context : DbContext
    {
        public Renatour_Dot_Net_v_1Context (DbContextOptions<Renatour_Dot_Net_v_1Context> options)
            : base(options)
        {
        }

        public DbSet<Renatour_Dot_Net_v._1.Views.Destinos.Destinos> Destinos { get; set; } = default!;
    }
}
