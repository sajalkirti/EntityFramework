namespace EntityFrameworkDemo.Data
{
	public class BookPrice
	{
		public int Id { get; set; }

		public int BookId { get; set; }

		public float CurrencyId { get; set; }

		public float Price {  get; set; }



		public Book Book { get; set; }
		public Currency Currency { get; set; }
	}
}
