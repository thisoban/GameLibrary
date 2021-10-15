﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace IDal
{
    public interface IFavouriteDal
    {
        List<Favourite> GetAllFavourites();
        Favourite GetFavourite();
        void UpdateFavourite();
        void DeleteFavourite();

    }
}
