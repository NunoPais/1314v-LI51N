using System.Collections.Generic;
using System.Linq;

namespace Isel.ChelasNote
{
    public class NotesRespository
    {
        private static List<Note> _Notes;


        static NotesRespository() {
            _Notes = new List<Note>()
            {
                new Note {Id = 1, Title = "Note1", Body = "Body1"},
                new Note {Id = 2, Title = "Note2", Body = "Body1"},
                new Note {Id = 3, Title = "Note3", Body = "Body1"},
                new Note {Id = 4, Title = "Note4", Body = "Body1"},
            };
        }

        public NotesRespository()
        {
        }

        public IEnumerable<Note> GetAll()
        {
            return _Notes;
        }

        public Note Get(int id)
        {
            return _Notes.Single(n => n.Id == id);
        }
    }
}