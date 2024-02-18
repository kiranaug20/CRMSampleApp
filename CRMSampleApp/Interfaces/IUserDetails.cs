using CRMSampleApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRMSampleApp.Interfaces
{
    public interface IUserDetails
    {
      Response AddUserDetails(UserDetails userDetails);
    }
}
