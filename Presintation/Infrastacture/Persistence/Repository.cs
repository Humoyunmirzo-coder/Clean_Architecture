using Aplication.Handels;
using Dapper;
using Domain.Models;
using Npgsql;
using Restoran.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Infrastacture.Persistence.DbGreade;

namespace Infrastacture.Persistence
{
    public  class Repository : IRepository
    {

        string Connection = "server = localhost ; Port =5432; Database=Ekundalik; User Id= postgres ; password =2244 ";
        private readonly IdbContext _idbContext;
        public Repository()
        {
            _idbContext = new Dbcontext.dbcontext();

        }
        public void Delete(int Id)
        {
          
        }
            public void Getall()
            {

                string query = "select * from Grade";
                using NpgsqlConnection npgsqlConnection = new NpgsqlConnection(Connection);
                npgsqlConnection.Open();
            List<Grade> grades = npgsqlConnection.Query<Grade>(query).ToList();

                foreach (Grade o in grades)
                {
                    Console.WriteLine("GradeEnum:" + o.GradeEnum);
                    Console.WriteLine("DateTime:" + o.Date);
                    Console.WriteLine("Grade Id:" + o.GradeId);
                  
                  
                }

                npgsqlConnection.Close();

            }
        public void GetbyId(int id)
        {
            string Query = $"select * from Grade where id={id}";
            using NpgsqlConnection npgsqlConnection = new NpgsqlConnection(Connection);
            npgsqlConnection.Open();
            
            List<Grade> grades =npgsqlConnection.Query< Grade>(Query).ToList(); 
           
            foreach (Grade o in grades)
            {
                Console.WriteLine("GradeEnum:" + o.GradeEnum);
                Console.WriteLine("DateTime:" + o.Date);
                Console.WriteLine("Grade Id:" + o.GradeId);

            }

        }

        public void Insert(Grade grade)
        {

            try
            {
                string Command = $"insert into Grade (GradeEnum,Date,GradeId) " +
                    $"values({grade.GradeId},{grade.GradeEnum},'{grade.Date}'')";
                int effectrows = _idbContext.GetexecutenonQuery(Command);
                if (effectrows > 0)
                {
                    Console.WriteLine("succesfully added");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("someting went wrong in inserting");
            }
        }
        public void Update(int Id)
        {
            Console.WriteLine("insert new amount");
            int newamount = Convert.ToInt32(Console.ReadLine());
            string Command = $"Update Grade set amount={newamount} where id={Id}";
            int effectrows = _idbContext.GetexecutenonQuery(Command);
            if (effectrows > 0)
            {
                Console.WriteLine("succesfilly updated");
            }
        }

        IRepository IRepository.CreateRepository(Grade grade)
        {
            throw new NotImplementedException();
        }

        Task<bool> IRepository.CreateRepositoryAsync(Grade grade)
        {
            throw new NotImplementedException();
        }

        Task<bool> IRepository.DeleteRepositoryAsync(Grade grade)
        {
            throw new NotImplementedException();
        }

        Task<bool> IRepository.UpdateRepositoryAsync(Grade grade)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Grade>> IRepository.GetAll(Grade grade)
        {
            throw new NotImplementedException();
        }

        Task<Grade> IRepository.GetRepositoryAsync(Grade grade)
        {
            throw new NotImplementedException();
        }
    }
}
