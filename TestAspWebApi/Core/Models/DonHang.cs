﻿using System.ComponentModel.DataAnnotations;


namespace Core.Models
{
    public class DonHang
    {
        [Key]
        public int MaDonHang { get; set; }
        public int SoLuong { get; set; }
        public Product? Product { get; set; }
        public IEnumerable<CongViec> CongViec { get; set; } = new List<CongViec>() { };
    }
}
