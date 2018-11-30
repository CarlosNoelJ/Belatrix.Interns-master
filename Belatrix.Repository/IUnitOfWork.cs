namespace Belatrix.Repository
{
    public interface IUnitOfWork
    {
//        GenreRepository = new GenreRepository()

        IGenreRepository Genres { get; }

        IArtistRepository Artists { get; }
    }
}
