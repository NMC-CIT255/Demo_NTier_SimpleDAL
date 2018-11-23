using Demo_NTier_SimpleDAL.Models;
using System.Collections.Generic;

namespace Demo_NTier_SimpleDAL.DataAccessLayer
{
    public interface IDataService
    {
        IEnumerable<Character> ReadAll(out MongoDbStatusCode statusCode);
        void WriteAll(IEnumerable<Character> characters, out MongoDbStatusCode statusCode);
    }
}
