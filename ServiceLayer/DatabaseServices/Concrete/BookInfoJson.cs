﻿// Copyright (c) 2020 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace ServiceLayer.DatabaseServices.Concrete
{
    public class BookInfoJson
    {
        public string title { get; set; }

        public List<string> authors { get; set; }

        public string publisher { get; set; }

        public string publishedDate { get; set; }

        public string description { get; set; }

        public int pageCount { get; set; }

        public List<string> categories { get; set; }

        public double? averageRating { get; set; }

        public int? ratingsCount { get; set; }

        public string imageLinksThumbnail { get; set; }

        public string saleInfoCountry { get; set; }

        public bool? saleInfoForSale { get; set; }

        public string saleInfoBuyLink { get; set; }

        public double? saleInfoListPriceAmount { get; set; }

        public string saleInfoListPriceCurrencyCode { get; set; }
    }
}