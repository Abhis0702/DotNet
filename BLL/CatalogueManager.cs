namespace BLL;
using BOL;
using DAL.Connected;
public class CatalogueManager{
    public List<Product> GetAllProducts(){
        List<Product> allproducts = new List<Product>();
        allproducts = DBManager.GetAllProducts();
        return allproducts;
    }
}