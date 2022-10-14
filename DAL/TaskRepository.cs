using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace DAL;


public class TaskRepository :DbContext, ITaskRepository, IDisposable
    {
    public TaskRepository(DbContextOptions<TaskRepository> options)
        : base(options)
    {
        _Task = base.Set<BE.Task>();
    }

    DbSet<BE.Task> _Task;

    

    public IEnumerable<BE.Task> GetTasks()
        {
            return _Task != null ? _Task.ToList() : null;
    }

        public BE.Task GetTaskByID(Guid taskID)
        {
            return _Task.Find(taskID);
        }

        public int InsertTask(BE.Task task)
        {
            _Task.Add(task);
            return Save();
        }

        public int DeleteTask(Guid taskID)
        {
            BE.Task task = _Task.Find(taskID);
            _Task.Remove(task);
            return Save();
    }

        public int UpdateTask(BE.Task task)
        {
            _Task.Update(task).State = EntityState.Modified;
            return Save();
        }

        public int InsertTasks(IEnumerable<BE.Task> tasks)
        {
            _Task.AddRange(tasks);
            return Save();
        }

        public int DeleteTasks(IEnumerable<BE.Task> tasks)
        {
             _Task.RemoveRange(tasks);
             return Save();
        }

        public int UpdateTasks(IEnumerable<BE.Task> tasks)
        {
            _Task.UpdateRange(tasks);
            return Save();
        }


    public int Save()
        {
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TaskConfig());
        }

}
