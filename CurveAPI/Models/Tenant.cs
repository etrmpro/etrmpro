﻿namespace CurveService.Models
{
    public class Tenant : AbstractEntity
    {
        public int TenantId { get; set; }
        public string Name { get; set; }
    }
}
