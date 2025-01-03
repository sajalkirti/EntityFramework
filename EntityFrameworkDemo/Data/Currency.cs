namespace EntityFrameworkDemo.Data
{
	public class Currency
	{
        public int Id { get; set; }
		public string CurrencyCode { get; set; }
		
		public string CurrencyName { get; set; }


		public ICollection<BookPrice> BookPrice { get; set; }
    }
}
