using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using DataAccess.Param;
using Common.Interface;
using Common.Interface.Master;

namespace BusinessLogic.Service.Master
{
    public class SupplierService : iSupplierService
    {
        private readonly iSupplierRepository _supplierRepository;
        public SupplierService(iSupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public bool delete(int? id)
        {
            if (string.IsNullOrEmpty(id.ToString()) == true){
                Console.WriteLine("id must not be empty");
                Console.Read();
                return false;
            }
            else
            {
                return _supplierRepository.delete(id);
            }
            
        }

        public List<Supplier> Get()
        {
            return _supplierRepository.Get();
        }

        public Supplier Get(int? id)
        {
            if (string.IsNullOrEmpty(id.ToString()) == true)
            {
                Console.WriteLine("id must not be empty");
                Console.Read();
                return null; // aku ngga tau retun apa
            }
            else
            {
                return _supplierRepository.Get(id);
            }
        }

        public bool insert(SupplierParam supplierParam)
        {
            return _supplierRepository.insert(supplierParam);
        }

        public bool update(int? id, SupplierParam supplierParam)
        {
            if (string.IsNullOrEmpty(id.ToString()) == true)
            {
                Console.WriteLine("id must not be empty");
                Console.Read();
                return false;
            }
            else
            {
                return _supplierRepository.update(id, supplierParam);
            }
        }
    }
}
