using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using DataAccess.Param;
using DataAccess.Context;

namespace Common.Interface.Master
{
    public class SupplierRepository : iSupplierRepository
    {
        MyContext myContext = new MyContext();
        SupplierParam supplierParam = new SupplierParam();
        Supplier supplier = new Supplier();
        bool status = false;
        public bool delete(int? id)
        {
            var result = 0;
            Supplier suppliers = Get(id);
            suppliers.isDelete = true;
            suppliers.DeleteDate = DateTimeOffset.Now.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<Supplier> Get()
        {
            var getAll = myContext.Suppliers.Where(x => x.isDelete == false).ToList();
            return getAll;
        }

        public Supplier Get(int? id)
        {
            var get = myContext.Suppliers.Find(id);
            return get;
        }

        public bool insert(SupplierParam supplierParam)
        {
            var result = 0;
            supplier.Name = supplierParam.Name;
            supplier.JoinDate = DateTimeOffset.Now.LocalDateTime;
            supplier.CreateDate = DateTimeOffset.Now.LocalDateTime;
            supplier.isDelete = false;
            myContext.Suppliers.Add(supplier);
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool update(int? id, SupplierParam supplierParam)
        {
            var result = 0;
            Supplier suppliers = Get(id);
            suppliers.Name = supplierParam.Name;
            suppliers.UpdateDate = DateTimeOffset.Now.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
