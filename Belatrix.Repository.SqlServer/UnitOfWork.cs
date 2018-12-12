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
            Album = new Repository<Album>(dbContext);
            Customer = new Repository<Customer>(dbContext);
            Employee = new Repository<Employee>(dbContext);
            Invoice = new Repository<Invoice>(dbContext);
            InvoiceLine = new Repository<InvoiceLine>(dbContext);
            MediaType = new Repository<MediaType>(dbContext);
            PlaylistTrack = new Repository<PlaylistTrack>(dbContext);
            Track = new Repository<Track>(dbContext);
        }
        
        public IRepository<Playlist> Playlist { get; }

        public IRepository<Artist> Artists { get; }

        public IRepository<Genre> Genres { get; }

        public IRepository<Album> Album { get; }

        public IRepository<Customer> Customer { get; }

        public IRepository<Employee> Employee { get; }

        public IRepository<Invoice> Invoice { get; }

        public IRepository<InvoiceLine> InvoiceLine { get; }

        public IRepository<MediaType> MediaType { get; }

        public IRepository<PlaylistTrack> PlaylistTrack { get; }

        public IRepository<Track> Track { get; }

        //public IGenreRepository Genre {get;}
    }
}
