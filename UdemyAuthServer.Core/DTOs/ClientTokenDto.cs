using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyAuthServer.Core.DTOs
{
    // 0:38 Sanırım client, authserver api’yle irtibatı TokenDto (access ve reflesh token içinde) ile mini api’lerle ise ClientTokenDto (access token) üzerinden yapacak… 

    // 0:53 client ,  üyelik gerektirmeyen mini api’lara istek yapabilmek için  , client’ın kendisini tanımlayan client id ve client secret (ClientLoginDto içindeler  galiba) ( üyelik gerektirmediği için username ve password gönderilemez) ile authservera istek yapıp başarılı olursa  accesstoken ( ClientTokenDto) alacak.. authserver'da appsetting içerisinde de  tutulur client bilgisi..

    // authserver'da appsetting içerisinde tutulur client bilgisi.. authserver içerisindeki client id ve secret ile client’ın kilerle uyuşuyorsa client accesstoken alacak (ClientTokenDTO)


    public class ClientTokenDto
    {
        public string AccessToken { get; set; }

        public DateTime AccessTokenExpiration { get; set; }
    }
}