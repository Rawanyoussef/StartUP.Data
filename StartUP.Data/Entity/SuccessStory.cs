using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUP.Data.Entity
{
    public class SuccessStory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
