using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }
        public DateTime LastUpdate { get; set; }
       
        public int PartialQuantity { get; set; }
        
        //Relacion con productos (ProductEntity)
 
        [StringLength(10)]
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }

        //Relacion con las bodegas (WhereHouseEntity)
        
        [StringLength(50)]
        public string WareHouseId { get; set; }
        public WareHouseEntity WareHouses { get; set; }

        //Relacion con movimientos (InOutEntity)
        public ICollection<InOutEntity> InOut { get; set; }
    }

}
