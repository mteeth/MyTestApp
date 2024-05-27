using System;
using MyTestApp;
namespace MyTestApp{

public class Inventory
{
   public List<Item>Items {get; set;}
    public Inventory()
    {
        Items = new List<Item>();
    }
public void addItem(Item item){
    Items.Add(item);
    Console.WriteLine($"Added: {item.Name}");
}
public void deleteItem(int itemId){
    Item deletedItem=Items.Find(item=>item.ID==itemId);
    if(deletedItem!=null){
    Items.Remove(deletedItem);
    Console.WriteLine($"Removed: {deletedItem.Name}");
    }
    else{
        Console.WriteLine("Item not found");
    }
}

public void displayItems(){
if (Items.Count == 0)
            {
                Console.WriteLine("No items in the inventory.");
                return;
            }

            foreach (Item item in Items)
            {
                Console.WriteLine($"(Name):{item.Name} (Description):{item.Description} (Price):{item.Price} (ID):{item.ID} (Amount):{item.Amount} ");
            }
}



public string Menu()
{
    Console.WriteLine("1.Create an Item");
    Console.WriteLine("2.Update Item ");
    Console.WriteLine("3.Delete Item");
    Console.WriteLine("4.Display inventory");
    string choice= Console.ReadLine();
    return choice;
}

public void updateItem(int itemID){
    Item updatedItem=Items.Find(item=>item.ID==itemID);
    if(updatedItem!=null){
        Console.WriteLine("1.Update Item Name");
    Console.WriteLine("2.Update Item Description");
    Console.WriteLine("3.Update Item Price");
    Console.WriteLine ("4.Update Item ID");
    Console.WriteLine("5.Update Item Amount");
    string ans= Console.ReadLine();

    switch(ans){
        case "1":
        Console.WriteLine("Enter New Name:");
        updatedItem.Name=Console.ReadLine();
        Console.WriteLine("Item Updated");
        break;
        case "2":
        Console.WriteLine("Enter New Item Description:");
        updatedItem.Description=Console.ReadLine();
        Console.WriteLine("Item Updated");
        break;
        case "3":
        Console.WriteLine("Enter New Item Price:");
        updatedItem.Price=float.Parse(Console.ReadLine());
        Console.WriteLine("Item Updated");
        break;
        case"4":
        Console.WriteLine("Enter New  Item ID Number:");
        updatedItem.ID=int.Parse(Console.ReadLine());
        Console.WriteLine("Item Updated");
        break;
        case "5":
        Console.WriteLine("Enter New Item Amount:");
        updatedItem.Amount=int.Parse(Console.ReadLine());
        Console.WriteLine("Item Updated");
        break;
    }
    
    }
    
    
    
}
}// end of class 




}