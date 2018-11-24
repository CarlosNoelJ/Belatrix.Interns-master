namespace Belatrix.Repository.SqlServer
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ChinookContext dbContext)
        {
            Genres = new GenreRepository(dbContext);
            Artists = new ArtistRepository(dbContext);
        }
        public IGenreRepository Genres { get; }

        public IArtistRepository Artists { get; }
    }
}
