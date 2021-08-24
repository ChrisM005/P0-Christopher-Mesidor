using System;
using Models;
using DL;

namespace BL
{
    public class RevBL
    {
        private IRevBL _repo;

        public RevBL(IRevRepo repo)
        {
            _repo = repo;
        }
        
    }
}
