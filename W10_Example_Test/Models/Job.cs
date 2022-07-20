using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace W10_Example_Test.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sector { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
    }
}
