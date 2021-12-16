using System;


namespace SalesWebMvc.Models
{
    public enum SaleStatus : int
    {
        Pending = 0,
        Billed = 1,
        Cancelled = 2
    }
}
