using System;

public class Class1
{
    public interface IUserRepository
    {
        Task SaveUserAsync(UserModel userModel);
        Task<UserModel> GetUserByIdAsync(int userId);
        Task<UserModel> GetUserByUsernameAsync(string username);
    }
}
