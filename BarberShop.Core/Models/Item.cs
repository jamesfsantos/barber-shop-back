﻿namespace BarberShop.Core.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int TipoItemId { get; set; }
    }
}
