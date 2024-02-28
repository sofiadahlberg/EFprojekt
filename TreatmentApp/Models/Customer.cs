using System.ComponentModel.DataAnnotations;
namespace TreatmentApp.Models; 

public class Customer {
     public int CustomerId { get; set; }
     [Required]
      [Display(Name = "Förnamn")]
      public string? Firstname {get; set;}

        [Required]
         [Display(Name = "Efternamn")]
        public string? Lastname {get; set;}
        [Required]
         [Display(Name = "Telefonnummer")]
        public string? PhoneNumber {get; set;}
         [Display(Name = "Datum ")]
        public DateTime Date { get; set; }
          [Required]
        public bool ApiKeyRequired {get; set; } = false;
//Foreign Key
[Display(Name = "Behandling")]
public int? TreatmentId { get; set; }  

        // Navigation 
        [Display(Name = "Behandling")]
    public Treatment? Treatment {get; set;}
}
