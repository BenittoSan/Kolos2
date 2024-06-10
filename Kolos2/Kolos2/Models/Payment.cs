using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolos2.Models;

public class Payment
{
    [Key] public int IdPayment { get; set; }
    [Required] public DateTime Date { get; set; }
    [Required]public double Value { get; set; }

    public int IdClient { get; set; }
    [ForeignKey(nameof(IdClient))] public Client Client { get; set; }

    public int IdSubscription { get; set; }
    [ForeignKey(nameof(IdSubscription))] public Subscription Subscription { get; set; }
}