namespace BOL;
public class Product{
    public int pid{get;set;}
    public string pname{get;set;}
    public int price{get;set;}
    public int qty{get;set;}
    public Product(int pid, string pname, int price, int qty){
        this.pid = pid;
        this.pname = pname;
        this.price = price;
        this.qty = qty;
    }
}