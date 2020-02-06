﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockJob.Models
{
    public class Top5Buy
    {
        [Key]
        public int ID { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(16,2)")]
        /// <summary>最佳五檔買入價格</summary>
        public decimal Price { get; set; }
        /// <summary>最佳五檔買入數量</summary>
        public int Volume { get; set; }
    }
}