﻿using System.ComponentModel.DataAnnotations;

namespace IteneraryIteratorsMvc.Views.Travels
{
	public class LoginVM
	{

		[Required]
        [Display(Name = "Username")]
		public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
    }
}
