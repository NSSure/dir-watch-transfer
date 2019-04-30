using System;

namespace DirWatchTransfer.Core.Entity
{
    public class ActivityHistory
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public int EntityID { get; set; }
        public string Data { get; set; }
    }
}
