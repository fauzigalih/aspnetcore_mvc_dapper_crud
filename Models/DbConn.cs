using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcore_mvc_dapper_crud.Models
{
    public class DbConn
    {
        public DbConn(DbConnection connection)
        {
            this.Connection = connection;
        }

        internal DbConnection Connection { get; }

    }
}
