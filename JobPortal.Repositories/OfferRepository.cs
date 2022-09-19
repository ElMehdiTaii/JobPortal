using JobPortal.Contracts;
using JobPortal.Entities.Models;

namespace JobPortal.Repositories
{
    public class OfferRepository : RepositoryBase<Offer>, IOfferRepository
    {
        public OfferRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
