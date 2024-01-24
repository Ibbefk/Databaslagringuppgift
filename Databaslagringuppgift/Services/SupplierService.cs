using Databaslagringuppgift.Repositories;
using Databaslagringuppgift.Tables;
using System;
using System.Collections.Generic;

namespace Databaslagringuppgift.Services
{
    internal class SupplierService
    {
        private readonly SupplierRepository _supplierRepository;

        public SupplierService(SupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository ?? throw new ArgumentNullException(nameof(supplierRepository));
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _supplierRepository.GetAllSuppliers();
        }

        public Supplier GetSupplierById(int supplierId)
        {
            return _supplierRepository.GetSupplierById(supplierId);
        }

        public void AddSupplier(Supplier supplier)
        {
            _supplierRepository.AddSupplier(supplier);
        }

        public void UpdateSupplier(Supplier supplier)
        {
            _supplierRepository.UpdateSupplier(supplier);
        }

        public void DeleteSupplier(int supplierId)
        {
            _supplierRepository.DeleteSupplier(supplierId);
        }
    }
}
