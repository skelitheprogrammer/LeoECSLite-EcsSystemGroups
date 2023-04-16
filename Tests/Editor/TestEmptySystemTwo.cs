using Leopotam.EcsLite;

namespace Skillitronic.LeoECSLite.EcsSystemGroups.Tests.Editor
{
    internal class TestEmptySystemTwo : IEcsInitSystem, IEcsRunSystem
    {
        public readonly string Something;

        public TestEmptySystemTwo(string something)
        {
            Something = something;
        }

        public void Init(IEcsSystems systems)
        {
            
        }

        public void Run(IEcsSystems systems)
        {
            
        }
    }
}