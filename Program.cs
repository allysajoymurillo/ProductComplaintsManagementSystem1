using System;
using System.Linq;

namespace ProductComplaintsManagementSystem
{
class Program
{
static void Main(string[] args)
        {
         string productName = GetComplains(new[] {“Blossoms Baby”});
         Console.WriteLine($”Complains Product Name: ‘{productName}’”);
         string productBrand = GetComplains(“Johnson’s”);
         Console.WriteLine($”Complains Product Brand: ‘{productBrand}’”);
         string productCode = GetComplains(“4801010105107”);
         Console.WriteLine($”Complains Product Code: ‘{productCode}’”);
         string productNetWeight = GetComplains(“50g”);
         Console.WriteLine($”Complains Product Net Weight: ‘{productNetWeight}’”);
        string productNull = GetComplains(null);
         Console.WriteLine($”Complains Null Product: ‘{productNull}’”);
         string noComplain = GetComplains();
         Console.WriteLine($”No Product Complain: ‘{noComplain}’”);
}
    static string GetComplains(params string[] input)
   {
        if  (input == null || input.Length == 0)
     { 
        return string.Empty;
    }
       var products = new List<string>();
         products.Add(“Blossoms Baby Powder”);
         products.Add(“Night Sleep Baby Powder”);
         products.Add(“Milk Baby Powder”);
         products.Add(“Fresh Baby Powder”);
var products = new List<string>() {“ Blossoms Baby Powder”, “Night Sleep Baby Powder”, “Milk Baby Powder”, “Fresh Baby Powder”};
           Console.WriteLine(products [0]);
            Console.WriteLine(products [1]);
            Console.WriteLine(products [2]);
            Console.WriteLine(products [3]);
foreach (var name in products)
{
 Console.WriteLine($”The product name is {name}”);
} 
            Console.WriteLine("==========WELCOME TO PRODUCT COMPLAINTS MANAGEMENT SYSTEM==========");

            Console.Write("Enter  your Full Name: ");
            string complainantName = Console.ReadLine();
            Console.WriteLine(complainantName);

            Console.Write("Enter  your Number: ");
            string cellphoneNumber = Console.ReadLine();
            Console.WriteLine(cellphoneNumber);
            Console.Write("Enter  your Email: ");

            string complainantEmail = Console.ReadLine();
            Console.WriteLine(complainantEmail);

            Console.Write("Enter  your Complain: ");
            string productComplaint = Console.ReadLine();
            Console.WriteLine("Complaint: " +productComplaint);

            DateTime complainatDateAdded = new DateTime(2021, 05, 15);
            Console.WriteLine("Date Added: " + complainatDateAdded.ToShortDateString());
            Console.WriteLine("Your Complaint is Successfully added! ");
           }
       }
    }
