using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthServer.Service
{
    public static class ObjectMapper
    {
        // static MapperConfiguration config = ObjectMapper.deneme(IMapperConfigurationExpression cfg);
        static MapperConfiguration config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<DtoMapper>();
        });


        /*
        static MapperConfiguration deneme(IMapperConfigurationExpression cfg)
        {
            cfg.AddProfile<DtoMapper>();

            return (MapperConfiguration)cfg;
        }
        */

        /*
            static Action<IMapperConfigurationExpression> iconfig;
            static MapperConfiguration config = new MapperConfiguration(iconfig);
            
            iconfig.AddProfile<DtoMapper>();
            
            VEYA 
            
            private static readonly Action<IMapperConfigurationExpression> cfg2;
            
            static MapperConfiguration config = new MapperConfiguration(cfg2); 
            
            cfg2.AddProfile<DtoMapper>();    ---> cfg2 BİR İNTERFACE olduğu için olmuyor büyük olasılıkla... şöyle bir configurasyon gwrekli (Lazy<IMapper>)config.CreateMapper();

         */

        // içerideki bir fonksiyondur (lambda syntax)... () => demek, fonks. parametre almıyor demek ve geriye de config.CreateMapper() dönüyor yani IMapper interface'ini.. 
        private static readonly Lazy<IMapper> lazy = (Lazy<IMapper>)config.CreateMapper();

        // config, IMapper'ı oluşturur (CreateMapper metodu ile) 
        // içerideki bir fonksiyondur (lambda syntax)... cfg => demek, fonks. parametre almış ve IMapperConfigurationExpression tipinde 

        public static IMapper Mapper => lazy.Value;
    }
}



/*
 using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthServer.Service
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



 */