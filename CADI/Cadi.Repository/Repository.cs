using Cadi.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.Http.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Cadi.DataAccess
{
    public  class Repository<T,V> : IRepository<T,V> where T : class 
    {
        protected string  _connectionString;


        public Repository(string connectionString)
        {
            SqlMapperExtensions.TableNameMapper = (type) => { return $"{type.Name}"; };
                _connectionString = connectionString;
        }

        public bool Delete(T entity)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.Delete(entity);
            }
        }

        //public List<T> filter(Expression<Func<T, object>> predicate)
        //{
        //    using (var connection = new SqlConnection(_connectionString))
        //    {
        //        List<T> list = connection.GetList<T>(Predicates.Field<T>(predicate, Operator.Eq, false)).ToList() ;
        //        return list;
        //    }
            
        //}

        public T GetById(V id)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.Get<T>(id);
            }
        }


        public IEnumerable<T> GetList()
        {

            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    return connection.GetAll<T>();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Insert(T entity)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                return (int) connection.Insert(entity);
            }
        }

        public bool Update(T entity)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.Update(entity);
            }
        }
    }
}
