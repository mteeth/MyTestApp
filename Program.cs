using System;
using MyTestApp;

namespace MyTestApp{


public  class Program{
public static void Main(string[] args)
{
    
    Inventory myInventory= new Inventory();
    Cart myCart= new Cart(myInventory);
    bool flag=false;
    while(!flag){
Console.WriteLine("1.Inventory Management");
Console.WriteLine("2.Shop");
Console.WriteLine("3.Exit");


string inp =Console.ReadLine();


switch (inp)
{
    case "1":
    string inp2=myInventory.Menu();
    switch (inp2){
        case "1":
        Item newItem=new Item();
        Console.WriteLine("Enter Name:");
        newItem.Name = Console.ReadLine();
        Console.WriteLine("Enter Description:");
        newItem.Description = Console.ReadLine();
        Console.WriteLine("Enter Price:");
        newItem.Price = float.Parse (Console.ReadLine());
        Console.WriteLine("Enter ID:");
        newItem.ID =int.Parse (Console.ReadLine());
        Console.WriteLine ("Enter Amount:");
        newItem.Amount = int.Parse (Console.ReadLine());
        myInventory.addItem(newItem);
        break;
        case "2":
        Console.WriteLine("Enter ID number of item you would like to update:");
        int uID=int.Parse (Console.ReadLine());
        myInventory.updateItem(uID);
        break;
        case "3":
        Console.WriteLine("Enter the ID number of the item you would like to delete:");
        int ID=int.Parse(Console.ReadLine());
        myInventory.deleteItem(ID);
        break;
        case "4":
        myInventory.displayItems();
        break;
        default:
        flag=true;
        break;
    }
    break;

    case "2":
   string inp4=myCart.Menu();
        switch (inp4){
            case "1":
            Console.WriteLine("Enter Item Name:");
            string bItem=Console.ReadLine();
            myCart.addToCart(bItem);
            break;
            case"2":
            Console.WriteLine("Enter The Name Of The Item You Would Like To Delete:");
            string dItem=Console.ReadLine();
            myCart.deleteFromCart(dItem);
            break;
            case"3":
            myCart.displayCart();
            break;
            case"4":
            myCart.getReceipt();
            break;
        }
    break;
    case "3":
    flag=true;
    break;
    default:
    break;
}
  

  }

}
}




}


