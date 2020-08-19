package shamim.hamburgers;
//import java.util.Arrays;
import java.util.Scanner;
/**
 *
 * @author Zhe Krunal
 */

public class HamburgerMain extends InsertData{

    public static void main(String[] args) {
        CreateTables();        
        System.out.println("          ####################################");
        System.out.println("          #    Welcome To Shamim Hamburger   #");
        System.out.println("          ####################################\n");
        System.out.println("Please Choose Hamburger Type : \n");
        System.out.println("1. Basic Hamburger  2. Healthy Hamburger  3. Deluxe Hamburger");

        Scanner input = new Scanner(System.in);
        double price = 0;
        
        String[] item3 = {"Tomato", "Lettuce", "Cheese", "Carrot", "Exit"};
        int i = input.nextInt();
        switch (i) {
            case 1:
                Hamburger basic = new Hamburger("Basic", "White roll ", "Sausage", 3.56);
                basic.TypeOfHamburger();
                System.out.println("--------------------------------------------------------------------");
                basic.set_item(item3);
                
                price = basic.Addprice(basic.AddItems());
               
                System.out.println("\nPrice of Additons is :" + price);
                System.out.printf("Basic price is :%.2f \n", basic.get_basicprice());
                System.out.printf("Total Price is :%.2f \n", basic.TotalPrice(price));
                
                ForOrder_Insert(basic.get_hamburgername(), basic.get_breadtype(), basic.get_meattype(),
                        basic.get_basicprice() ,BasicHamburger_Insert(basic.AddItems()), basic.TotalPrice(price));
                break;
            case 2:
                HealthyHamburger Healthy = new HealthyHamburger("Healthy", "Brown rye roll", "Bacon", 5.67);
                Healthy.TypeOfHamburger();
                System.out.println("--------------------------------------------------------------------");
                price = Healthy.Addprice(Healthy.AddItems());
                System.out.println("\nPrice of Additons is : " + price);
                
                System.out.printf("Basic price is :%.2f " , Healthy.get_basicprice());
                System.out.printf("Total Price is :%.2f \n", Healthy.TotalPrice(price));
               
                ForOrder_Insert(Healthy.get_hamburgername(), Healthy.get_breadtype(), Healthy.get_meattype(),
                        Healthy.get_basicprice(), HealthlyHamburger_Insert(Healthy.AddItems()), Healthy.TotalPrice(price));
                break;
            case 3:
                Hamburger Deluxe = new DeluxeHamburger("Deluxe ", "White roll ", "Sausage & Bacon", 14.54);
                Deluxe.TypeOfHamburger();
                System.out.println("--------------------------------------------------------------------");
                price = Deluxe.Addprice(Deluxe.AddItems()); 
                
                System.out.printf("\nPrice of Additons is :%.2f \n", price);
                System.out.printf("Basic price is :%.2f \n" , Deluxe.get_basicprice());
                System.out.printf("Total Price is :%.2f \n", Deluxe.TotalPrice(price));
                
              
                ForOrder_Insert(Deluxe.get_hamburgername(), Deluxe.get_breadtype(), Deluxe.get_meattype(),
                        Deluxe.get_basicprice(), DeluxeHamburger_Insert(Deluxe.AddItems()), Deluxe.TotalPrice(price));
                break;                                    

        }

    }

    

}

