using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaseMainForm2Controller : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly IConfiguration _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public LeaseMainForm2Controller(IConfiguration context)
        {
            _context = context;
        }


        /// <summary>
        /// GET METHOD (ALL)
        /// </summary>
        /// <param name="context"></param>
        //[Route("LeaseMainForm2")]
        [HttpGet]
        public JsonResult RetrieveAllLeases()
        {

            string query = @"SELECT * FROM dbo.LeaseMainForm2";

            DataTable leaseTable = new DataTable();
            const string V = "DevConnection";
            string sqlDataSource = _context.GetConnectionString(V);
            Microsoft.Data.SqlClient.SqlDataReader leaseReader;
            using (Microsoft.Data.SqlClient.SqlConnection devCon = new Microsoft.Data.SqlClient.SqlConnection(sqlDataSource))
            {
                devCon.Open();
                using (Microsoft.Data.SqlClient.SqlCommand leaseCommand = new Microsoft.Data.SqlClient.SqlCommand(query, devCon))
                {
                    leaseReader = leaseCommand.ExecuteReader();
                    leaseTable.Load(leaseReader);

                    leaseReader.Close();
                    devCon.Close();
                }
            }

            return new JsonResult(leaseTable);

        }


        /// <summary>
        /// GETLEASESBYID METHOD
        /// </summary>
        /// <param name="context"></param>
        [Route("SearchAllLeases/{name}")]
        [HttpGet]
        public JsonResult SearchAllLeases(string name)
        {

            string query = @"SELECT * FROM dbo.LeaseMainForm2 WHERE   ";

            DataTable leaseTable = new DataTable();
            const string V = "DevConnection";
            string sqlDataSource = _context.GetConnectionString(V);
            Microsoft.Data.SqlClient.SqlDataReader leaseReader;
            using (Microsoft.Data.SqlClient.SqlConnection devCon = new Microsoft.Data.SqlClient.SqlConnection(sqlDataSource))
            {
                devCon.Open();
                using (Microsoft.Data.SqlClient.SqlCommand leaseCommand = new Microsoft.Data.SqlClient.SqlCommand(query, devCon))
                {
                    leaseReader = leaseCommand.ExecuteReader();
                    leaseTable.Load(leaseReader);
                    leaseReader.Close();
                    devCon.Close();
                }
            }

            return new JsonResult(leaseTable);

        }


        /// <summary>
        /// POST METHOD
        /// </summary>
        /// <param name="context"></param>
        [HttpPost]
        public JsonResult AddNewLease(LeaseMainForm2 leaseMain)
        {
            string query = @"
                            INSERT INTO dbo.LeaseMainForm2 values
                            (
                                '"+leaseMain.LeaseId+@"')
                            ";

            DataTable leaseTable = new DataTable();
            const string V = "DevConnection";
            string sqlDataSource = _context.GetConnectionString(V);
            Microsoft.Data.SqlClient.SqlDataReader leaseReader;
            using (Microsoft.Data.SqlClient.SqlConnection devCon = new Microsoft.Data.SqlClient.SqlConnection(sqlDataSource))
            {
                devCon.Open();
                using (Microsoft.Data.SqlClient.SqlCommand leaseCommand = new Microsoft.Data.SqlClient.SqlCommand(query, devCon))
                {
                    leaseReader = leaseCommand.ExecuteReader();
                    leaseTable.Load(leaseReader);
                    leaseReader.Close();
                    devCon.Close();
                }
            }

            return new JsonResult("Added Successfully");
        }


        /// <summary>
        /// PUT METHOD
        /// </summary>
        /// <param name="context"></param>
        [HttpPut("{id:int}")]
        public JsonResult UpdateLease(LeaseMainForm2 leaseMain)
        {
            string query = @"
                            UPDATE dbo.LeaseMainForm2 SET
                            LeaseMainForm2 = '" + leaseMain.LeaseId + @"'
                            WHERE Id = " + leaseMain.Id + @" 
                            ";

            DataTable leaseTable = new DataTable();
            const string V = "DevConnection";
            string sqlDataSource = _context.GetConnectionString(V);
            Microsoft.Data.SqlClient.SqlDataReader leaseReader;
            using (Microsoft.Data.SqlClient.SqlConnection devCon = new Microsoft.Data.SqlClient.SqlConnection(sqlDataSource))
            {
                devCon.Open();
                using (Microsoft.Data.SqlClient.SqlCommand leaseCommand = new Microsoft.Data.SqlClient.SqlCommand(query, devCon))
                {
                    leaseReader = leaseCommand.ExecuteReader();
                    leaseTable.Load(leaseReader);
                    leaseReader.Close();
                    devCon.Close();
                }
            }

            return new JsonResult("Update Successfully");
        }


        /// <summary>
        /// DELETE METHOD
        /// </summary>
        /// <param name="context"></param>
        [HttpDelete("{id:int}")]
        public JsonResult DeleteLease(int Id)
        {
            string query = @"
                            DELETE FROM dbo.LeaseMainForm2 
                            WHERE Id = " + Id + @" 
                            ";

            DataTable leaseTable = new DataTable();
            const string V = "DevConnection";
            string sqlDataSource = _context.GetConnectionString(V);
            Microsoft.Data.SqlClient.SqlDataReader leaseReader;
            using (Microsoft.Data.SqlClient.SqlConnection devCon = new Microsoft.Data.SqlClient.SqlConnection(sqlDataSource))
            {
                devCon.Open();
                using (Microsoft.Data.SqlClient.SqlCommand leaseCommand = new Microsoft.Data.SqlClient.SqlCommand(query, devCon))
                {
                    leaseReader = leaseCommand.ExecuteReader();
                    leaseTable.Load(leaseReader);
                    leaseReader.Close();
                    devCon.Close();
                }
            }

            return new JsonResult("Successfully Deleted");
        }
    }
}
