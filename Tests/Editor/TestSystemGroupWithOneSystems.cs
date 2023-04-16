using Leopotam.EcsLite;

namespace Skillitronic.LeoECSLite.EcsSystemGroups.Tests.Editor
{
    internal sealed class TestSystemGroupWithOneSystems : IEcsSystemGroup
    {
        public IEcsSystem[] Systems { get; }

        public TestSystemGroupWithOneSystems()
        {
            Systems = new IEcsSystem[]
            {
                new TestEmptySystemOne(),
            };
        }
    }
}