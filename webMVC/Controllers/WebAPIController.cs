using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webMVC.Controllers
{
    [Route("api/[controller]/[action]")] //can be called using action name
    [ApiController]
    public class WebAPIController : ControllerBase
    {
        // GET: api/<WebAPIController>
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        public object Getdata()
        {
            //return new string[] { "value1", "value2" };
            return new { Name = "Suman", Address = "Kathmandu" }; //displays in json format
        }
        public List<object> GetUsers()
        {
            List<object> list = new List<object>(); //creating new list
            list.Add(new { name = "Eren", anime = "AOT" });
            list.Add(new { name = "Mash", anime = "Mashle" });
            list.Add(new { name = "Asta", anime = "Black Clover" });
            return list;  // displays json data in a list 
        }

        // GET api/<WebAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WebAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WebAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WebAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
