using System;
using System.Collections.Generic;
using System.Text;
using TechnoForest_Data.Context;

namespace TechnoForest_Repository.Users
{
    public class UserRepository
    {
        private readonly TechnoForestContext context;

        public UserRepository(TechnoForestContext context)
        {
            this.context = context;
        }
    }
}
