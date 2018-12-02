using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM_DTO
{
    public class HeThong_DTO
    {
      public int ID{ get; set; }
      public DateTime LogDate{ get; set; }
      public string Thread{ get; set; }
      public string LogLevel{ get; set; }
      public string Logger{ get; set; }
      public string Message{ get; set; }
    }
}
