
namespace MealVote.Api
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string AccountsCollectionsName { get; set; }
        public string ProfilesCollectionsName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IDatabaseSettings
    {
        public string AccountsCollectionsName { get; set; }
        public string ProfilesCollectionsName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
