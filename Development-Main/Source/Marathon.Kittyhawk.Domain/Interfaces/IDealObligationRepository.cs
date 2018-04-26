using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the deal obligation repository.
    /// </summary>
    public interface IDealObligationRepository : IRepository<DealObligation>
    {
        DealObligation GetByDealHeaderKeyDealDetailKeyAndObligationId(int dealHeaderKey, int dealDetailKey, int obligationId);
    }
}



