using AuthService.Domain.Entitis;
namespace AuthService.Domain.Interfaces;

public interface IUserRepository {
    Task<User?> GetUserByIdAsync(string id);
    Task<User?> GetUserByEmailAsync(string email);
    Task<User?> GetUserByUsernameAsync(string username);
    Task<User?> GetUserByPasswordResetTokenAsync(string token);
    Task<User> CreateAsync(User user);
    Task<User> UpdateAsync(User user);
    Task<User> DeleteAsync(User user);

    Task<bool> ExistsByEmailAsync(string email);
    Task<bool> ExistsByUsernameAsync(string username);
    Task UpdateUserRoleAsync(string userId, string roleId);
    
}