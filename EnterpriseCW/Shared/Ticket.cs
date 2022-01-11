using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseCW.Shared
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }

        public string TicketDescription { get; set; }
        public Guid ProjectId { get; set; }     //works like a foreign key
        public virtual List<User> User { get; set; }        // we need this as I am using Entity Framework



    }
}
