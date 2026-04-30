using System;
using System.Collections.Generic;
using System.Text;
using TaskApp.DAL;
using TaskApp.Model;


namespace TaskApp.Service
{
    public class TaskService
    {
        public readonly TaskApplicationContext instancetaskApplicationContext;

        public TaskService(TaskApplicationContext _context)
        {
            instancetaskApplicationContext = _context;
        }
        public List<TaskModel> GetTasksInPage(int pageIndex, int PageSize)
        {
            var tasks = new List<TaskModel>();
            tasks = instancetaskApplicationContext.Tasks.Skip(pageIndex).Take(PageSize).ToList();
            return tasks;
        }


    }
}
