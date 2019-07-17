using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace WebApplication3.Services
{
    public class AtlasDbNDTFContext : DbContext
    {
        public IMongoClient Client { get; }
        public IMongoDatabase NDTFDB { get; }

        public AtlasDbNDTFContext()
        {
            try
            {
                Client = new MongoClient(/**** Connection String ****/);
                if (Client != null)
                {
                    NDTFDB = Client.GetDatabase("ndtf");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
