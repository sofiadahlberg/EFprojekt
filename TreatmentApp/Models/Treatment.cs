using System.ComponentModel.DataAnnotations;

namespace TreatmentApp.Models{
public class Treatment{
    //Properties
    public int TreatmentId { get; set; }
     [Display(Name = "Längd (minuter)")]
    public int Duration { get; set; }
     [Display(Name = "Behandling")]
    public string? Category { get; set; }
       [Required]
   
    //Foreign Keys
   [Display(Name = "Tidsintervall. Visar starttid av intervallen")]
    public int TimeIntervalId { get; set; }

     // Navigation 
      [Display(Name = "Tidsintervall")]
    public TimeInterval? TimeInterval { get; set; }
     public ICollection<Customer>? Customers { get; set; }
}
}