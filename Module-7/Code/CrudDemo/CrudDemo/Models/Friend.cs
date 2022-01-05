using System.ComponentModel.DataAnnotations;

namespace CrudDemo.Models
{
    public class Friend
    {
        /// <summary>
        /// This is friend id
        /// </summary>
        [Required(ErrorMessage = "Friend id is required")]
        [Range(1, 100)]
        public int id { get; set; }
        /// <summary>
        /// This is firstname of friend
        /// </summary>
        public string firstname { get; set; }
        /// <summary>
        /// This is lastname of friend
        /// </summary>
        public string lastname { get; set; }
        /// <summary>
        /// This is location of friend
        /// </summary>
        public string location { get; set; }
        /// <summary>
        /// This is salary of friend
        /// </summary>
        [Required(ErrorMessage = "Salary is required")]
        public int salary { get; set; }

    }
}