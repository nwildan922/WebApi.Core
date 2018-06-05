using System.Linq;
using Helper;
using Microsoft.AspNetCore.Mvc;
using Model;
using WebApi.Core.DataContext;
using WebApi.Core.Models;

namespace WebApi.Core.Controllers
{
    [ApiController]    
    public class ValuesController : Controller
    {

        private readonly MhsContext _dataContext;

        public ValuesController(MhsContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        [Route("api/Values/FromDb")]
        public IActionResult FromDb()
        {
            var data = _dataContext.Mahasiswas.Where(x => x.Nim.Equals("18120851")).ToList();
            Log.Write(data);
            return Ok(data);
        }

        [HttpGet]
        [Route("api/Values/SearchFromDb")]
        public IActionResult SearchFromDb(string nim)
        {
            var data = _dataContext.Mahasiswas.Where(x => x.Nim.Equals(nim)).ToList();
            Log.Write(data);
            return Ok(data);
        }

        [HttpPost]
        [Route("api/Values/AddToDb")]
        public IActionResult AddToDb(MahasiswaModel model)
        {
            _dataContext.Mahasiswas.Add(model);
            _dataContext.SaveChanges();
            return Ok("Data Has been saved");
        }

        [HttpGet]
        [Route("api/Values/Dummy")]
        public IActionResult Dummy()
        {
            return Ok("Ok");
        }
    }

}
