using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_App.DTO
{
    public class Menu
    {
        private string foodName;
        private int count;
        private float price;
        private float totalPrice;

        public Menu(string foodName, int count, float price, float totalPrice)
        {
            this.foodName = foodName;
            this.count = count;
            this.Price = price;
            this.totalPrice = totalPrice;
        }

        public Menu(DataRow row)
        {
            this.foodName = (string)row["name"];
            this.count = (int)row["count"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
            this.totalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public float Price { get => price; set => price = value; }
    }
}
