using System;
using System.Collections.Generic;
using System.Text;

namespace AuthServer.Core.DTOs
{
    // 0:53 client ,  üyelik gerektirmeyen mini api’lara istek yapabilmek için  , client’ın kendisini tanımlayan client id ve client secret (ClientLoginDto içindeler  galiba) ( üyelik gerektirmediği için username ve password gönderilemez) ile authservera istek yapıp başarılı olursa  accesstoken ( ClientTokenDto) alacak.. authserver'da appsetting içerisinde de  tutulur client bilgisi..

    // authserver'da appsetting içerisinde tutulur client bilgisi.. authserver içerisindeki client id ve secret ile client’ın kilerle uyuşuyorsa client accesstoken alacak (ClientTokenDTO)

    public class ClientLoginDto
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}