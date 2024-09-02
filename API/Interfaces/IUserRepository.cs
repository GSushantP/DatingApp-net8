using API.DTOs;
using API.Entities;

namespace API.Interfaces;

public interface IUserRepository
{
    void update(AppUsers user);
    Task<bool> SaveAllAsync();
    Task<IEnumerable<AppUsers>> GetUsersAsync();
    Task<AppUsers?> GetUserByIdAsync(int id);
    Task<AppUsers?> GetUserByNameAsync(string username);
    Task<IEnumerable<MemberDto>> GetMembersAsync();
    Task<MemberDto?> GetMemberAsync(string username);
}
