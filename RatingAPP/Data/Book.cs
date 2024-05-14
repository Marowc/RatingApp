using System;
using System.ComponentModel.DataAnnotations;

namespace RatingAPP.Data
{
	public class Book
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
		public string? Author { get; set; }
        [DataType(DataType.Date)] public DateTime? RelaseDate { get; set; }
		public float? Rate { get; set; }

		public ICollection<Comment> Comments { get; }
    }
}

