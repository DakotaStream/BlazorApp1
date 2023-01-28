namespace BlazorApp1.Data
{
	public class ColumnData
	{
		public string? HeaderName { get; set; }
		public int NumberFound { get; set; }
		public DateOnly Date { get; set; }

		public int TemperatureC { get; set; }

		public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

		public string? Summary { get; set; }
	}

}