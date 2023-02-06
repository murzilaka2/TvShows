using TvShows.Models;

namespace TvShows.ViewModels
{
    public class StatisticsViewModel
    {
        public int TotalCount { get; set; }
        public Dictionary<Genre, int> GenreCount { get; set; }
    }
}
