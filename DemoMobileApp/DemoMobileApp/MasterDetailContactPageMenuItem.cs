using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMobileApp
{

    public class MasterDetailContactPageMenuItem
    {
        public MasterDetailContactPageMenuItem()
        {
            TargetType = typeof(MasterDetailContactPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}