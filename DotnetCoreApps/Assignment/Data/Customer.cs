using System;
using System.Collections.Generic;

namespace Assignment.Data;

public partial class Customer
{
    public int CstId { get; set; }

    public string CstName { get; set; } = null!;

    public string CstAddress { get; set; } = null!;

    public DateTime? BillDate { get; set; }

    public decimal? BillAmount { get; set; }
}
