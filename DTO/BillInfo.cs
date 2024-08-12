using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_App.DTO
{
    public class BillInfo
    {

        private int id;
        private int billId;
        private int foodId;
        private int count;

        public BillInfo(int id,int billId, int foodId, int count)
        {
            this.Id = id;
            this.billId = billId;
            this.foodId = foodId;
            this.count = count;
        }

        public BillInfo(DataRow row) 
        {
            this.id = (int)row["id"];
            this.billId = (int)row["idBill"];
            this.foodId = (int)row["idFood"];
            this.count = (int)row["count"];
        }

        public int Id { get => id; set => id = value; }
        public int BillId { get => billId; set => billId = value; }
        public int FoodId { get => foodId; set => foodId = value; }
        public int Count { get => count; set => count = value; }
    }
}
