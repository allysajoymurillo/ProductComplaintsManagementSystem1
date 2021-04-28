using System;

namespace ProductComplaintsManagementSystem

{

 class Program

  {

   static void Main(string[] args)
        {
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

            Console.WriteLine("Your Complaint is Successfully Added! ");
        }
     }
 }


