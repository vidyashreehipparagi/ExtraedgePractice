using ExtraedgePractice.Model;
using ExtraedgePractice.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExtraedgePractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService service;
        public BookController(IBookService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("GetAllBooks")]

        public ActionResult GetAllBooks()
        {
            try
            {
                return new ObjectResult(service.GetAllBooks());
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status204NoContent, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetBookById/{id}")]

        public ActionResult GetBookById(int id)
        {
            try
            {
                return new ObjectResult(service.GetBookById(id));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status204NoContent, ex.Message);
            }
        }

        [HttpPost]
        [Route("AddBook")]

        public ActionResult AddBook(Book book)
        {
            try
            {
                return new ObjectResult(service.AddBook(book));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status204NoContent, ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateBook")]

        public ActionResult UpdateBook(Book book)
        {
            try
            {
                return new ObjectResult(service.UpdateBook(book));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status204NoContent, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteBook/{id}")]

        public ActionResult DeleteBook(int id)
        {
            try
            {
                return new ObjectResult(service.DeleteBook(id));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status204NoContent, ex.Message);
            }
        }


        //[HttpGet]
        //[Route("GetBookById/{id}")]

        //public IActionResult Get(int id)
        //{

        //    try
        //    {
        //        return new ObjectResult(service.GetBookById(id));

        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status204NoContent, ex.Message);
        //    }
        //}

        //// POST api/<BookController>
        //[HttpPost]
        //[Route("AddBook")]

        //public IActionResult Post([FromBody] Book book)
        //{
        //    try

        //    {
        //        int result = service.AddBook(book);
        //        if (result >= 1)
        //        {
        //            return StatusCode(StatusCodes.Status201Created);
        //        }
        //        else
        //        {
        //            return StatusCode(StatusCodes.Status500InternalServerError);

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        //    }
        //}

        //// PUT api/<BookController>/5
        //[HttpPut]
        //[Route("UpdateBook")]

        //public IActionResult Put(int id, [FromBody] Book book)
        //{
        //    try
        //    {
        //        int result = service.UpdateBook(book);
        //        if (result >= 1)
        //        {
        //            return StatusCode(StatusCodes.Status200OK);
        //        }
        //        else
        //        {
        //            return StatusCode(StatusCodes.Status500InternalServerError);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        //    }
        //}

        //// DELETE api/<BookController>/5
        //[HttpDelete]
        //[Route("DeleteBook/{id}")]


        //public IActionResult Delete(int id)
        //{
        //    try
        //    {
        //        int result = service.DeleteBook(id);
        //        if (result >= 1)
        //        {
        //            return StatusCode(StatusCodes.Status200OK);
        //        }
        //        else
        //        {
        //            return StatusCode(StatusCodes.Status500InternalServerError);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        //    }
        //}
    }
}
