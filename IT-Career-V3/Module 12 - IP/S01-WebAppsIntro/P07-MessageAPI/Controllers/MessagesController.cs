using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P07_MessageAPI.Data;
using P07_MessageAPI.Data.Models;
using P07_MessageAPI.Models.Messages;
using System.Linq;

namespace P07_MessageAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public MessagesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("all")]
        public IActionResult All()
        {
            return Ok(context.Messages.ToList());
        }

        [HttpPost]
        [Route(nameof(Create))]
        public IActionResult Create(CreateMessageViewModel model)
        {
            context.Messages.Add(new Message { User = model.User, Content = model.Content });
            context.SaveChanges();
            return Ok("Message saved");
        }
        [HttpPut]
        [Route(nameof(Edit))]
        public IActionResult Edit(EditMessageViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Message message = context.Messages.Find(model.Id);
            if (message==null)
            {
                return NotFound("Message not found!");
            }
            message.User = model.User;
            message.Content = model.Content;
            context.Messages.Update(message);
            context.SaveChanges();
            return Ok("Message update");
        }
    }
}
