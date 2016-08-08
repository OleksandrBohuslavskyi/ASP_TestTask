using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public enum GlobeType
    {
        Star,
        Void,
        Comet,
        Planet,
        Nebula,
        Pulsar,
        Galaxy,
        Quasar,
        Asteroid,
        GasGiant,
        WormHole,
        Satellite,
        UnknownObject,
        UncategorizedObject
    }
}
