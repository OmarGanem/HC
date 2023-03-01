
using System.Data.Entity;

namespace PV06EOGJ.Data

{
    public class DataContext: DbContext
    {
        DbSet<equipo> Equipos { get; set; }
        public DataContext():base(¨name=con¨) 
        { }
    }
}
