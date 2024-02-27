using System.ComponentModel.DataAnnotations;

namespace BookingApp.Models; 
public class TimeInterval{

    public int TimeIntervalId {get; set;}
     [Display(Name = "Startid ")]
      public DateTime StartTime { get; set; }
       [Display(Name = "Sluttid ")]
    public DateTime EndTime { get; set; }
     [Display(Name = "Tillgängligt ")]
    public bool Available { get; set; }
    [Required]
    public bool ApiKeyRequired {get; set; } = false;

// Navigation 
    public ICollection<Treatment>? Treatments { get; set; }
}