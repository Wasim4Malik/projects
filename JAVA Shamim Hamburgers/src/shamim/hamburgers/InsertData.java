/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package shamim.hamburgers;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;
/**
 *
 * @author Zhe
 */
public class InsertData extends CreateTables{
    
    public static String BasicHamburger_Insert(String[] BasicA){
            
        String Detail =null;
        try{               
             Connection conn =connectDB();             
             String sql = "insert into BasicHamburger(item1, item2, item3, item4)"
                            + " values(?,?,?,?) ";
             PreparedStatement prep = conn.prepareStatement(sql);
                    prep.setString(1, BasicA[0]);
                    prep.setString(2, BasicA[1]);
                    prep.setString(3, BasicA[2]);
                    prep.setString(4, BasicA[3]);
                    prep.addBatch();

            conn.setAutoCommit(false);
            prep.executeBatch();
            conn.commit();
            conn.setAutoCommit(true);
            
            System.out.println("insert into BasicHamburger successfully!");
            Detail= BasicA[0] + "," + BasicA[1] + "," + BasicA[2] + "," +
                    "," + BasicA[3];
            prep.close();            
            conn.close(); 
        }   
        catch (SQLException e) {
            System.out.println(" Error: " + e.getMessage());
        }
        return Detail;
    }
//function insert into database Health_Hamburger     
    public static String HealthlyHamburger_Insert(String[] HealthA){
        
        String Detail =null;
        try{  
             Connection conn =connectDB();             
             String sql = "insert into HealthHamburger(item1, item2, item3,"
                     + " item4, item5, item6) values(?,?,?,?,?,?) ";
             PreparedStatement prep = conn.prepareStatement(sql);
                    prep.setString(1, HealthA[0]);
                    prep.setString(2, HealthA[1]);
                    prep.setString(3, HealthA[2]);
                    prep.setString(4, HealthA[3]);
                    prep.setString(5, HealthA[4]);
                    prep.setString(6, HealthA[5]);
                    prep.addBatch();

            conn.setAutoCommit(false);
            prep.executeBatch();
            conn.commit();
            conn.setAutoCommit(true);
            
            System.out.println("insert into HealthHamburger successfully!");
            Detail= HealthA[0] + "," + HealthA[1] + "," + HealthA[2] + "," +
                    "," + HealthA[3] +"," + HealthA[4] + "," + HealthA[5];
                    
            prep.close();            
            conn.close(); 
        }   
        catch (SQLException e) {
            System.out.println(" Error: " + e.getMessage());
        }
        return Detail;
    }
//function insert into database Deluxe_Hamburger       
    public static String DeluxeHamburger_Insert(String[] DeluxeA){
        
        String Detail =null;
        try{  
             Connection conn =connectDB();             
             String sql = "insert into DeluxeHamburger(item1, item2) values(?,?) ";
             PreparedStatement prep = conn.prepareStatement(sql);
                    prep.setString(1, DeluxeA[0]);
                    prep.setString(2, DeluxeA[1]);
                    prep.addBatch();

            conn.setAutoCommit(false);
            prep.executeBatch();
            conn.commit();
            conn.setAutoCommit(true);
            
            System.out.println("insert into DeluxeHamburger successfully!");
            Detail= DeluxeA[0] + "," + DeluxeA[1];
            prep.close();            
            conn.close(); 
        }   
        catch (SQLException e) {
            System.out.println(" Error: " + e.getMessage());
        }
        return Detail;
    }
    
//function insert into database Hamburger_Sell_Record     
    public static void ForOrder_Insert(String Hamburger_Type, String Bread_Type, String Meat_Type,
            double Base_Price, String AdditionItems, double Total_Price)
    {
        try{  
             Connection conn =connectDB();             
             String sql = "insert into HamburgerOrder (HamburgerType, BreadType,"
                     + " MeatType, BasePrice, AdditionItems, Final_Price) values(?,?,?,?,?,?) ";  
             PreparedStatement prep = conn.prepareStatement(sql);
                    prep.setString(1, Hamburger_Type);
                    prep.setString(2, Bread_Type);
                    prep.setString(3, Meat_Type);
                    prep.setDouble(4, Base_Price);
                    prep.setString(5, AdditionItems);
                    prep.setDouble(6, Total_Price);
                    prep.addBatch();

            conn.setAutoCommit(false);
            prep.executeBatch();
            conn.commit();
            conn.setAutoCommit(true);
            
            System.out.println("insert into HamburgerOrder successfully!");
            prep.close();            
            conn.close(); 
        }   
        catch (SQLException e) {
            System.out.println(" Error: " + e.getMessage());
        }
    }
}
