using System;
using System.Collections.Generic;

namespace LabVSSiTable.Data
{
    public class Data
    {
        public Guid SyncId { get; set; } = Guid.NewGuid();
        public string Customer { get; set; } = string.Empty;
        public string AppNumber { get; set; } = string.Empty;
        public DateTime GetTechnicalToWork { get; set; } = DateTime.Now;
        public bool SpToSi { get; set; } = false;
        public DateTime ReturnTechnical { get; set; } = DateTime.Now;
        public DateTime ReturnOM { get; set; } = DateTime.Now;
        public bool ReturnPartTechnical { get; set; } = false;
        public string Comment { get; set; } = string.Empty;
    }

    public static class DataList
    {
        public static List<Data> dataLists = new();
        public static List<Data> dataListsFuture = new();
    }
}
