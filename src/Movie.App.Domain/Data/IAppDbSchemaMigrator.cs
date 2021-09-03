using System.Threading.Tasks;

namespace Movie.App.Data
{
    public interface IAppDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
