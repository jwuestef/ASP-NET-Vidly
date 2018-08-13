using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {

        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }

        public short SignUpFee { get; set; }

        public byte DurationInMonths { get; set; }

        public byte DiscountRate { get; set; }

        // These are here to stop us using 0 and 1 in the code. Could use an enum too, but it would be a little more complicated... easier to do this
        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}