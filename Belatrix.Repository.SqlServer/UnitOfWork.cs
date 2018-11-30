using Belatrix.Models;

namespace Belatrix.Repository.SqlServer
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ChinookContext dbContext)
        {
            //Genres = new GenreRepository(dbContext);
            Artists = new Repository<Artist>(dbContext);
            Playlist = new Repository<Playlist>(dbContext);
            Genres = new Repository<Genre>(dbContext);
        }
        
        public IRepository<Playlist> Playlist { get; }

        public IRepository<Artist> Artists { get; }

        public IRepository<Genre> Genres { get; }

        //public IGenreRepository Genre {get;}
    }
}
