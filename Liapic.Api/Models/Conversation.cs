using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Liapic.Api.Models;

/// <summary>
/// Représente une conversation privée entre deux utilisateurs sur Liapic.
/// Contient deux utilisateurs amis et le dernier message de la
/// conversation.
/// </summary>
[Table("Conversations")]
public class Conversation
{
    [Key]
    public int Id { get; set; }

    [Required]
    public required int Utilisateur1Id { get; set; }

    [ForeignKey(nameof(Utilisateur1Id))]
    public required Utilisateur Utilisateur1 { get; set; }

    [Required]
    public required int Utilisateur2Id { get; set; }

    [ForeignKey(nameof(Utilisateur2Id))]
    public required Utilisateur Utilisateur2 { get; set; }

    public int? DernierMessageId { get; set; }

    [ForeignKey(nameof(DernierMessageId))]
    public Message? Message { get; set; }

    public DateTime DatePremiereConversation { get; set; } = DateTime.UtcNow;
}