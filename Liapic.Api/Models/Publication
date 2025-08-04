/// <summary>
/// Représente une publication partagée par un utilisateur.
/// Peut contenir un média, une description et une visibilité (amis ou public).
/// </summary>
[Table("Publications")]
public class Publication
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int UtilisateurId { get; set; }

    [ForeignKey(nameof(UtilisateurId))]
    public Utilisateur Utilisateur { get; set; }

    [MaxLength(500)]
    public string? Description { get; set; }

    [Required]
    [EnumDataType(typeof(VisibilitePost))]
    public VisibilitePost Visibilite { get; set; }

    [Required]
    public string MediaUrl { get; set; }

    public DateTime DatePublication { get; set; } = DateTime.UtcNow;
}

/// <summary>
/// Détermine à qui est visible une publication.
/// </summary>
public enum VisibilitePost
{
    Amis = 0,
    Public = 1
}
