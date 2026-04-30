using Microsoft.AspNetCore.Mvc;
using TaskApp.Service;


namespace TaskApplicationWebAPI.Controllers { 
[ApiController]
[Route("task/[controller]")]
    
    public class TaskController : ControllerBase
    {
    public TaskService inTaskService;

    public TaskController(TaskService _taskService)
    {
        inTaskService = _taskService;
    }
    [HttpGet("GetTenTask")]
        public IActionResult Index()
        {
            return Ok(inTaskService.GetTasksInPage(0,10));
        }
    }
}
