﻿using MentoringApp.Data.Models;

namespace MentoringApp.Repository.IRepository
{
    public interface IUniversityRepository : IRepository<University>
    {
        void Update(University obj);
    }
}
