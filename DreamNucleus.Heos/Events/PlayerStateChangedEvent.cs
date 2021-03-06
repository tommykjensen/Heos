﻿using System;
using System.Linq;
using DreamNucleus.Heos.Infrastructure.Helpers;

namespace DreamNucleus.Heos.Events
{
    public class PlayerStateChangedEvent : Event
    {
        public int PlayerId { get; }
        public enum PlayerState { Play, Pause, Stop, Null };
        public PlayerState State { get; }

        public PlayerStateChangedEvent(Infrastructure.Heos.Heos response)
        {
            var query = QueryHelpers.ParseQuery(response.Message);

            var pid = query["pid"];
            PlayerId = int.Parse(pid);

            var playState = query["state"];
            if (playState.Equals("play", StringComparison.OrdinalIgnoreCase))
            {
                State = PlayerState.Play;
            }
            else if (playState.Equals("pause", StringComparison.OrdinalIgnoreCase))
            {
                State = PlayerState.Pause;
            }
            else if (playState.Equals("stop", StringComparison.OrdinalIgnoreCase))
            {
                State = PlayerState.Stop;
            }
            else State = PlayerState.Null;
        }
    }
}
