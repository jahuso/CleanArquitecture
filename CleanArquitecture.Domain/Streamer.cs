using CleanArquitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArquitecture.Domain
{
    public  class Streamer: BaseDomainModel
    {

        public string? Nombre { get; set; }

        public string? Url { get; set; }

        public List<Video>? Videos { get; set; }
    }
}
