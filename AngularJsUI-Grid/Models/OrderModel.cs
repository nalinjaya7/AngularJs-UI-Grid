using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AngularJsUI_Grid.Models
{
    public class OrderModel
    {
        public OrderModel(string orderNo, string customerName, decimal total, DateTime salesDate, OrderStatus orderStatus, decimal discount)
        {
            OrderNo = orderNo;
            CustomerName = customerName;
            Total = total;
            SalesDate = salesDate;
            OrderStatus = orderStatus;
            Discount = discount;
        }

        [Required]
        [StringLength(50)]
        public string OrderNo { get; set; }
        [Required]
        [Display(Name = "Customer")]
        public string CustomerName { get; set; }
        [Required]
        [Display(Name = "Location")]
        public int LocationID { get; set; }
        [Required]
        [Column(TypeName = "Money")]
        [DisplayFormat(DataFormatString = "{0:c2}")]
        public decimal Total { get; set; }
        [Required]
        public DateTime SalesDate { get; set; }
        [Required]
        [Display(Name = "Status")]
        public OrderStatus OrderStatus { get; set; }
        [Required]
        [Column(TypeName = "Money")]
        [DisplayFormat(DataFormatString = "{0:c2}")]
        public decimal Discount { get; set; }
        public string OrderStatusText { get { return OrderStatus.ToString(); } }
        //public virtual CustomerModel Customer { get; set; } 
        //public virtual List<OrderDetailModel> OrderDetails { get; set; }

    }

    public enum OrderStatus : byte
    {

        All = 0,
        Order = 1,
        SalesOrder = 2,
        Cancelled = 3

    }
}
