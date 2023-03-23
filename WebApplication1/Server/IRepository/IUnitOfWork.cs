using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Shared.Domain;

namespace WebApplication1.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);

        IGenericRepository<Make> Makes { get; }
        IGenericRepository<Model> Models { get;}
        IGenericRepository<Vehicle> Vehicles { get;}
        IGenericRepository<Booking> Bookings { get;}
        IGenericRepository<Colour> Colours { get;}
        IGenericRepository<Customer> Customers { get; }


    }
}
