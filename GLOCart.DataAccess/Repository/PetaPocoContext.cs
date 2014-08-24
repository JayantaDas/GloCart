using System;
using GLOCart.Domain;
using GLOCart.Domain.Repository;
using PetaPoco;

namespace GLOCart.DataAccess.Repository
{
    public class PetaPocoContext : IDbContext
    {
        private readonly Database _db;

        public PetaPocoContext(Database database)
        {
            _db = database;
        }

        public Object Context { get { return _db; } }

        public Database Db { get { return _db; } }
    }
}
