using System.ComponentModel.DataAnnotations;

namespace BookingApp.Models; 
public class Treatment{
    //Properties
    public int TreatmentId { get; set; }
     [Display(Name = "Längd (minuter)")]
    public int Duration { get; set; }
     [Display(Name = "Behandling")]
    public string? Category { get; set; }
       [Required]
    public bool ApiKeyRequired {get; set; } = false;
    //Foreign Keys
   [Display(Name = "TidsintervallId")]
    public int TimeIntervalId { get; set; }

     // Navigation 
      [Display(Name = "Tidsintervall")]
    public TimeInterval? TimeInterval { get; set; }
     public ICollection<Customer>? Customers { get; set; }
}