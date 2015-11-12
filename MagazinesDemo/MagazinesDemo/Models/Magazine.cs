using System;
using System.Threading.Tasks;

namespace MagazinesDemo.Models
{
    public class Magazine
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Publisher { get; set; }
    }

    public class MagazineSource
    {
        public static Magazine[] Magazines =
        {
            new Magazine {Id = "1", Title = "Time", Publisher = "Time Warner", PublishedDate = DateTime.Now},
            new Magazine {Id = "2", Title = "Newsweek", Publisher = "Some corp", PublishedDate = DateTime.Now},
            new Magazine {Id = "3", Title = "People", Publisher = "Fox", PublishedDate = DateTime.Now}
        };

        public static async Task<Magazine[]> GetMagazinesAsync()
        {
            return Magazines;
        }
    }
}