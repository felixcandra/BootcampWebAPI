using BusinessLogic.Service;
using DataAccess.Context;
using DataAccess.Model;
using DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Bootcamp.API.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods: "*" )]
    public class SuppliersController : ApiController
    {
        private readonly iSupplierService _supplierService;
        public SuppliersController(iSupplierService supplierService)
        {
            _supplierService = supplierService;
        }
        
        MyContext myContext = new MyContext();
        // GET: api/Suppliers
        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _supplierService.Get();
        }

        // GET: api/Suppliers/5
        public Supplier Get(int? id)
        {
            return _supplierService.Get(id);
        }

        // POST: api/Suppliers
        public void Post(SupplierParam supplierParam)
        {
            _supplierService.insert(supplierParam);
        }

        // PUT: api/Suppliers/5
        public void Put(int? id, SupplierParam supplierParam)
        {
            _supplierService.update(id, supplierParam);
        }

        // DELETE: api/Suppliers/5
        public void Delete(int? id)
        {
            _supplierService.delete(id);
        }
    }
}
