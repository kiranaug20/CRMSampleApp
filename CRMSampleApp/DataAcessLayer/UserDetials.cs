using CRMSampleApp.Interfaces;
using CRMSampleApp.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Mvc;

namespace CRMSampleApp.DataAcessLayer
{
    public class UserDetials : IUserDetails
    {
        private readonly IConfiguration _configuration;

    public UserDetials(IConfiguration configuration)
    {
        _configuration = configuration;
    }
        public Response AddUserDetails(UserDetails userDetails)
        {
            string connectionString = _configuration.GetConnectionString("ConnectionString").ToString();

            Response response = new Response();
            response.StatusCode = 200;
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Sp_AddUserDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", userDetails.FirstName);
                //cmd.Parameters.AddWithValue("@LastName", userDetails.LastName);
                //cmd.Parameters.AddWithValue("@Email", userDetails.Email);
                //cmd.Parameters.AddWithValue("@DOB", userDetails.DOB);
                //cmd.Parameters.AddWithValue("@UserName", userDetails.UserName);
                //cmd.Parameters.AddWithValue("@Password", userDetails.Password);
                //cmd.Parameters.AddWithValue("@MobileNumber", userDetails.MobileNumber);
                //cmd.Parameters.AddWithValue("@Gender", userDetails.Gender);
                //cmd.Parameters.AddWithValue("@Address", userDetails.Address);
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    response.StatusCode = 200;
                    response.Message = "Records Insert Successfully";
                    response.IsSuccess = true;
                }


            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Message = ex.Message;
                response.IsSuccess = false;
            }
            return response;
        }
    }
}
