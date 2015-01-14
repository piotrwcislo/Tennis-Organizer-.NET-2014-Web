﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TennisOrganizer.MVC.Models
{
	[Table("Konta")]
	public class Account
	{
		[Key]
		public int AccountId { get; set; }

		[Required]
		[Display(Name = "Użytkownik")]
		public String Login { get; set; }

		[Required]
		[MinLength(3)]
		[Display(Name = "Hasło")]
		[DataType(DataType.Password)]
		public String Password { get; set; }

		public virtual Player Player { get; set; }
	}
}