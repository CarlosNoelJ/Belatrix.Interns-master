using Belatrix.Models;

namespace Belatrix.Repository
{
    public interface IUnitOfWork
    {
        //IGenreRepository Genres { get; }

        //IArtistRepository Artists { get; }

        IRepository<Playlist> Playlist { get; }

        IRepository<Artist> Artists { get; }

        IRepository<Genre> Genres { get; }
    }
}
