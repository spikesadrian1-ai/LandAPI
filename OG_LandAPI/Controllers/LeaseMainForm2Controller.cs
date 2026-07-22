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

namespace OG_LandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaseMainForm2Controller : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly IConfiguration _context;
        //private readonly OGDatabaseSchemaV2Context _context;

        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public LeaseMainForm2Controller(
            IConfiguration context
            //, OGDatabaseSchemaV2Context _context
            )
        {
            _context = context;
        }

        public JsonResult RetrieveAllLeases()
        {
            return RetrieveAllLeases(_context);
        }


        /// <summary>
        /// GET METHOD (ALL)
        /// </summary>
        /// <param name="context"></param>
        //[Route("LeaseMainForm2")]
        [HttpGet]
        //public async Task<JsonResult<IEnumerable<LeaseMainForm2>>> RetrieveAllLeases()
        public JsonResult RetrieveAllLeases(IConfiguration _context)
        {

            string query = @"SELECT * FROM dbo.LeaseMainForm2";

            DataTable leaseTable = new();
            //const string V = "SQLExpressDBConnectionForOGDatabaseSchemaV2";
            const string V = "DevConnection";
            string sqlDataSource = _context.GetConnectionString(V);
            SqlDataReader leaseReader;
            using (SqlConnection devCon = new(sqlDataSource))
            {
                devCon.Open();
                using (SqlCommand leaseCommand = new(query, devCon))
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
        public JsonResult SearchAllLeases(LeaseMainForm2 leaseMain)
        {

            string query = @"SELECT * FROM dbo.LeaseMainForm2 WHERE Lease_ID = '" + leaseMain.LeaseId+@"'";

            DataTable leaseTable = new DataTable();
            const string V = "SQLExpressDBConnectionForOGDatabaseSchemaV2";
            string sqlDataSource = _context.GetConnectionString(V);
            SqlDataReader leaseReader;
            using (SqlConnection devCon = new SqlConnection(sqlDataSource))
            {
                devCon.Open();
                using (SqlCommand leaseCommand = new SqlCommand(query, devCon))
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
            const string V = "SQLExpressDBConnectionForOGDatabaseSchemaV2";
            string sqlDataSource = _context.GetConnectionString(V);
            SqlDataReader leaseReader;
            using (SqlConnection devCon = new SqlConnection(sqlDataSource))
            {
                devCon.Open();
                using (SqlCommand leaseCommand = new SqlCommand(query, devCon))
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
                            Lease_ID = '" + leaseMain.LeaseId + @"'
                            WHERE Id = " + leaseMain.Id + @" 
                            ";

            DataTable leaseTable = new DataTable();
            const string V = "SQLExpressDBConnectionForOGDatabaseSchemaV2";
            string sqlDataSource = _context.GetConnectionString(V);
            SqlDataReader leaseReader;
            using (SqlConnection devCon = new SqlConnection(sqlDataSource))
            {
                devCon.Open();
                using (SqlCommand leaseCommand = new SqlCommand(query, devCon))
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
            const string V = "SQLExpressDBConnectionForOGDatabaseSchemaV2";
            string sqlDataSource = _context.GetConnectionString(V);
            SqlDataReader leaseReader;
            using (SqlConnection devCon = new SqlConnection(sqlDataSource))
            {
                devCon.Open();
                using (SqlCommand leaseCommand = new SqlCommand(query, devCon))
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
