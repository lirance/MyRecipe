using System;
using System.Collections.Generic;

namespace MyRecipe.Models
{
    public interface IFeedbackRepository
    {
        IEnumerable<Feedback> GetAllFeedBacks();
        void AddFeedback(Feedback feedback);
    }

}
