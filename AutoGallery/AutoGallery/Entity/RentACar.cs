using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGallery.Entity
{
    class RentACar
    {
        [Key]
        public int rentACar_id{ get; set; }
        public DateTime rent_purchaseDate { get; set; }
        public DateTime rent_deliveryDate { get; set; }
        public float rent_totalMoney { get; set; }
        public int car_id { get; set; }
        public int customer_id { get; set; }

        public virtual Car Cars { get; set; }
        public virtual Customer Customers { get; set; }



    }
}
