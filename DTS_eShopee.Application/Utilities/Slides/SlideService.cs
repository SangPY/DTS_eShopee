using DTS_eShopee.Data.EF;
using DTS_eShopee.Data.Entities;
using DTS_eShopee.ViewModels.Utilities.Slides;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTS_eShopee.Application.Utilities.Slides
{
    public class SlideService : ISlideService
    {
        private readonly DTSEShopeeDbContext _context;

        public SlideService(DTSEShopeeDbContext context)
        {
            _context = context;
        }

        public async Task<List<SlideViewModel>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder)
                .Select(x => new SlideViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Url = x.Url,
                    Image = x.Image
                }).ToListAsync();

            return slides;
        }
    }
}
