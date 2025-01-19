﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMicroservice.ApplicationCore.Models.Response
{
    public class CategoryVariationResponseModel
    {
        public int Id { get; set; }
        public int Category_Id { get; set; }
        public string Variation_Name { get; set; } = string.Empty;
    }
}
