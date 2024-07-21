using Notes.Domain.Enum;

namespace Notes.Domain.Entity
{
    public class NoteEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Priority Priority { get; set; }
    }
}
