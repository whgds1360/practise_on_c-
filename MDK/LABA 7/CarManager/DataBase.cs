using Microsoft.EntityFrameworkCore;

namespace CarManager
{
    public class ApplicationContext : DbContext
    {
        private string Port;
        private string Host;
        private string DataBaseName;
        private string UserName;
        private string Password;

        public DbSet<Car> Cars { get; set; }
        public ApplicationContext(string port, string host, string dbname, string username, string password)
        {
            Port = port;
            Host = host;
            DataBaseName = dbname;
            UserName = username;
            Password = password;
        }
        public void Ensure()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql($"Host={Host};Port={Port};Database={DataBaseName};Username={UserName};Password={Password}");
        }
    }
}
