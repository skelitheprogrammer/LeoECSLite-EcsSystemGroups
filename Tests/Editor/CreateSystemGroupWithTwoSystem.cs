using System;
using System.Collections.Generic;
using Leopotam.EcsLite;
using NUnit.Framework;

namespace Skillitronic.LeoECSLite.EcsSystemGroups.Tests.Editor
{
    public class CreateSystemGroupWithTwoSystem
    {
        [Test]
        public void EqualSystemCount()
        {
            EcsWorld world = new();
            IEcsSystems systems = new EcsSystems(world);

            string message = "SomeAwesomeMessage";
            
            TestSystemGroupWithTwoSystems testSystemGroupWithOneSystems = new(message);

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

            string message = "OtherSomeAwesomeMessage";
            TestSystemGroupWithTwoSystems testSystemGroupWithOneSystems = new(message);

            systems.AddGroup(testSystemGroupWithOneSystems);
            systems.Init();
            
            List<IEcsSystem> allSystems = systems.GetAllSystems();
            
            for (int i = 0; i < 2; i++)
            {
                Type groupSystemType = testSystemGroupWithOneSystems.Systems[i].GetType();
                Type systemsListType = allSystems[i].GetType();
                Assert.AreEqual(groupSystemType, systemsListType);
            }
            
        }
        
        [Test]
        public void SameSystemMessage()
        {
            EcsWorld world = new();
            IEcsSystems systems = new EcsSystems(world);

            string message = "SomeAwesomeMessage";
            
            TestSystemGroupWithTwoSystems testSystemGroupWithOneSystems = new(message);

            systems.AddGroup(testSystemGroupWithOneSystems);
            systems.Init();
            
            List<IEcsSystem> allSystems = systems.GetAllSystems();

            for (var i = 0; i < allSystems.Count; i++)
            {
                if (allSystems[i] is TestEmptySystemTwo system)
                {
                    Assert.AreEqual(message, system.Something);
                    break;
                }
            }
            
        }
    }
}