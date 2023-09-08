using Domain.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handels
{
    public  class StudentCommand : IRepository<Student>

    {
        public readonly StudentCommand _db = new StudentCommand();
        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await _db.GetAllAsync();
        }
        public async Task <Student > GetbyIdAsync( int id) {
            return await _db.GetbyIdAsync(id); }
        public async Task AddAsync(Student obj)
        {
            await _db.AddAsync(obj);
        }
    }
}
