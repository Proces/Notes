
namespace Notes.Persistance
{
    internal class DbInitializer
    {
        public static void Initialize(NotesDbContext context) 
        {
            context.Database.EnsureCreated();
        }
    }
}
