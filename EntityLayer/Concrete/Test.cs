using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Test
    {
        [Key]
        public int TestId { get; set; }
        public string TestName { get; set; }
    }
}
