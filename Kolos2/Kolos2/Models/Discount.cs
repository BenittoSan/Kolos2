using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolos2.Models;

public class Discount
{
    [Key] public int IdDiscount { get; set; }
    [Required] public int Value { get; set; }
    [Required] public DateTime DateFrom { get; set; }
    [Required] public DateTime DateTo { get; set; }

    public int IdClient { get; set; }
    
    [ForeignKey(nameof(IdClient))]
    public Client Client { get; set; }
    
}