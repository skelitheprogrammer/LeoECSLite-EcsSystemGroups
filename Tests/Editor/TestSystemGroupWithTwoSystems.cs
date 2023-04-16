using Leopotam.EcsLite;

namespace Skillitronic.LeoECSLite.EcsSystemGroups.Tests.Editor
{
    internal sealed class TestSystemGroupWithTwoSystems : IEcsSystemGroup
    {
        public IEcsSystem[] Systems { get; }
        
        public TestSystemGroupWithTwoSystems(string something)
        {
            Systems = new IEcsSystem[]
            {
                new TestEmptySystemOne(),
                new TestEmptySystemTwo(something)
            };
        }
    }
}