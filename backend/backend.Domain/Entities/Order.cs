using backend.Domain.Abstractions;
using backend.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Domain.Entities;

public sealed class Order : Entity
{
    public Guid CustomerId { get; set; }
    public Customer? Customer { get; set; }

    public int OrderNumberYear { get; set; }
    public int OrderNumber { get; set; }
    public string Number => SetNumber();
    public DateOnly Date { get; set; }
    public DateOnly DeliveryDate { get; set; }
    public OrderStatusEnum Status { get; set; } = OrderStatusEnum.Pending;
    public List<OrderDetail>? Details { get; set; }

    public string SetNumber()
    {
        string prefix = "TS";

        string initialString = prefix + OrderNumberYear.ToString() + OrderNumber.ToString();
        int targetLengh = 16;
        int missingLengh = targetLengh - initialString.Length;
        string finalString = prefix + OrderNumberYear.ToString() + new string('0', missingLengh) + OrderNumber.ToString();

        return finalString;
    }
}
