using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FindRoomMate.Models
{
    public class DataContext: DbContext
    {
        public DbSet<Broker> Brokers { get; set; }
    }
}