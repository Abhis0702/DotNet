namespace DAL.Connected;
using BOL;
using MySql.Data.MySqlClient;
public class DBManager{
    public static string connectionstring = @"server=localhost;port=3306;user=root;password=hello;database=demo";

    public static List<Product> GetAllProducts(){
        List<Product> list = new List<Product>();
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = connectionstring;
        string query = "select * from products";
        MySqlCommand command = new MySqlCommand(query, connection);
        try{
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read()){
              
                int id = int.Parse(reader["prod_id"].ToString());
                string name = reader["prod_name"].ToString();
                int up = int.Parse(reader["unit_price"].ToString());
                int qty = int.Parse(reader["quantity"].ToString());
              
                list.Add(new Product(id,name,up,qty));
            }
        
            reader.Close();
        }

        // }catch(Exception e){
        //     Console.WriteLine(e.message);
        // }
        finally{
            connection.Close();
        }
        return list;
    }
}