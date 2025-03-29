using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("YouTube Video Tracking Program\n");

        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Video 1
        Video codingTutorial = new Video("C# Programming for Beginners", "CodeMaster", 1250);
        
        codingTutorial.AddComment(new Comment("John123", "This tutorial helped me so much! Thanks!"));
        codingTutorial.AddComment(new Comment("LearningToCode", "Great explanation of object-oriented concepts."));
        codingTutorial.AddComment(new Comment("ProgrammingNewbie", "Could you make a follow-up video on inheritance?"));
        codingTutorial.AddComment(new Comment("CSStudent", "I finally understand encapsulation now!"));
        
        videos.Add(codingTutorial);

        // Video 2
        Video gamingReview = new Video("Top 10 Games of 2024", "GameReviewer", 845);
        
        gamingReview.AddComment(new Comment("GamerXYZ", "I can't believe you left out Starfield!"));
        gamingReview.AddComment(new Comment("ConsolePlayer", "Great list! I've played 7 out of these 10."));
        gamingReview.AddComment(new Comment("PCMasterRace", "These games run much better on PC than console."));
        
        videos.Add(gamingReview);

        // Video 3
        Video cookingDemo = new Video("Easy 15-Minute Pasta Recipes", "ChefExtraordinaire", 687);
        
        cookingDemo.AddComment(new Comment("FoodLover", "I made the carbonara and it was delicious!"));
        cookingDemo.AddComment(new Comment("HomeChef", "Do you have any vegetarian pasta recipes?"));
        cookingDemo.AddComment(new Comment("ItalianCook", "The authentic way to make carbonara doesn't use cream!"));
        cookingDemo.AddComment(new Comment("BusyParent", "These quick recipes are perfect for weeknight dinners!"));
        
        videos.Add(cookingDemo);

        // Video 4
        Video fitnessRoutine = new Video("30-Day Home Workout Challenge", "FitnessPro", 1432);
        
        fitnessRoutine.AddComment(new Comment("GymRat", "This routine is great for beginners!"));
        fitnessRoutine.AddComment(new Comment("FitnessJourney", "I'm on day 15 and already seeing results!"));
        fitnessRoutine.AddComment(new Comment("HomeWorkout", "Are there modifications for people with knee problems?"));
        
        videos.Add(fitnessRoutine);

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            
            Console.WriteLine("\nComments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }
            
            Console.WriteLine("\n-------------------------\n");
        }
    }
}