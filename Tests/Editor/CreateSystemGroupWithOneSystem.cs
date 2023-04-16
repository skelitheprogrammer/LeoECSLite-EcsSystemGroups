using System;
using System.Collections.Generic;
using Leopotam.EcsLite;
using NUnit.Framework;
namespace Skillitronic.LeoECSLite.EcsSystemGroups.Tests.Editor
{
    public class CreateSystemGroupWithOneSystem
    {
        [Test]
        public void EqualSystemCount()
        {
            EcsWorld world = new();
            IEcsSystems systems = new EcsSystems(world);

            TestSystemGroupWithOneSystems testSystemGroupWithOneSystems = new();

            systems.AddGroup(testSystemGroupWithOneSystems);
            systems.Init();

            int systemsGroupLength = testSystemGroupWithOneSystems.Systems.Length;

            List<IEcsSystem> allSystems = systems.GetAllSystems();
            int systemsListCount = allSystems.Count;

            Assert.AreEqual(systemsGroupLength, systemsListCount);
            
        }

        [Test]
        public void EqualSystemType()
        {
            EcsWorld world = new();
            IEcsSystems systems = new EcsSystems(world);

            TestSystemGroupWithOneSystems testSystemGroupWithOneSystems = new();

            systems.AddGroup(testSystemGroupWithOneSystems);
            systems.Init();
            
            List<IEcsSystem> allSystems = systems.GetAllSystems();
            
            Type groupSystemType = testSystemGroupWithOneSystems.Systems[0].GetType();
            Type systemsListType = allSystems[0].GetType();
            
            Assert.AreEqual(groupSystemType, systemsListType);
        }
    }
}