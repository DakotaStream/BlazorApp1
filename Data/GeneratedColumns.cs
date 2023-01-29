namespace BlazorApp1.Data
{
	public class GeneratedColumnsService
	{
		private static readonly string[] HeaderList = new[]
		{
		"Off", "Vacation", "Training", "Over Time", "Lunch", "Sick",
			"PTO", "Holiday", "AWAL", "Remote", "Bereavemnt","Car Accident",
			"Family Illness", " Family Emergency"
		};
		private static readonly string[] Summaries = new[]
		{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};




		public Task<ColumnData[]> GetColumnsAsync(DateOnly startDate)
		{
			return Task.FromResult(Enumerable.Range(1, 13).Select(index => new ColumnData
			{
				HeaderName = HeaderList[index],
				NumberFound = Random.Shared.Next(1, 30),
				Date = startDate.AddDays(index),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			}).ToArray());
		}
	}
}