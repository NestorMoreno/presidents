using System.Collections.Generic;
using DTO;

namespace DAL.Presidents
{
    public class PresidentRepository : IRepository<President>
    {
        ConsumeAPI api;

        public PresidentRepository()
        {
            api = new ConsumeAPI();
        }

        public List<President> GetAll()
        {
            return api.GetPresidents();
        }
    }
}
