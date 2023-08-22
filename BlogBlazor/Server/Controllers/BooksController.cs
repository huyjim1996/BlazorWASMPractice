using BlogBlazor.Server.Models;
using BlogBlazor.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogBlazor.Server.Controllers
{
    [Route("api/[controller]")]//đây là thuộc tính route chỉ định cách url của các yêu cầu http sẽ được ánh xạ đến các phương thức trong controller, trong trường hợp này [controller] sẽ được thay thế bằng tên của lớp controller(trừ từ Controller ở cuối) => url sẽ là /api/Books
    [ApiController]//đây là thuộc tính đánh dấu lớp này là 1 api controller
    public class BooksController : ControllerBase//kế thừa lớp ControllerBase, lớp này có nhiều thuộc tính và phương thức hữu ích cho việc xử lý yêu cầu http
    {
        private readonly LibraryContext _context;//đây là một trường private readonly để lưu trữ một instance của lớp LibraryContext, được sử dụng để tương tác với cơ sở dữ liệu
        public BooksController(LibraryContext context)//đây là một hàm tạo của lớp BooksController, nhận vào một instance của LibraryContext và gán nó cho trường _context
        {
            _context = context;
        }

        // GET: api/<BooksController> 
        [HttpGet]//đây là thuộc tính chỉ ra rằng phương thức sau nó GetBooks() sẽ xử lý các yêu cầu httpGet
        //đây là phương thức GetBooks, trả về một danh sách các đối tượng Book từ bảng Books trong cơ sở dữ liệu. phương thức này dùng từ khóa async và await để thực hiện truy vấn cơ sở dữ liệu một cách không đồng bộ
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await _context.Books.ToListAsync();
        }
    }
}
