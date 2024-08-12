using Project_App.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_App.DAO
{
    internal class TableDAO
    {
        private static TableDAO instance;

        internal static TableDAO Instance { 
            get { if(instance == null) instance = new TableDAO(); return instance; }
            private set { instance = value; }
        }

        public TableDAO() { }

        public List<Table> LoadDataTableList()
        {
            List<Table> list = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TableFood");
            foreach (DataRow item in data.Rows)
            {
                Table  table = new Table(item);
                list.Add(table);
            }
             return list;
        }

        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTabel @idTable1 , @idTabel2", new object[] { id1, id2 });
        }
    }
}
