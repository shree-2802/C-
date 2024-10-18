public class User
{
    public string Profile { get; }
    public User(string profile)
    {
        if (this.Profile == null)
        {
            this.Profile = profile;
        }
    }
}