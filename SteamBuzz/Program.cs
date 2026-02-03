using System;
using System.Collections.Generic;
using System.Linq;

public class CreatorStats
{
    public string CreatorName { get; set; }
    public double[] WeeklyLikes { get; set; }

    public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();
}

public class Program
{
    // Register creator into EngagementBoard
    public void RegisterCreator(CreatorStats record)
    {
        CreatorStats.EngagementBoard.Add(record);
    }

    // Count weeks where likes >= threshold
    public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (var creator in records)
        {
            int count = 0;

            foreach (double likes in creator.WeeklyLikes)
            {
                if (likes >= likeThreshold)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                result.Add(creator.CreatorName, count);
            }
        }

        return result;
    }

    // Calculate average of all weekly likes of all creators
    public double CalculateAverageLikes()
    {
        double totalLikes = 0;
        int totalWeeks = 0;

        foreach (var creator in CreatorStats.EngagementBoard)
        {
            foreach (double likes in creator.WeeklyLikes)
            {
                totalLikes += likes;
                totalWeeks++;
            }
        }

        return totalWeeks == 0 ? 0 : totalLikes / totalWeeks;
    }

    public static void Main(string[] args)
    {
        Program program = new Program();

        // Hard-coded creator data
        CreatorStats c1 = new CreatorStats
        {
            CreatorName = "Nicky",
            WeeklyLikes = new double[] { 1500, 1600, 1800, 2000 }
        };

        CreatorStats c2 = new CreatorStats
        {
            CreatorName = "Roma",
            WeeklyLikes = new double[] { 800, 1000, 1300, 1400 }
        };

        program.RegisterCreator(c1);
        program.RegisterCreator(c2);

        Console.WriteLine("Creators registered successfully\n");

        // Top posts
        double threshold = 1400;
        Console.WriteLine("Top Posts (Threshold: 1400)");

        var topPosts = program.GetTopPostCounts(CreatorStats.EngagementBoard, threshold);

        if (topPosts.Count == 0)
        {
            Console.WriteLine("No top-performing posts this week");
        }
        else
        {
            foreach (var item in topPosts)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }

        Console.WriteLine();

        // Average likes
        double avg = program.CalculateAverageLikes();
        Console.WriteLine($"Overall average weekly likes: {avg}");

        Console.WriteLine("\nLogging off - Keep Creating with StreamBuzz!");
    }
}