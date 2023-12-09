﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager
    {
        Repository<About> _repository = new Repository<About>();

        public List<About> GetAll()
        {
            return _repository.List();
        }

    }
}
