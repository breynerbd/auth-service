using System.ComponentModel.DataAnnotations;

namespace AuthService.Domain.Entitis;

public class User
{
    [Key]
    [MaxLength(16)]
    public string Id {get; set; } = string.Empty;

    [Required (ErrorMessage = "El nombre es obligatorio")]
    [MaxLength(25)]
    public string Name {get; set; } = string.Empty;

    [Required (ErrorMessage = "El apellido es obligatorio")]
    [MaxLength(16)]
    public string Surname {get; set; } = string.Empty;

    [Required]
    [MaxLength(25)]
    public string Username {get; set; } = string.Empty;

    [Required]
    [EmailAddress] // EL valor debe ser un correo electronico valido
    public string Email {get; set; } = string.Empty;

    [Required]
    [MaxLength(255)]
    public string Password {get; set; } = string.Empty;

    [Required]
    [MaxLength(25)]
    public string Status {get; set; } = true;

    [Required]
    public DateTime CreatedAt {get; set; } = DateTime.Now;

    [Required]
    public DateTime UpdatedAt {get; set; } = DateTime.Now;
    
    // Esto no altera la base de datos
    // Relacion con UserRole
    public UserProfile Profile {get; set; } = null;
    public ICollection<UserRole> UserRoles {get; set; } = [];
    public UserEmail UserEmail {get; set; } = null;
    public UserPasswordReset PasswordReset {get; set; } = null;
}