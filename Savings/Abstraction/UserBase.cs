using Savings.Model;
using System.Text.Json;
namespace Savings.Abstraction;

public class UserBase
{
    protected static readonly string FilePath = Path.Combine(FileSystem.AppDataDirectory, "User.json");

    protected List<User> LoadUsers()
    {
        if (!File.Exists(FilePath)) return new List<User>();
        var json = File.ReadAllText(FilePath);
        return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
    }

    protected void SaveUsers(List<User> users)
    {
        var json = JsonSerializer.Serialize(users);
        File.WriteAllText(FilePath, json);
    }
}
