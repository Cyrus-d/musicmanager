﻿using System;
using Waf.MusicManager.Domain.Playlists;

namespace Test.MusicManager.Domain.MusicFiles
{
    public class MockRandomService : IRandomService
    {
        public Func<int, int> NextRandomNumberStub { get; set; }
        
        public int NextRandomNumber(int maxValue)
        {
            return NextRandomNumberStub(maxValue);
        }
    }
}
