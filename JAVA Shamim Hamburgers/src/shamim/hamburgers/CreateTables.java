/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package shamim.hamburgers;
import java.sql.Connection;
import java.sql.SQLException;
import java.sql.Statement;
/**
 *
 * @author Zhe
 */
public class CreateTables extends ConnectionDB{
    
    public static void CreateTables(){
        try{
            Connection conn =connectDB();
            Statement statement = conn.createStatement();
            
            statement.execute("create table if not exists BasicHamburger "
                    + "(item1 Text, item2 Text, item3 Text, item4 Text ,B_Id Integer primary key)");
            
            statement.execute("create table if not exists HealthHamburger "
                    + "(item1 Text, item2 Text, item3 Text, item4 Text, item5 Text, item6 Text,"
                    + "H_Id Integer primary key )");
            
            statement.execute("create table if not exists DeluxeHamburger "
                    + "(item1 Text, item2 Text, D_Id Integer primary key)");
            
            statement.execute("create table if not exists HamburgerOrder"
                    + "(OrderId Integer primary key, HamburgerType Text, BreadType Text,"
                    + " MeatType Text, BasePrice Real, AdditionItems Text, Final_Price Real )");
            
            System.out.println("Table create successfully!");
            statement.close();            
            conn.close(); 
            }
        catch (SQLException e) {
            System.out.println(" Error: " + e.getMessage());
        }
    }
    
}
