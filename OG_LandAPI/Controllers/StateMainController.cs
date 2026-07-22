using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Helpers;
using OG_LandAPI.Models;
using OG_LandAPI.Models.zPagination;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateMainController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;
        private readonly IConfiguration _config;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public StateMainController(OGDatabaseSchemaV2Context context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StateMainForm>>> RetrieveAllCounties([FromQuery] PaginationDTO pagination)
        {
            var Queryable = _context.StateMainForm.AsQueryable();
            await HttpContext.InsertPaginationParamInResponse(Queryable, pagination.QuantityPerPage);
            return await Queryable.Paginate(pagination).ToListAsync();

            //return await _context.StateMainForm.ToListAsync();
        }

        [HttpGet("StateLists")]
        public JsonResult RetrieveListOfStates()
        {
            string query = @"SELECT * FROM dbo.StateMainForm";

            DataTable state = new DataTable();
            const string V = "SQLExpressDBConnectionForOGDatabaseSchemaV2";
            string sqlDataSource = _config.GetConnectionString(V);
            SqlDataReader Reader;
            using (SqlConnection devCon = new SqlConnection(sqlDataSource))
            {
                devCon.Open();
                using (SqlCommand Command = new SqlCommand(query, devCon))
                {
                    Reader = Command.ExecuteReader();
                    state.Load(Reader);

                    Reader.Close();
                    devCon.Close();
                }
            }

            //state.

            return new JsonResult(state);
        }

        [HttpGet("StateList")]
        //public async Task<JsonResult<List<string>>> RetrieveListOfStates()
        //public async Task<ActionResult<IEnumerable<string>>> RetrieveListOfStates()
        //public async Task<List<string>> RetrieveListOfStates()
        public async Task<ActionResult<List<string>>> RetrieveListOfState()
        {
            string query = @"SELECT * FROM dbo.StateMainForm";

            DataTable stateMainForm = new DataTable();
            const string V = "SQLExpressDBConnectionForOGDatabaseSchemaV2";
            string sqlDataSource = _config.GetConnectionString(V);
            SqlDataReader Reader;
            using (SqlConnection devCon = new SqlConnection(sqlDataSource))
            {
                devCon.Open();
                using (SqlCommand Command = new SqlCommand(query, devCon))
                {
                    Reader = Command.ExecuteReader();
                    stateMainForm.Load(Reader);

                    Reader.Close();
                    devCon.Close();
                }
                //stateMainForm.Columns.Add("State_ID");
                //sda.Fill(dt);
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    state_IDComboBox.Items.Add(dt.Rows[i]["State_ID"]);
                //}
            }

            JsonResult states = new JsonResult(stateMainForm);


            return new JsonResult(stateMainForm);
        }

        SqlDataAdapter sda;
        DataTable dt;
        //List<string> States { get; set; }

        [HttpGet("States")]
        //public async Task<List<string>> States()
        public async Task<List<string>> States(List<string> States)
        {
            //List<string> States; 

            string sqlCmd = @"SELECT * FROM dbo.StateMainForm";
            dt = new DataTable();
            const string sqlCon = "SQLExpressDBConnectionForOGDatabaseSchemaV2";
            sda = new SqlDataAdapter(sqlCmd, sqlCon);
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                List<string> list = await JsonSerializer.DeserializeAsync<List<string>>(System.IO.Stream.Null);
                States = list;
                //States = await JsonSerializer.DeserializeAsync<List<string>>(System.IO.Stream.Null);
                //States = await JsonSerializer.DeserializeAsync<List<string>>(System.IO.Stream.Null.ReadAsync(sqlCmd, sqlCon));
                //States = await JsonSerializer.DeserializeAsync<List<string>>(System.IO.StringReader.Synchronized(States.);
                //States = await JsonSerializer.DeserializeAsync<List<string>>(System.IO.Stream.Null.ReadAsync(stream: Utf8JsonReader(States)));
                //States = await JsonSerializer.DeserializeAsync<List<string>>(System.IO.Stream.Synchronized(stream: Utf8JsonReader(States)));
                States.Add((string)dt.Rows[i]["State_ID"]);
                //IConfigurationBuilder configurationBuilder = state_IDComboBox.Items.Add(dt.Rows[i]["State_ID"]);
            }

            //return new JsonResult(States);
            return States;
            //return new List<string> States;
            //return new StateMainForm();
        }

        //public void AddNewState(StateMainForm state)
        //{
        //    //using(var context = _context.ContextId())
        //    using (var context = _context.Add())
        //    {

        //    }
            
            
        //    //var Queryable = _context.StateMainForm.AsQueryable();
        //    //await HttpContext.InsertPaginationParamInResponse(Queryable, pagination.QuantityPerPage);
        //    //return await Queryable.Paginate(pagination).ToListAsync();

        //    //return await _context.StateMainForm.ToListAsync();
        //}
    }
}
