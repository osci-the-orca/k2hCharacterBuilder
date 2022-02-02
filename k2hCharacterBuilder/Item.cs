using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace k2hCharacterBuilder
{
    class Item
    {
        public int Type { get; set; }
        public string Name { get; set; }
        public int StrReq { get; set; }
        public int DefReq { get; set; }
        public int SpeedReq { get; set; }
        public int WisReq { get; set; }
        public int InteReq { get; set; }

        public int AddStr { get; set; }
        public int AddDef { get; set; }
        public int AddSpeed { get; set; }
        public int AddMagi { get; set; }
        public int AddInte { get; set; }
        public int AddHP { get; set; }
        public int AddMP { get; set; }
        public int AddSP { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
