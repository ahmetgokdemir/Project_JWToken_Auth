using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    //  2:20 Çağrı Hoca IService interface'ini Service (Manager) katmanında yazmıştı!!! burada ise core (entities) katmanında (yani interfaceler — irepsitory, imanager(iservice) gibi —  core katmanında)

    // 3:38 TEntity ile birlikte TDTO da eklendi .. map'lemeden dolayı .. (irepo'da sadece TEntity var..) 
    // 4:11 TEntity : class yerine struct (primitive tipli) veya 4:17 new() instance alınabilir demek

    public interface IServiceGeneric<TEntity, TDto> where TEntity : class where TDto : class
    {
        // 4:43 TEntity yerine, Shared Library deki Response<T> kullanılacak T → TDto olacak … 

        //4:56  api’larda(mini api ve authserver api) TEntity den TDto dönüştürme yapılmayacak ;servis kısmında yapılacak o yüzden Response<T> kullanılacak.. (T → TDto)
        // shared'in referance'sı buraya verilecek

        Task<Response<TDto>> GetByIdAsync(int id);

        // IEnumerable --> List
        Task<Response<IEnumerable<TDto>>> GetAllAsync();

        // 6:25 IQueryable yerine IEnumerable kullanılacak zira buradan sonra işleme tabi tutulmayacak.. (repo'da IQueryable idi)
        Task<Response<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> predicate);

        Task<Response<TDto>> AddAsync(TDto entity);

        //  Generic (Response) class  (T) beklediği için Remove'da bir class dönmeli çözüm ise boş bir class (NoDataDto isminde boş bir class) .... Shared Layer: Response<T> sınıfının oluşturulması 8:25

        // IGenericRepository'de Task olarak işaterlenmedi!!!  implementasyonunda await kullanılmadığı için için ama iservise de kullanıldı.. (await den ötürü)
        Task<Response<NoDataDto>> Remove(int id);

        Task<Response<NoDataDto>> Update(TDto entity, int id);
    }
}