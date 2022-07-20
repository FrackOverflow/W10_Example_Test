using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace W10_Example_Test.Models
{
    public class Candidate
    {
        [Key]
        public int Id { get; set; }
        [System.ComponentModel.DisplayName("First Name")]
        public string FirstName { get; set; }
        [System.ComponentModel.DisplayName("Last Name")]
        public string LastName { get; set; }
        [ForeignKey("Job")]
        public int? JobId { get; set; }
        public Job Job { get; set; }
  

    }
}
