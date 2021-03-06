﻿using System;
using System.Collections.Generic;

namespace MyRecipe.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext _context;
        public FeedbackRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void AddFeedback(Feedback feedback)
        {
            _context.Feedbacks.Add(feedback);
            _context.SaveChanges();
        }

        public IEnumerable<Feedback> GetAllFeedBacks()
        {
            return _context.Feedbacks;

        }
    }
}
