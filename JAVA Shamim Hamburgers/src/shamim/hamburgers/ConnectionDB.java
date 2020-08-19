/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package shamim.hamburgers;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
/**
 *
 * @author Zhe
 */
public class ConnectionDB {
    
    public static Connection connectDB(){        
        Connection conn = null;
        try{  
            String url = "jdbc:sqlite: HamburgerDB.db ";
            conn = DriverManager.getConnection(url);
            //System.out.println("Connected database successfully!");             
        }
        catch(SQLException e){
            System.out.println(e.getMessage());
        }
        return conn;
    }
}
