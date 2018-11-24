﻿using System;
using System.Collections.Generic;

namespace Belatrix.WebApi.Models
{
    public partial class PlaylistTrack
    {
        public int PlaylistId { get; set; }
        public int TrackId { get; set; }

        public Playlist Playlist { get; set; }
        public Track Track { get; set; }
    }
}
