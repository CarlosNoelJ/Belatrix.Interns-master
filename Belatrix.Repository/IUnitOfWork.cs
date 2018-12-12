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

        IRepository<Album> Album { get; }

        IRepository<Customer> Customer { get; }

        IRepository<Employee> Employee { get; }

        IRepository<Invoice> Invoice { get; }

        IRepository<InvoiceLine> InvoiceLine { get; }

        IRepository<MediaType> MediaType { get; }

        IRepository<PlaylistTrack> PlaylistTrack { get; }

        IRepository<Track> Track { get; }
    }
}       