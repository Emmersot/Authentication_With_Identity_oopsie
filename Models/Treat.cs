using System.Collections.Generic;
using System;

namespace PierreSweets.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }
    public int Rating { get; set; }
    public string Name { get; set; }
    public int TreatId { get; set; }
    public string Ingredients { get; set; }
    public virtual ApplicationUser User { get; set; } 

    public virtual ICollection<FlavorTreat> JoinEntities { get; } 
  }
}