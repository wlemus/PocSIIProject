using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteBusinessRules.Dto
{
    public class DTEResultSendDTO
    {
        public int TrackID { get; set; }
        public string XMLSent { get; set; }
        public DateTime ReceptionDate { get; set; }

    }
}
