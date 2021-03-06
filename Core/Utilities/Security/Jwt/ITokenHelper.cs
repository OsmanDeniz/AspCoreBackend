using Core.Entities.Concrete;
using Core.Utilities.Security.Jwt;
using System.Collections.Generic;

namespace Core.Utilities.Security
{
    public interface ITokenHelper
    { /// <summary>
      /// Ilgili kullanici icin ilgili claimleri icerek token uretmek icin
      /// </summary>
      /// <param name="user"></param>
      /// <param name="operationClaims"></param>
      /// <returns></returns>
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
