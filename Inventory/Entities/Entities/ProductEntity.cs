using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }
        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }
        [StringLength(600)]
        public string ProductDescription { get; set; }

        public int TotalQuantity { get; set; }

        //Relacion con categotias (CategoryEntity)
        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        //Relacion con almacenamiento (StorageEntity)
        public ICollection<StorageEntity> Stotrages { get; set; }

    }
}
