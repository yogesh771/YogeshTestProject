using DatayogeshwarTestProjectData.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yogeshwarTestProjectData.Repositories;
using yogeshwarTestProjectModel;

namespace yogeshwarTestProjectServices
{
    public interface INotesServices
    {
        IEnumerable<TblNote> GetAllNotesByUserId(int userId);
        TblNote GetNotesByNoteId(int noteId);
        void AddNote(TblNote tblNote);
        void Update(TblNote tblNote);
        void SaveNotes();
    }
    public class NotesServices : INotesServices
    {
        private readonly INotesRepository notesRepository;
        private readonly IUnitOfWork unitOfWork;

        public NotesServices(INotesRepository _notesRepository , IUnitOfWork _unitOfWork)
        {
            this.notesRepository = _notesRepository;
            this.unitOfWork = _unitOfWork;
        }

        public void AddNote(TblNote tblNote)
        {
            notesRepository.Add(tblNote);
        }

        public IEnumerable<TblNote> GetAllNotesByUserId(int userId)
        {
            return notesRepository.GetAll();
        }

        public TblNote GetNotesByNoteId(int noteId)
        {
            return notesRepository.GetById(noteId);
        }
       
        public void Update(TblNote tblNote)
        {
            throw new NotImplementedException();
        }

        public void SaveNotes()
        {
            unitOfWork.Commit();
        }


    }
}
