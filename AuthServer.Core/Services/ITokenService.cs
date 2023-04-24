using System;
using System.Collections.Generic;
using System.Text;
using AuthServer.Core.Configuration;
using AuthServer.Core.DTOs;
using AuthServer.Core.Models;

namespace AuthServer.Core.Services
{
    // 14. ITokenService interface'sinin oluşturulması
    public interface ITokenService
    {
        // AuthServer.Service'de implemente edilecek
        TokenDto CreateToken(UserApp userApp);

        ClientTokenDto CreateTokenByClient(Client client);
    }
}