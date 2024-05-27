using System;
using MyTestApp;
namespace MyTestApp{
    public class Cart{
        public List<Item>Carts{ get; set; }
        private Inventory theInventory;
        
        public Cart(Inventory inventory){
            Carts = new List<Item>();
            theInventory=inventory;
        }

        public void addToCart(string name){
            Item wantedItem=theInventory.Items.Find(item=>item.Name==name);
            if(wantedItem!=null){
                Console.WriteLine("Enter the amount you would like to purchase:");
                int amount=int.Parse(Console.ReadLine());
                if(wantedItem.Amount>=amount){
                    Carts.Add(new Item{
                        Name = wantedItem.Name,
                        Description=wantedItem.Description,
                        ID=wantedItem.ID,
                        Price=wantedItem.Price,
                        purchasedAmount=amount,
                    });   
                     Console.WriteLine("Item added to cart");
                    wantedItem.Amount-=amount;
                }
                else{
                    Console.WriteLine("Not enough items");
                }
                }
                else{
                Console.WriteLine("No Items Found");
            }
    
            }
            
        

        public void deleteFromCart(string name){
            Item removedItem=Carts.Find(item=>item.Name== name);
            if(removedItem!=null){
                Item invItem=theInventory.Items.Find(item=>item.Name== name);
                invItem.Amount+=removedItem.purchasedAmount;
                Carts.Remove(removedItem);
                Console.WriteLine("Item Deleted");
                
            }
            else{
                Console.WriteLine("No Item Found");
            }
        }

        public void displayCart(){
            if(Carts.Count==0){
                Console.WriteLine("Cart Empty");
            }
            else{
                 foreach (Item item in Carts)
            {
                Console.WriteLine($"(Name):{item.Name} (Description):{item.Description} (Price):{item.Price} (ID):{item.ID} (Amount):{item.purchasedAmount} ");
            }
            }
        }

        public void getReceipt(){
            Console.WriteLine("RECEIPT");
            Console.WriteLine("---------------------");
            float sTotal=0;

            if(Carts.Count==0){
                Console.WriteLine("Cart Is Empty");
            }
            float total=0;
            foreach(Item item in Carts){
               float iTotal=item.Price*item.purchasedAmount;
               sTotal+=iTotal;
               Console.WriteLine($"Name): {item.Name}, Price: {item.Price}, Purchased Amount: {item.purchasedAmount}, Total: {iTotal}");
            }
            Console.WriteLine("----------------------------");
            float tax=sTotal*0.07f;
            total=sTotal+tax;
            Console.WriteLine($"Subtotal: {sTotal}");
            Console.WriteLine($"Tax Deduction(7%): {tax}");
            Console.WriteLine($"Total: {total}");
            Carts.Clear();

        }

        public string Menu(){
            Console.WriteLine("1.Add Item To Cart");
            Console.WriteLine("2.Delete Item From Cart");
            Console.WriteLine("3.Display Cart");
            Console.WriteLine("4.Checkout");
            string choice=Console.ReadLine();
            return choice;
            
        }

    }
}


