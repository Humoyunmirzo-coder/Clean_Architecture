using EfCore.Models;
using System.ComponentModel.DataAnnotations;

namespace EfCore;

internal class Program
{
    public static DbContextt _dbcontex = new DbContextt();
    static void Main(string[] args)
    {

        Console.ForegroundColor = ConsoleColor.Blue ;
        Start();
     //   int id = 1;
     //   Customers customers = new Customers();
     //   Customers customers1 = GetCustomerID(1);
     //IEnumerable<Customers> customerss =  GetAllustomers();
     //   DeleteCustomer(id);
     //   UpdateCustomer(new Customers());
     //   CreateCustomer(customers );
    }

    public static void Start()
    {

        Console.WriteLine( "          ^ Hello !");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("          ^ 1.Get All Customer ");
        Console.WriteLine("          ^ 2.Get By Customer Id ");
        Console.WriteLine("          ^ 3.Create Customer ");
        Console.WriteLine("          ^ 4.Update Customer  ");
        Console.Write       ("          ^ ");


        int number = int.Parse(Console.ReadLine());
        if (number == 1 )
        {
            GetAllustomers();
        }
        if (number == 2 ) 
        {
        Console.WriteLine( "          ^ Enter Customer ID ");
        Console.Write       ("          ^ ");
            int Id = int.Parse (Console.ReadLine());
            GetCustomerID (Id);
            Console.WriteLine("          ^ Successful !");
        }
        if(number == 3)
        {
            Customers customers1 = new Customers()
            {
                CustomerId = 1,
                FirstName = " Humoyunmirzo",
                LastName = " Gafforov" ,
                PhoneNumber= " +998901110100",
                Email = " Khumoyunmirzo@.gmail.com"
            };
            CreateCustomer (customers1);

            Console.WriteLine("          ^ Successful ");
        }
        if (number == 4)
        {
            Customers customers1 = new Customers()
            {
                CustomerId = 1,
                FirstName = " Muxammad",
                LastName = " Gafforov",
                PhoneNumber = " +998902220220",
                Email = " Muxammad@.gmail.com"
            };
            UpdateCustomer (customers1);
            Console.WriteLine(  "          ^ Successful");
        }
        if (number == 5)
        {
            Console.WriteLine("          ^ Enter Customer Id ");
            Console.Write("          ^ ");
            int num = int.Parse(Console.ReadLine());
            DeleteCustomer (num);
            Console.WriteLine("          ^ Delete Successful ");
        }

    }
    private static Customers? GetCustomerID(int id)
    {
        return _dbcontex.customers.FirstOrDefault(x => x.Id == id);
    }

    private static IEnumerable<Customers> GetAllustomers()
    {
      return _dbcontex.customers.AsEnumerable();
    }

    private static void DeleteCustomer( int id)
    {
        _dbcontex.customers.Remove(GetCustomerID(id));
        _dbcontex.SaveChanges();
    }

    private static void UpdateCustomer( Customers customers )
    {
        Customers? Entity = GetCustomerID(customers.CustomerId);

      //  _dbcontex.customers.Update(Entity);   Bu boshqacha yol UPdate qilishni

        Entity.CustomerId = customers.CustomerId;
        Entity.FirstName = customers.FirstName;
        Entity.LastName = customers.LastName;
        Entity.Email = customers.Email;
        Entity.PhoneNumber = customers.PhoneNumber;
        Entity.customers = customers;
        _dbcontex.SaveChanges();
    }

    private static void CreateCustomer(Customers customers)
    {
        _dbcontex.customers.Add(customers);
        _dbcontex.SaveChanges();    
    }
}