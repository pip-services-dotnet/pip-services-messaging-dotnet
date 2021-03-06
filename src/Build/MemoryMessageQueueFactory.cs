﻿using PipServices3.Components.Build;
using PipServices3.Commons.Refer;
using PipServices3.Messaging.Queues;

namespace PipServices3.Messaging.Build
{
    /// <summary>
    /// Creates MemoryMessageQueue components by their descriptors.
    /// Name of created message queue is taken from its descriptor.
    /// </summary>
    /// See <a href="https://pip-services3-dotnet.github.io/pip-services3-components-dotnet/class_pip_services_1_1_components_1_1_build_1_1_factory.html">Factory</a>, 
    /// <a href="https://pip-services3-dotnet.github.io/pip-services3-messaging-dotnet/class_pip_services_1_1_messaging_1_1_queues_1_1_memory_message_queue.html">MemoryMessageQueue</a>
    public class MemoryMessageQueueFactory : Factory
    {
        public static readonly Descriptor Descriptor = new Descriptor("pip-services", "factory", "message-queue", "memory", "1.0");
        public static readonly Descriptor Descriptor3 = new Descriptor("pip-services3", "factory", "message-queue", "memory", "1.0");
        public static readonly Descriptor MemoryQueueDescriptor = new Descriptor("pip-services", "message-queue", "memory", "*", "*");
        public static readonly Descriptor MemoryQueue3Descriptor = new Descriptor("pip-services3", "message-queue", "memory", "*", "*");

        public MemoryMessageQueueFactory()
        {
            Register(MemoryQueueDescriptor, (locator) =>
            {
                Descriptor descritor = (Descriptor)locator;
                return new MemoryMessageQueue(descritor.Name);
            });
            Register(MemoryQueue3Descriptor, (locator) =>
            {
                Descriptor descritor = (Descriptor)locator;
                return new MemoryMessageQueue(descritor.Name);
            });
        }
    }
}
