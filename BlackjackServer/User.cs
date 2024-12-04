using Realms;

namespace BlackjackServer;

public class User : RealmObject
{
    [PrimaryKey]
    public string Username { get; set; } = null!;
    public byte[] SaltedPasswordHash { get; set; } = null!;
    public byte[] PasswordSalt { get; set; } = null!;
    public int RankRating { get; set; } = 0;
    public int GamesPlayed { get; set; } = 0;
    public bool IsRestricted { get; set; } = false;
    public bool IsAdministrator { get; set; } = false;
}