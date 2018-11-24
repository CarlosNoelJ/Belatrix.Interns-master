namespace Belatrix.Repository
{
    public interface IUnitOfWork
    {
        IGenreRepository Genres { get; }

        IArtistRepository Artists { get; }
    }
}
