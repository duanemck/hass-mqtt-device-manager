using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class HomeAssistantDeviceContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }
        public DbSet<Entity> Entities { get; set; }

        private string DbPath { get; }

        public HomeAssistantDeviceContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "ha_mqtt_device_manager.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
    }
}
