using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TrafikKontrol.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration Configuration;
        public HomeController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AnaSayfa()
        {
            return View();
        }


        public IActionResult Index7()
        {
            return View();
        }

        public async Task<ActionResult> Get_Sensortype7()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[GET_SENSORTYPE7]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        }

        public async Task<ActionResult> Get_Yon7()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[YON7]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        
        }

        public async Task<ActionResult> Get_Top7()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[TOP7]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        }

        public async Task<ActionResult> Get_Tarih13_7()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[TARIH13_7]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        }

        public async Task<ActionResult> Get_Tarih14_7()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[TARIH14_7]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        }

        public IActionResult Index100()
        {
            return View();
        }

        public async Task<ActionResult> Get_Sensortype100()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[GET_SENSORTYPE100]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        }

        public async Task<ActionResult> Get_Yon100()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[YON100]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        }

        public async Task<ActionResult> Get_Top100()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[TOP100]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        }

        public async Task<ActionResult> Get_Tarih11_100()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[TARIH11_100]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        }

        public async Task<ActionResult> Get_Tarih12_100()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[TARIH12_100]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        }
        public async Task<ActionResult> Get_Tarih13_100()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[TARIH13_100]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        }

        public async Task<ActionResult> Get_Tarih14_100()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[TARIH14_100]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        }
        public IActionResult Index8()
        {
            return View();
        }

        public async Task<ActionResult> Get_Sensortype8()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[GET_SENSORTYPE8]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        }

        public async Task<ActionResult> Get_Yon8()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[YON8]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        }

        public async Task<ActionResult> Get_Top8()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[TOP8]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        }
        public async Task<ActionResult> Get_Tarih11_8()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[TARIH11_8]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        }
        public async Task<ActionResult> Get_Tarih12_8()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[TARIH12_8]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        }

        public async Task<ActionResult> Get_Tarih13_8()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[TARIH13_8]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        }

        public async Task<ActionResult> Get_Tarih14_8()
        {
            string connection_string;
            SqlConnection conn;

            DataTable dt = new DataTable();
            connection_string = this.Configuration.GetConnectionString("DefaultString");
            conn = new SqlConnection(connection_string);
            await conn.OpenAsync();
            string query = "";
            query = "[dbo].[TARIH14_8]";
            var cmd = new SqlCommand(query, conn);
            var datareader = await cmd.ExecuteReaderAsync();
            dt.Load(datareader);
            conn.Close();

            return Json(dt,
                       new Newtonsoft.Json.JsonSerializerSettings());
        }

    }
}