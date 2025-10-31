using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ArtGallery.Data;
using ArtGallery.Models;
using ArtGallery.Core.Domain;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArtGallery.Controllers
{
    public class DepartmentController : Controller
    {
        public ArtGalleryDbContext _context;
        public IConfiguration _config;


        public DepartmentController(ArtGalleryDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }
        [HttpGet]
        public IActionResult Index()
        {
            string connectionString = _config.GetConnectionString("DefaultConnection");
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "dbo.SpSearchGallery";
                cmd.CommandType = System.Data.CommandType.Text;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                List<Gallery> model = new List<Gallery>();
                while (sdr.Read())
                {
                    var details = new Gallery();
                    details.Id = Convert.ToInt32(sdr["Id"]);
                    details.Name = sdr["Name"].ToString();
                    details.Location = sdr["Location"].ToString();
                    details.Telephone = sdr["Telephone"].ToString();
                    details.Email = sdr["Email"].ToString();
                    model.Add(details);
                }
                return Json(model);

            }
        }
    }
}
/* Stored Proc kasutatud siin igaks juhuks :P */
/* Create Procedure dbo.SpSearchGallery
as
begin
Select * from Gallery
end
 */
