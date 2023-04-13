using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyAuthServer.Core.DTOs
{
    // 0:38 Sanırım client, authserver api’yle irtibatı TokenDto ile mini api’lerle ise ClientDto üzerinden yapacak… 

    public class RefreshTokenDto
    {
        public string Token { get; set; }
    }
}