using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Table
    {
        public Table(int tableID, TableState tableState)
        {
            TableID = tableID;
            TableState = tableState;
        }

        public int TableID { get; set; }
        public TableState TableState { get; set; }
    }

    public enum TableState
    {
        available, occupied, reserved
    }
}
