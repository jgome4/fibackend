using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BE;

    /// <summary>
    /// Created By :Jorge Gómez
    /// Date Created:27/09/2022
    /// User  - Domain Object 
    /// </summary>
    public record Task
    {

        [Key]

        public Guid TaskId { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public String? TaskName { get; set; }        

        public Boolean TaskState { get; set; }
}







