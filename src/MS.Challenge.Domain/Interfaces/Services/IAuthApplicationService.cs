using System;

namespace MS.Challenge.Domain.Interfaces.Services
{
    public interface IAuthApplicationService : IDisposable
    {
        bool CheckPassword(string password);
    }
}
