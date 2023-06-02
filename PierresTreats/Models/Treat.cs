using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The treat's name can't be empty!")]
    public string TreatName { get; set; }
    [Required(ErrorMessage = "The treat's description can't be empty!")]
    public string Description { get; set; }
    public List<FlavorTreat> JoinEntities { get;}
    public ApplicationUser User { get; set; }
  }
}