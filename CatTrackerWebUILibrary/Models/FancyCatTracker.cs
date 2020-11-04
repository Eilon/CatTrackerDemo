using System;
using System.Collections.Generic;

namespace CatTrackerWebUILibrary.Models
{
    public static class FancyCatTracker
    {
        public static IList<CatTrackerResult> FindCats(string breed, string color)
        {
            // If the breed length is 3, return no results
            if (breed.Length == 3)
            {
                return Array.Empty<CatTrackerResult>();
            }

            var count = new Random().Next(1, 20);
            var results = new CatTrackerResult[count];
            for (int i = 0; i < count; i++)
            {
                results[i] = new CatTrackerResult
                {
                    // Use random values for these
                    Name = GetName(),
                    Distance = GetDistance(),

                    // Echo the search query for these
                    Breed = breed,
                    Color = color,
                };
            }

            return results;
        }

        private static double GetDistance()
        {
            return new Random().NextDouble() * 100;
        }

        private static string GetName()
        {
            return CatNames[new Random().Next(0, CatNames.Length)];
        }

        // Sourced from https://en.wikipedia.org/wiki/Popular_cat_names
        private static readonly string[] CatNames = new[]
        {
            "Tiger",
            "Puss",
            "Smokey",
            "Misty",
            "Tigger",
            "Molly",
            "Charlie",
            "Tigger",
            "Poppy",
            "Oscar",
            "Molly",
            "Felix",
            "Smudge",
            "Sooty",
            "Tigger",
            "Felix",
            "Minka",
            "Moritz",
            "Charly",
            "Tiger",
            "Romeo",
            "Pallina",
            "Micio",
            "Luna",
            "Chicco",
            "노랑이",
            "야옹이",
            "Minou",
            "Grisou",
            "Ti-Mine",
            "Félix",
            "Caramel",
            "咪咪",
            "妹妹",
            "汤圆",
            "花卷",
            "球球",
            "Momo",
            "Kuro",
            "Hana",
            "Koko",
            "Shiro",
        };
    }
}
