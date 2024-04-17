using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class UserRepository : IUserRepository
{
    private readonly YourDbContext _dbContext;

    public UserRepository(YourDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task SaveUserAsync(UserModel userModel)
    {
        var userEntity = new UserEntity
        {
            
            FirstName = userModel.FirstName,
            LastName = userModel.LastName,
            Age = userModel.Age,
            Email = userModel.Email,
            MonthlyIncome = userModel.MonthlyIncome,
            IsBlocked = userModel.IsBlocked,
            HashedPassword = userModel.HashedPassword,
            
        };

        _dbContext.Users.Add(userEntity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<UserModel> GetUserByIdAsync(int userId)
    {
        var userEntity = await _dbContext.Users.FindAsync(userId);

        if (userEntity == null)
        {
            return null;
        }

        return MapUserEntityToModel(userEntity);
    }

    public async Task<UserModel> GetUserByUsernameAsync(string username)
    {
        var userEntity = await _dbContext.Users.FirstOrDefaultAsync(u => u.Username == username);

        if (userEntity == null)
        {
            return null;
        }

        return MapUserEntityToModel(userEntity);
    }

    private UserModel MapUserEntityToModel(UserEntity userEntity)
    {
        return new UserModel
        {
            // Map UserEntity properties to UserModel properties
            UserId = userEntity.UserId,
            FirstName = userEntity.FirstName,
            LastName = userEntity.LastName,
            Username = userEntity.Username,
            Age = userEntity.Age,
            Email = userEntity.Email,
            MonthlyIncome = userEntity.MonthlyIncome,
            IsBlocked = userEntity.IsBlocked,
            HashedPassword = userEntity.HashedPassword,
            // Map other properties as needed
        };
    }

}

