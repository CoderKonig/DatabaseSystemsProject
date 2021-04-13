using System;
using System.ComponentModel.DataAnnotations;

namespace carRentalService.Model
{
    public class table_1
    {
       
        private carRentalWeb context;
        [DataType(DataType.Date)]
        public int insurane_id { get; set; }
        public int customer_id { get; set; }
        public string insurance_number { get; set; }
        public string company { get; set; }
        public string insurance_phone { get; set; }



    }
}
