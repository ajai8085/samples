

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WebApiTester.LocalQueue
{
    public class LocalQueueDbContext : DbContext
    {

        public DbSet<QueueMessage> QueueMessages { get; set; }
        public DbSet<QueueInfo> QueueInfos { get; set; }

    }


    public class QueueMessage
    {
        [Key]
        public Guid Id { get; set; }

        public string Message { get; set; }
        public string Label { get; set; }

        public QueueInfo QueueInfo { get; set; }
        public int QueueInfoId { get; set; }
    }

    public class QueueInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<QueueMessage> QueueMessages { get; set; }
    }
}
