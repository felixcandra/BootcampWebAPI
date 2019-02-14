using DataAccess.Model;
using DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interface
{
    public interface iSupplierRepository
    {
        bool insert(SupplierParam supplierParam);
        bool update(int? id, SupplierParam supplierParam);
        bool delete(int? id);
        List<Supplier> Get();
        Supplier Get(int? id);
    }
}
