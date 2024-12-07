using System.Collections.Generic;
using fluXis.Game.Online.API.Models.Maps;
using fluXis.Game.Online.API.Models.Users;
using Newtonsoft.Json;

namespace fluXis.Game.Online.API.Models.Multi;

[JsonObject(MemberSerialization.OptIn)]
public interface IMultiplayerRoom
{
    [JsonProperty("id")]
    long RoomID { get; init; }

    [JsonProperty("settings")]
    IMultiplayerRoomSettings Settings { get; init; }

    [JsonProperty("host")]
    APIUser Host { get; set; }

    [JsonProperty("participants")]
    List<IMultiplayerParticipant> Participants { get; init; }

    [JsonProperty("map")]
    APIMap Map { get; set; }
}