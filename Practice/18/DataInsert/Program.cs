using MySql.Data.MySqlClient;
class Program{
    static void Main(){
        string connection ="SERVER=localhost;DATABASE=BCA;UID=root;PASSWORD=;";
        MySqlConnection conn = new MySqlConnection(connection);
        conn.Open();
        string query = "INSERT INTO Student VALUES(101,'Aryan','Kanakai";
        MySqlCommand cmd = new MySqlCommand(query,conn);
        cmd.ExecuteNonQuery();
        Console.WriteLine("Data Inserted");
        conn.Close();
    }
}