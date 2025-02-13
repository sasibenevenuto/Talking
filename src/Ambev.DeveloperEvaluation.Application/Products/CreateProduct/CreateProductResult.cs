﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct
{
    /// <summary>
    /// Represents the response returned after successfully creating a new product.
    /// </summary>
    /// <remarks>
    /// This response contains the unique identifier of the newly created product,
    /// which can be used for subsequent operations or reference.
    /// </remarks>
    public class CreateProductResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the newly created product.
        /// </summary>
        /// <value>A GUID that uniquely identifies the created product in the system.</value>
        public Guid Id { get; set; }
    }
}
