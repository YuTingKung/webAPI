﻿using System;

namespace MSwebapi.Models
{
    public class SalesCollection
    {
        public int _id { get; set; }
        public string item { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public DateTime date { get; set; }
    }
}