using System;
using System.Threading.Tasks;
using XFTest.Models;

namespace XFTest.Services
{
    public interface IDataService
    {
        Task<RequestList> GetBooks();
    }
}
