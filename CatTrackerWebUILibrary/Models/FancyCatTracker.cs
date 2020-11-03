using System;

namespace CatTrackerWebUILibrary.Models
{
    public static class FancyCatTracker
    {
        public static string[] FindCats(string breed, string color)
        {
            if (breed.Length == 3)
            {
                return new string[0];
            }

            var count = new Random().Next(1, 20);
            var results = new string[count];
            for (int i = 0; i < count; i++)
            {

                results[i] = $"{GetName()} located {GetDistance()}km away";

            }

            return results;
        }

        private static string GetDistance()
        {
            return new Random().Next(0, 50).ToString();
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
