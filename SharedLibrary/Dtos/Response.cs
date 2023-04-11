using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SharedLibrary.Dtos
{
    public class Response<T> where T : class
    {
        public T Data { get; private set; }
        public int StatusCode { get; private set; }

        //client dan ziyade developer'ın kullanacağı bir property.. sorgunun başarı durumunu StatusCode üzerinden sorgulamak yerine (StatusCode kullanılması durumunda business code yazmak gerekecek.. ) bu kullanılacak..
        // JsonIgnore --> datanın (IsSuccessful), json olarak, serialize edilmesini engeller.. 
        [JsonIgnore]
        public bool IsSuccessful { get; private set; }

        public ErrorDto Error { get; private set; }

        public static Response<T> Success(T data, int statusCode)
        {
            return new Response<T> { Data = data, StatusCode = statusCode, IsSuccessful = true };
        }

        public static Response<T> Success(int statusCode)
        {
            return new Response<T> { Data = default, StatusCode = statusCode, IsSuccessful = true };
        }

        //  errordto içerisinde zaten isshow var - yani errordto sınıfının bir property si- ayrıca parametre  olarak yazmaya gerek yok...
        public static Response<T> Fail(ErrorDto errorDto, int statusCode)
        {
            return new Response<T>
            {
                Error = errorDto,
                StatusCode = statusCode,
                IsSuccessful = false
            };
        }

        // Fail metodu overload edildi... oluşturulmasının nedeni tek bir hata durumunda kullanılacak..
        // 15:01 yukardakinin aksine bu overload metoda isShow parametre olarak verilmesi gerekir... burada errordto parametre olarak kullanılmadı (tek hatanın olduğu senaryolarda errordto nun property si olan list tipindeki errors'u kullanmamak için...)
        public static Response<T> Fail(string errorMessage, int statusCode, bool isShow)
        {
            var errorDto = new ErrorDto(errorMessage, isShow);

            return new Response<T> { Error = errorDto, StatusCode = statusCode, IsSuccessful = false };
        }
    }
}