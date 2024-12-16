﻿using oop2.Contracts;
using oop2.Models;

namespace oop2.Repository
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(RepositoryContext context)
        : base(context) { }

        public IEnumerable<Client> GetAllClients(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(g => g.Id)
                .ToList();
        }
        public Client GetClient(int id, bool trackChanges)
        {
            return FindByCondition(g => g.Id.Equals(id), trackChanges)
                .SingleOrDefault();
        }
    }
}
