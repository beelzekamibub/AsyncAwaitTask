namespace AsyncAwaitTask
{
	public class Program
	{
		static async Task Main(string[] args)
		{
			Console.WriteLine(await MakeTeaAsync());
		}
		static async Task<string> MakeTeaAsync()
		{
			var boilingTask = BoilWaterAsync();
			Console.WriteLine("take the cups out");
			Console.WriteLine("put tea in cup");
			var water = await boilingTask;
			var tea = $"pour {water} into the cup";
			Console.WriteLine(tea);
			return "serve tea";
		}
		static async Task<string> BoilWaterAsync()
		{
			Console.WriteLine("Start the kettle");
			Console.WriteLine("Waiting for the kettle");
			await Task.Delay(20000);
			Console.WriteLine("Kettle finished boiling");
			return "Boiled Water";
		}
		static string MakeTea()
		{
			var water = BoilWater();
            Console.WriteLine("take the cups out");
            Console.WriteLine("put tea in cup");
            var tea = $"pour {water} into the cup";
			Console.WriteLine(tea);
			return tea;

        }
		static string BoilWater()
		{
            Console.WriteLine("Start the kettle"); 
			Console.WriteLine("Waiting for the kettle");
            Task.Delay(20000).GetAwaiter().GetResult();//a synchronous delay
            //.getResult blocks the current thread untill the task is completed
            Console.WriteLine("Kettle finished boiling");
			return "Boiled Water";
        }
	}
}