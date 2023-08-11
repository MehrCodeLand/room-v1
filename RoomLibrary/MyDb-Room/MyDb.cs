using Microsoft.EntityFrameworkCore;
using RoomLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary.MyDb_Room;

public class MyDb : DbContext
{
    public MyDb( DbContextOptions<MyDb> options ) : base( options )
    {
        
    }
    public DbSet<Art> Arts { get; set; }
}
