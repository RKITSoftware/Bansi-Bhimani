using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Friend
    {
        /// <summary>
        /// It is friend id
        /// </summary>
        [Required(ErrorMessage = "Friend id is required")]
        [Range(1, 100)]
        public int id { get; set; }
        /// <summary>
        /// It is firstname of friend
        /// </summary>
        public string firstname { get; set; }
        /// <summary>
        /// It is lastname of friend
        /// </summary>
        public string lastname { get; set; }
        /// <summary>
        /// It is location of friend
        /// </summary>
        public string location { get; set; }
        /// <summary>
        /// It is hiredate of friend
        /// </summary>
        [Required(ErrorMessage = "Hire date is required")]
        public DateTime hiredate { get; set; }
    }
}