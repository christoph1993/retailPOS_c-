using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Data.Linq.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace GSHS_POS
{
    [Table(Name = "inventory")]
    public class Inventory
    {
        [Column(IsPrimaryKey = true)]
        public string inventoryID;
        [Column]
        public string invoiceID;
        [Column]
        public decimal value;
        [Column]
        public int itemCount;
        [Column]
        public DateTime invoiceDate;
        [Column(Expression = "GETDATE()")]
        public DateTime recieveDate;
    }

    [Table(Name = "inventoryItems")]
    public class InventoryItems
    {
        [Column(IsPrimaryKey = true)]
        public string inventoryID;
        [Column(IsPrimaryKey = true)]
        public int productID;
        [Column]
        public int quantity;
    }

    [Table(Name = "products")]
    public class Product
    {
        [Column(IsPrimaryKey = true)]
        public int productID;
        [Column]
        public string size;
        [Column]
        public char gender;
        [Column]
        public string category;
        [Column]
        public string style;
        [Column]
        public bool second_hand;
        [Column]
        public int instock;
        [Column]
        public double cost;
        [Column]
        public long code;
    }

    [Table(Name = "transactions")]
    public class Transaction
    {
        [Column(IsPrimaryKey = true)]
        public string transactionID;
        [Column]
        public double value;
        [Column]
        public int items;
        [Column]
        public DateTime date;
    }

    [Table(Name = "reciept")]
    public class Reciept
    {
        [Column(IsPrimaryKey = true)]
        public string transactionID;
        [Column(IsPrimaryKey = true)]
        public int productID;
        [Column]
        public int quantity;
    }

    public class InventoryItemInfo
    {
        public string inventoryID;
        public string size;
        public char gender;
        public string category;
        public string style;
        public bool secondHand;
        public long code;
    }

    public class RecieptItemInfo
    {
        public string transactionID;
        public int productID;
        public long code;
        public int quantity;
        public int items;
        public double cost;
    }
}
