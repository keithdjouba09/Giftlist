﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using giftList.Models;
using giftList.ViewModels;

namespace giftList.ViewModels
{
    public class RandomGiftViewModel
    {
        public Gift Gift { get; set; }
        public List<Wisher> Wishers { get; set; }
    }
}