﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Table
    {
        public Table(int tableID, string tableState)
        {
            TableID = tableID;
            TableState = tableState;
        }

        public int TableID { get; set; }
        public string TableState { get; set; } //whether a table is occupied, reserved or free
    }
}