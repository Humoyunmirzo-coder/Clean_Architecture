using EfCore.ForDb;
using EfCore.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace EfCore;

internal class Program
{
    public static DbContextt _dbcontex = new DbContextt();
    private object _context;

    static void Main(string[] args)
    {
         Customers customers = new Customers();
        _dbcontex.Attach(customers).State = Microsoft.EntityFrameworkCore.EntityState.Added;
        Console.WriteLine(_dbcontex.Entry(customers).State);
        _dbcontex.SaveChanges();

        _dbcontex.Attach  (customers).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        Console.WriteLine(_dbcontex.Entry(customers).State);
        _dbcontex.SaveChanges ();

        _dbcontex.Attach (customers).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        Console.WriteLine(_dbcontex.Entry(customers).State);
        _dbcontex.SaveChanges ();

        _dbcontex.Attach (customers).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;
        Console.WriteLine(_dbcontex.Entry(customers).State);
            _dbcontex.SaveChanges ();

        _dbcontex.Attach(customers).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        Console.WriteLine(_dbcontex.Entry(customers).State);
        _dbcontex.SaveChanges ();








        //    Console.ForegroundColor = ConsoleColor.Blue;
        //    Start();
        // //   int id = 1;
        // //   Customers customers = new Customers();
        // //   Customers customers1 = GetCustomerID(1);
        // //IEnumerable<Customers> customerss =  GetAllustomers();
        // //   DeleteCustomer(id);
        // //   UpdateCustomer(new Customers());
        // //   CreateCustomer(customers );
        //}

        //private static void DisplayStates(object value)
        //{
        //    throw new NotImplementedException();
        //}

        //public static void Start()
        //{

        //    Console.WriteLine( "          ^ Hello !");
        //    Console.ReadKey();
        //    Console.Clear();
        //    Console.WriteLine("          ^ 1.Get All Customer ");
        //    Console.WriteLine("          ^ 2.Get By Customer Id ");
        //    Console.WriteLine("          ^ 3.Create Customer ");
        //    Console.WriteLine("          ^ 4.Update Customer  ");
        //    Console.WriteLine("          ^ 5.Delete Customer  ");
        //    Console.Write       ("          ^ ");


        //    int number = int.Parse(Console.ReadLine());
        //    if (number == 1 )
        //    {
        //        GetAllustomers();
        //    }
        //    if (number == 2 ) 
        //    {
        //    Console.WriteLine( "          ^ Enter Customer ID ");
        //    Console.Write       ("          ^ ");
        //        int Id = int.Parse (Console.ReadLine());
        //        GetCustomerID (Id);
        //        Console.WriteLine("          ^ Successful !");
        //    }
        //    if(number == 3)
        //    {
        //        Customers customers1 = new()
        //        {
        //            CustomerId = 3,
        //            FirstName = " Humoyunmirzo",
        //            LastName = " Gafforov" ,
        //            PhoneNumber= " +998901110100",
        //            Email = " Khumoyunmirzo@.gmail.com"
        //        };
        //        CreateCustomer (customers1);

        //        Console.WriteLine("          ^ Successful ");
        //    }
        //    if (number == 4)
        //    {
        //        Customers customers11 = new()
        //        {
        //            CustomerId = 11,
        //            FirstName = " Muxammad",
        //            LastName = " Gafforov",
        //            PhoneNumber = " +998902220220",
        //            Email = " Muxammad@.gmail.com"
        //        };
        //        UpdateCustomer (customers11);
        //        Console.WriteLine(  "          ^ Successful");
        //    }
        //    if (number == 5)
        //    {
        //        Console.WriteLine("          ^ Enter Customer Id ");
        //        Console.Write("          ^ ");
        //        int num = int.Parse(Console.ReadLine());
        //        DeleteCustomer (num);
        //        Console.WriteLine("          ^ Delete Successful ");
        //    }

        //}
        //private static Customers? GetCustomerID(int id)
        //{
        //    return _dbcontex.customers.FirstOrDefault(x => x.CustomerId == id);
        //}

        //private static IEnumerable<Customers> GetAllustomers()
        //{
        //  return _dbcontex.customers.AsEnumerable();
        //}

        //private static void DeleteCustomer( int id)
        //{
        //    _dbcontex.customers.Remove( GetCustomerID( id) );
        //    _dbcontex.SaveChanges();
        //}

        //private static void UpdateCustomer( Customers customers )
        //{
        //    Customers? Entity = GetCustomerID(customers.CustomerId);

        //  //  _dbcontex.customers.Update(Entity);   Bu boshqacha yol UPdate qilishni

        //    Entity.CustomerId = customers.CustomerId = 1;
        //    Entity.FirstName = customers.FirstName = " humoyun";
        //    Entity.LastName = customers.LastName = " Abduraxmonov";
        //    Entity.Email = customers.Email  = " Abduraxmonov@gmail.com";
        //    Entity.PhoneNumber = customers.PhoneNumber = "+998900010701";
        //    _dbcontex.SaveChanges();
        //}


        //private static void CreateCustomer(Customers customers)
        //{
        //    _dbcontex.customers.Add(customers);
        //    _dbcontex.SaveChanges();    
        //}
        //public async Task <CustomerDb> GetCustomer( Customers customers)
        //{
        //    return await GetAllCustomer();
        //}


        //public async Task<T?> GetByIdAsync(long id)
        //{
        //    return await  GetAll( GetCustomerID)  (x => x.Id == id);
        //}

        //private object GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<T> AddAsync(T entity)
        //{
        //    var entityEntry = await this._context
        //        .Set<T>().AddAsync(entity);

        //    await this._context.SaveChangesAsync();

        //    return entityEntry.Entity;
        //}
    }
    public void Looced()
    {

    }
}
