using DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;


public class TaskController : ControllerBase
{
    private readonly ITaskRepository _task;
    IFormatProvider culture = new CultureInfo("es-CO", true);
    public TaskController(ITaskRepository task
                                    )
    {
        _task = task;
    }

    ///<summary>
    /// Created by: Jorge Gómez
    /// Created: 12/10/2022
    /// Get all tasks
    ///</summary>
    [Authorize]
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<BE.Task>))]
    [ProducesResponseType(404)]
    [Route("api/getTasks")]
    public IActionResult GetTasks()
    {
        IActionResult result;
        try
        {
            result = Ok(_task.GetTasks());
            return result;
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }

    }

    ///<summary>
    /// Created by: Jorge Gómez
    /// Created: 12/10/2022
    /// Get all tasks
    /// <paramref name="task"/>
    ///</summary>

    [Authorize]
    [HttpPut]
    [ProducesResponseType(200, Type = typeof(int))]
    [ProducesResponseType(404)]
    [Route("api/insertTask")]

    public IActionResult InsertTask([FromBody] BE.Task task)
    {
        IActionResult result;
        try
        {
            result = Ok(_task.InsertTask(task));
            return result;
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message + "-" + ex.InnerException);
        }
    }

    [Authorize]
    [HttpDelete]
    [ProducesResponseType(200, Type = typeof(int))]
    [ProducesResponseType(404)]
    [Route("api/deleteTask/{taskID}")]

    public IActionResult DeleteTask(Guid taskID)
    {
        IActionResult result;
        try
        {
            result = Ok(_task.DeleteTask(taskID));
            return result;
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message + "-" + ex.InnerException);
        }
    }

    [Authorize]
    [HttpPost]
    [ProducesResponseType(200, Type = typeof(int))]
    [ProducesResponseType(404)]
    [Route("api/updateTask")]

    public IActionResult UpdateTask([FromBody] BE.Task task)
    {
        IActionResult result;
        try
        {
            result = Ok(_task.UpdateTask(task));
            return result;
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message + "-" + ex.InnerException);
        }
    }


    [Authorize]
    [HttpPut]
    [ProducesResponseType(200, Type = typeof(int))]
    [ProducesResponseType(404)]
    [Route("api/insertTasks")]
    public IActionResult InsertTasks([FromBody] IEnumerable<BE.Task> tasks)
    {
        IActionResult result;
        try
        {
            result = Ok(_task.InsertTasks(tasks));
            return result;
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message + "-" + ex.InnerException);
        }
    }

    [Authorize]
    [HttpDelete]
    [ProducesResponseType(200, Type = typeof(int))]
    [ProducesResponseType(404)]
    [Route("api/deleteTasks")]
    public IActionResult DeleteTasks([FromBody] IEnumerable<BE.Task> tasks)
    {
        IActionResult result;
        try
        {
            result = Ok(_task.DeleteTasks(tasks));
            return result;
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message + "-" + ex.InnerException);
        }
    }

    [Authorize]
    [HttpPost]
    [ProducesResponseType(200, Type = typeof(int))]
    [ProducesResponseType(404)]
    [Route("api/updateTasks")]
    public IActionResult UpdateTasks([FromBody] IEnumerable<BE.Task> tasks)
    {
        IActionResult result;
        try
        {
            result = Ok(_task.UpdateTasks(tasks));
            return result;
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message + "-" + ex.InnerException);
        }
    }







}
