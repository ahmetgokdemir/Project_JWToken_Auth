using System;
using System.Collections.Generic;
using System.Text;
using UdemyAuthServer.Core.Configuration;
using UdemyAuthServer.Core.DTOs;
using UdemyAuthServer.Core.Models;

namespace UdemyAuthServer.Core.Services
{
    // 14. ITokenService interface'sinin oluşturulması
    public interface ITokenService
    {
        // UdemyAuthServer.Service'de implemente edilecek
        TokenDto CreateToken(UserApp userApp);

        ClientTokenDto CreateTokenByClient(Client client);
    }
}