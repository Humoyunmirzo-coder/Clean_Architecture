using Domain.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastacture.Persistence
{
    internal class DbGreade

    { 
        public async Task <Grade > GetByIdAsync (int id)
        {
            using NpgsqlConnection connection= new NpgsqlConnection();

        }
    }
}
