using Leopotam.EcsLite;

namespace Skillitronic.LeoECSLite.EcsSystemGroups
{
    public interface IEcsSystemGroup : IEcsSystem
    {
        IEcsSystem[] Systems { get; }
    }
}