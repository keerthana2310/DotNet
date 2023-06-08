using ProductMicroservice.Model;

namespace ProductMicroservice.Repository
{
    interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductByID(int id);


        void InsertProduct (Product Product);
       
        void DeleteProduct (int ProductId);
        void UpdateProduct(Product Product);
        
        void Save();

    }
}
