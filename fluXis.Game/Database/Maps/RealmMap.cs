using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Realms;

namespace fluXis.Game.Database.Maps;

public class RealmMap : RealmObject
{
    [PrimaryKey]
    public Guid ID { get; set; }

    public string Difficulty { get; set; } = string.Empty;
    public RealmMapMetadata Metadata { get; set; } = null!;
    public RealmMapSet MapSet { get; set; } = null!;

    /**
     * -3 = Quaver
     * -2 = Local
     * -1 = Blacklisted
     * 0 = Unsubmitted
     * 1 = Pending
     * 2 = Impure
     * 3 = Pure
     */
    public int Status { get; set; } = -2;

    public int OnlineID { get; set; } = -1;
    public string Hash { get; set; } = string.Empty;
    public float Length { get; set; } = 0;
    public float BPMMin { get; set; } = 0;
    public float BPMMax { get; set; } = 0;
    public int KeyCount { get; set; } = 4;
    public float Rating { get; set; } = 0;

    public RealmMap([CanBeNull] RealmMapMetadata meta = null)
    {
        Metadata = meta ?? new RealmMapMetadata();
        ID = Guid.NewGuid();
    }

    [UsedImplicitly]
    private RealmMap()
    {
    }

    public override string ToString()
    {
        return ID.ToString();
    }

    public static RealmMap CreateNew()
    {
        RealmMap map = new RealmMap();
        RealmMapSet set = new RealmMapSet(new List<RealmMap> { map });
        map.MapSet = set;
        return map;
    }
}