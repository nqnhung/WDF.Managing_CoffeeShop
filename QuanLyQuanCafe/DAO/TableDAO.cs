﻿using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance 
        {
            get { if (instance == null) ; instance = new TableDAO(); return instance; } 
            private set => instance = value; 
        }
        private TableDAO() { }

        public static int TableWidth = 100;
        public static int TableHeight = 100;

        #region TableList

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.TableFood");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);   
            }
            return tableList;
        }

        #endregion

    }
}
