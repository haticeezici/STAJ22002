﻿using MongoDbGunduz.Dtos.CategoryDtos;

namespace MongoDbGunduz.Dtos.ProductDtos
{
    public class ResultProductWithCategoryDto
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string CategoryId { get; set; }
        public ResultCategoryDto Category { get; set; }
    }
}