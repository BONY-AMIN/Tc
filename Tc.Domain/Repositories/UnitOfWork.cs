using Tc.Domain.Models;

namespace Tc.Domain.Repositories
{
    public class UnitOfWork
    {
        private TcContext  _db;

        public UnitOfWork()
        {
            this._db = new TcContext();
        }

        public void Save() => _db.SaveChanges();

        public  IRepository<Voter> VoterRepo;

        public IRepository<Voter> VoterRepository
        {
            get
            {
                if (this.voterRepo == null)
                {
                    this.voterRepo = new Repository<Voter>(_db);
                }
                return voterRepo;
            }
        }

       

      

   
      

        

    }
}
