using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppMyVet.Web.Data.Entities
{
    [Table("TblManager")]
    public class Manager
    {
        public int Id { get; set; }

        public User User { get; set; }
    }

}
