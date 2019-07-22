using System;
using System.Collections.Generic;

namespace SamuraiApp.Domain
{
    public class Clan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Samurai Head { get; set; }
        public int? HeadId { get; set; }
        public virtual List<Samurai> Samurais { get; set; }
    }
}
