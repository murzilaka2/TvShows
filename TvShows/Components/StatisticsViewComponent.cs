using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TvShows.Data;
using TvShows.ViewModels;

namespace TvShows.Components
{
    public class StatisticsViewComponent : ViewComponent
    {
        private readonly ApplicationContext _context;

        public StatisticsViewComponent(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var genreCount = await _context.TvShow.GroupBy(e => e.Genre).Select(e => new
            {
                Key = e.Key,
                Count = e.Count()
            }).ToDictionaryAsync(k => k.Key, c => c.Count);

            return View(new StatisticsViewModel
            {
                GenreCount = genreCount,
                TotalCount = genreCount.Values.Sum()
            });
        }
    }
}
