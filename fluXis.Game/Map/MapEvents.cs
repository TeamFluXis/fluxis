using System;
using System.Collections.Generic;
using fluXis.Game.Map.Events;

namespace fluXis.Game.Map;

public class MapEvents
{
    public List<LaneSwitchEvent> LaneSwitchEvents = new();

    public void Load(string content)
    {
        var lines = content.Split(Environment.NewLine);

        foreach (var line in lines)
        {
            int index = line.IndexOf('(');
            int index2 = line.IndexOf(')');
            if (index == -1 || index2 == -1) continue;

            var type = line[..index];
            var args = line[(index + 1)..index2].Split(',');

            switch (type)
            {
                case "LaneSwitch":
                    LaneSwitchEvents.Add(new LaneSwitchEvent
                    {
                        Time = float.Parse(args[0]),
                        Count = int.Parse(args[1])
                    });
                    break;
            }
        }
    }
}