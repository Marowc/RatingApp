using System;
using System.ComponentModel.DataAnnotations;

namespace RatingAPP.Data
{
	public class Comment
	{
		public int Id { get; set; }
		public int? BookId { get; set; }
		public int? UserId { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
		public float? Rate { get; set; }
        [DataType(DataType.Date)] public DateTime? RelaseDate { get; set; }

		public Book Book { get; set; }
    }
}

