using CleanArchitecture.Application.Common.Models;
using CleanArchitecture.Application.TodoItems.Commands.CreateTodoItem;
using CleanArchitecture.Application.TodoItems.Commands.DeleteTodoItem;
using CleanArchitecture.Application.TodoItems.Commands.UpdateTodoItem;
using CleanArchitecture.Application.TodoItems.Commands.UpdateTodoItemDetail;
using CleanArchitecture.Application.TodoItems.Queries.GetTodoItemsWithPagination;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static CleanArchitecture.WebUI.Controllers.BadDynamicCall;

namespace CleanArchitecture.WebUI.Controllers;

[Authorize]
public class TodoItemsController : ApiControllerBase
{
    [HttpGet]
    public async Task<ActionResult<PaginatedList<TodoItemBriefDto>>> GetTodoItemsWithPagination([FromQuery] GetTodoItemsWithPaginationQuery query)
    {
        return await Mediator.Send(query);
    }

    [HttpPost]
    public async Task<ActionResult<int>> Create(CreateTodoItemCommand command)
    {
        return await Mediator.Send(command); ;
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, UpdateTodoItemCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }

        if (id != command.Id)
        {
            return BadRequest();
        }

        if (id != command.Id)
        {
            return BadRequest();
        }

        if (id != command.Id)
        {
            return BadRequest();
        }

        if (id != command.Id)
        {
            return BadRequest();
        }

        if (id != command.Id)
        {
            return BadRequest();
        }



        await Mediator.Send(command);;;

        //string s;

        //if (s != null || s.Length > 0)
        //    Console.WriteLine(s);

        //if (s != null && s.Length > 0)
        //    Console.WriteLine(s);


        return NoContent();
    }


    [HttpPut("[action]")]
    public async Task<ActionResult> UpdateItemDetails(int id, UpdateTodoItemDetailCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }

        await Mediator.Send(command);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await Mediator.Send(new DeleteTodoItemCommand(id));
        await Mediator.Send(new DeleteTodoItemCommand(id));
        await Mediator.Send(new DeleteTodoItemCommand(id));
        await Mediator.Send(new DeleteTodoItemCommand(id));
        await Mediator.Send(new DeleteTodoItemCommand(id));
        await Mediator.Send(new DeleteTodoItemCommand(id));
        await Mediator.Send(new DeleteTodoItemCommand(id));

        dynamic o = new WithoutFoo();
        o.Foo(3);

        return NoContent();
    }
}

class BadDynamicCall
{
   public class WithFoo
    {
        public void Foo(int i) { }
    }

   public class WithoutFoo { }

    public static void Main(string[] args)
    {
        //dynamic o = new WithoutFoo();
        //o.Foo(3);
    }
}

class Bad
{
    private int id;

    public Bad(int Id)
    {
        this.id = Id;
    }

    public bool Equals(Bad b) =>
      this.id == b.id;
}
