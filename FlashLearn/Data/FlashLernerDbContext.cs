using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FlashLearn.Data
{
    public class FlashLernerDbContext : DbContext
    {
        public FlashLernerDbContext(DbContextOptions<FlashLernerDbContext> options) : base(options)
        {

        }
    }
}
