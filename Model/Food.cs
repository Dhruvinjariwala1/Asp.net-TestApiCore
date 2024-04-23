using System;
using System.Collections.Generic;

namespace TestApiCore.Model
{
    public partial class Food
    {
        public int Foodid { get; set; }
        public string Foodname { get; set; } = null!;
        public int Foodquantity { get; set; }
        public int Foodprice { get; set; }
    }
}
