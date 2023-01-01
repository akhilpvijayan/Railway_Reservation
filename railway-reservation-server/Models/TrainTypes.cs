using railwayReservation.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Models
{
    public class TrainTypes: ITrainTypes
    {
        [Key]
        public int trainTypeId { get; set; }
        public string trainType { get; set; }
    }
}
