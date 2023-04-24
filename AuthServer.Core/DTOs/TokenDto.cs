using System;
using System.Collections.Generic;
using System.Text;

namespace AuthServer.Core.DTOs
{
    // 0:38 Sanırım client, authserver api’yle irtibatı TokenDto (access ve reflesh token içinde) ile mini api’lerle ise ClientTokenDto (access token) üzerinden yapacak… 

    // 2:09 Client, AuthServer’dan TokenDto  alabilmesi için username ve password; ClientTokenDto  alabilmek için ise  client bilgisi (client id ve client secret) gerekli… TokenDto üyelik gerektiren api’larda ClientTokenDto  ise üyelik gerektirmeyenlere istek yapılırken Client tarafından  kullanılacak…

    // 3:13 sharedlibrary içinde değil core içerisinde string olarak tutulmasının sebebi json web tokenın (header + payload + imza) string değer tutmasından aynısı ClientTokenDtoda da yapıldı

    // 5:27 TokenDTO oluşturulduğunda refleshtoken bilgisi ve tarihi db’ye kaydedilir… 5:37 bu datayı karşılayacak olan dto’da UserRefleshToken dır.
    public class TokenDto
    {
        public string AccessToken { get; set; }

        public DateTime AccessTokenExpiration { get; set; }

        public string RefreshToken { get; set; }

        public DateTime RefreshTokenExpiration { get; set; }
    }
}