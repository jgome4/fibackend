
namespace DAL;

public interface ITaskRepository : IDisposable
{
    IEnumerable<BE.Task> GetTasks();
    BE.Task GetTaskByID(Guid taskID);
    int InsertTask(BE.Task task);
    int DeleteTask(Guid taskID);
    int UpdateTask(BE.Task task);
    int InsertTasks(IEnumerable<BE.Task> tasks);
    int DeleteTasks(IEnumerable<BE.Task> tasks);
    int UpdateTasks(IEnumerable<BE.Task> tasks);
}


