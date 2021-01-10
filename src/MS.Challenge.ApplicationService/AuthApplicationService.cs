using System;
using MS.Challenge.CrossCutting.Framework.Helpers;
using MS.Challenge.Domain.Interfaces.Services;

namespace MS.Challenge.ApplicationService
{
    public class AuthApplicationService : IAuthApplicationService
    {
        public bool CheckPassword(string password)
        {
            return PasswordHelper.IsValid(password);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
