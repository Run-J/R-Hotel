﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace HotelAppLibrary.Models
{
    /// <summary>
    /// Represents a room type with details such as title, description, and price. Used as a specific type of generic with SqlDataAccess process.
    /// </summary>
    public class RoomTypeModel
    {
        // Attributes of RoomType database
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}