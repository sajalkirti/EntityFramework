namespace EntityFrameworkDemo.Data
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Author { get; set; }
		public bool IsActive { get; set; }
		public int NoOfPage { get; set; }
		public DateOnly CreatedOn { get; set; }
		public int LanguageId { get; set; }

		public Language Language { get; set; }
	}
}
