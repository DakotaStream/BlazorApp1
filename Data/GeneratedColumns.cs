namespace BlazorApp1.Data
{
	public class GeneratedColumnsService
	{
		private static readonly string[] Summaries = new[]
		{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	};

		public Task<ColumnData[]> GetColumnsAsync(DateOnly startDate)
		{
			return Task.FromResult(Enumerable.Range(1, 5).Select(index => new ColumnData
			{
				Date = startDate.AddDays(index),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			}).ToArray());
		}
	}
}