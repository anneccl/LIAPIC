using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Liapic.Api.Models;

/// <summary> 
/// Représente une notifiaction envoyée à un utilisateur suite à un évènement
/// (Like, follow, etc...).
/// Contient l'utilisateur qui reçoit la notification, le type de notifcation, 
/// un message et un lien si possible.
/// </summary>
[Table("Notifications")]
public class Notification
{
    [Key]
    public int Id { get; set; }
    [Required]
    public required int UtilisateurId { get; set; }
    [ForeignKey(nameof(UtilisateurId))]
    public required Utilisateur Utilisateur { get; set; }
    [Required]
    public  TypeNotification Type { get; set; }
    [Required]
    public required string Message { get; set; }
    [Url]
    public string? LienCible { get; set; }
    public bool Lu { get; set; }
    public DateTime DateNotification { get; set; } = DateTime.UtcNow;
}

public enum TypeNotification
{
    Autre = 0,
    Aime = 1,
    Commentaire = 2,
    NouvellePublication = 3,
    NouveauAbonne = 4 
}