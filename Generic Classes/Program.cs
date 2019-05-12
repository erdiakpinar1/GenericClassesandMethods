using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //class Product : IProduct
    //{
    //    public void Add(Product product)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(Product product)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Product Get(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public List<Product> GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(Product product)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //class Customer : ICustomer
    //{
    //    public void Add(Customer customer)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(Customer customer)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Customer Get(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public List<Customer> GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(Customer customer)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //class Supplier : ISupplier
    //{
    //    public void Add(Supplier supplier)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(Supplier supplier)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Supplier Get(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public List<Supplier> GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(Supplier supplier)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //class Shipment : IShipment
    //{
    //    public void Add(Shipment shipment)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(Shipment shipment)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Shipment Get(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public List<Shipment> GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(Shipment shipment)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //interface IProduct
    //{
    //    List<Product> GetAll(); // 
    //    Product Get(int id); // Product Döndüren nesne
    //    void Add(Product product); 
    //    void Delete(Product product);
    //    void Update(Product product);
    //}
    //interface ICustomer
    //{
    //    List<Customer> GetAll();
    //    Customer Get(int id);
    //    void Add(Customer customer);
    //    void Delete(Customer customer);
    //    void Update(Customer customer);
    //}
    //interface ISupplier
    //{
    //    List<Supplier> GetAll();
    //    Supplier Get(int id);
    //    void Add(Supplier supplier);
    //    void Delete(Supplier supplier);
    //    void Update(Supplier supplier);
    //}
    //interface IShipment
    //{
    //    List<Shipment> GetAll();
    //    Shipment Get(int id);
    //    void Add(Shipment shipment);
    //    void Delete(Shipment shipment);
    //    void Update(Shipment shipment);
    //}
    //****************************************************************
    //  Generic class

    interface IRepository<T>
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T data);
        void Delete(T data);
        void Update(T data);
    }

    interface IProductDAL  : IRepository<Product>
    {
        void Quantity (Product data);
    }
    interface ICustomerDAL : IRepository<Customer>  {}
    interface ISupplierDAL : IRepository<Supplier>  {}
    interface IShipmentDAL : IRepository<Shipment>  {}

    class Product : IProductDAL
    {
        public void Add(Product data)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product data)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Quantity(Product data)
        {
            throw new NotImplementedException();
        }

        public void Update(Product data)
        {
            throw new NotImplementedException();
        }
    }

    class Customer : ICustomerDAL
    {
        public void Add(Customer data)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer data)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer data)
        {
            throw new NotImplementedException();
        }
    }
    class Supplier : ISupplierDAL
    {
        public void Add(Supplier data)
        {
            throw new NotImplementedException();
        }

        public void Delete(Supplier data)
        {
            throw new NotImplementedException();
        }

        public Supplier Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Supplier data)
        {
            throw new NotImplementedException();
        }
    }
    class Shipment : IShipmentDAL
    {
        public void Add(Shipment data)
        {
            throw new NotImplementedException();
        }

        public void Delete(Shipment data)
        {
            throw new NotImplementedException();
        }

        public Shipment Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Shipment> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Shipment data)
        {
            throw new NotImplementedException();
        }
    }

}
