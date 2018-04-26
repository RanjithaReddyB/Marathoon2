using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the business associate repository.
    /// </summary>
    public interface IBusinessAssociateRepository : IRepository<BusinessAssociate>
    {
        BusinessAssociate GetBySRAID(int ID);
        BusinessAssociate GetByName(string name);
        BusinessAssociate GetBySapCustomer(string sapCustomer);
        BusinessAssociate GetBySupplierId(string refLoc);
		BusinessAssociate GetByScac(string scac);
        BusinessAssociate GetByContractCode(string contractCode);
        BusinessAssociate GetBySapCustomerOrSupplierIdOrScacOrContractCode(string code);
    }
}
