using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyAuthServer.Service
{
    public static class ObjectMapper
    {
        // içerideki bir fonksiyondur (lambda syntax)... () => demek, fonks. parametre almıyor demek ve geriye de config.CreateMapper() dönüyor yani IMapper interface'ini.. 
        private static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
        {
            // config, IMapper'ı oluşturur (CreateMapper metodu ile) 
            // içerideki bir fonksiyondur (lambda syntax)... cfg => demek, fonks. parametre almış ve IMapperConfigurationExpression tipinde 
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DtoMapper>();
            });

            return config.CreateMapper();
        });

        public static IMapper Mapper => lazy.Value;
    }
}