using StoreManager2.Application.Interfaces.Shared;
using System;

namespace StoreManager2.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}