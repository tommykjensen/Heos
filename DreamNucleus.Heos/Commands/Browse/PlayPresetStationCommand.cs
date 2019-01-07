using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamNucleus.Heos.Infrastructure.Heos;

namespace DreamNucleus.Heos.Commands.Browse
{
    public sealed class PlayPresetStationCommand : Command<EmptyResponse>
    {
        public PlayPresetStationCommand(int playerId, int position)
            : base($"browse/play_preset?pid={playerId}&preset={position}")
        {

        }

        public override EmptyResponse Parse(Response response)
        {
            return new EmptyResponse();
        }
    }
}
