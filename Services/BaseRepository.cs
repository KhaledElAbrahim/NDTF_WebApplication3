using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace WebApplication3.Services
{
    public class BaseRepository<T> : IRepository<T> where T : EntityNDTF
    {
        #region Variables
        private static AtlasDbNDTFContext _dbContext;
        private static IMongoDatabase _db;

        protected IMongoCollection<T> Collection
        {
            get
            {
                return _db.GetCollection<T>(typeof(T).Name);
            }
            set
            {
                Collection = value;
            }
        }
        #endregion

        #region Constructor
        public BaseRepository()
        {
            _dbContext = new AtlasDbNDTFContext();
            _db = _dbContext.NDTFDB;
        }
        #endregion

        #region Create
        public void Create(T entity)
        {
            try
            {
                Collection.InsertOne(entity);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
        #endregion

        #region Delete
        public void Delete(T entity)
        {
            Collection.DeleteOne(x => x == entity);
        }
        #endregion

        #region GetAll
        public IEnumerable<T> GetAll()
        {
            try
            {
                var read = Collection.AsQueryable<T>().ToList();
                return read;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                throw;
            }
        }
        #endregion

        #region GetSingle
        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            return Collection.Find(predicate).FirstOrDefault();
        }
        #endregion

        #region Query
        public IEnumerable<T> Query(Expression<Func<T, bool>> predicate)
        {
            return Collection.Find(predicate).ToEnumerable();
        }
        #endregion

        #region Update
        public void Update(T entity)
        {
            Collection.ReplaceOne(x => x.Id == entity.Id, entity);
        }
        #endregion
    }
}
