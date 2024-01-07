using System;
using MySql.Data.Client;
class Program{
    static void Main(){
        string connectingstring = "SERVER=localhost;DATABASE=BCA;UID=root;PASSWORD=;";
        MySqlConnection conn= new MySqlConnection(connectingstring);
        conn.Open();
        MySqlCommand cmd = new MySqlCommand();
        string query="CREATE TABLE IF NOT EXISTS Student(roll INT, name VARCHAR(50),address VARCHAR(50));";
        cmd.ExecuteNonQuery(query,conn);
        Console.WriteLine("Table Created Successfully");
        string insert = "INSERT INTO STUDENT VALUES(100,'Santosh Bhandari','Kanakai');";
        cmd.ExecuteNonQuery(insert,conn);
        Console.WriteLine("Data Inserted Successfully");
        conn.Close();

    }
}