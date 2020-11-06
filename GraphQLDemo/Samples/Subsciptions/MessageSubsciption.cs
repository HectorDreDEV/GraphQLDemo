using GraphQL;
using GraphQL.Resolvers;
using GraphQL.Subscription;
using GraphQL.Types;
using GraphQLDemo.Samples.Models;
using GraphQLDemo.Samples.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.Samples.Subsciptions
{
    public class MessageSubsciption : ObjectGraphType
    {
        public MessageSubsciption()
        {
            AddField(new EventStreamFieldType
            {
                Name = "messageAdded",
                Type = typeof(MessageType),
                Resolver = new FuncFieldResolver<Message>(ResolveMesage),
                Subscriber = new EventStreamResolver<Message>(Subscibe)
            });
        }

        private Message ResolveMesage(IResolveFieldContext context)
        {
            return context.Source as Message;
        } 

        private IObservable<Message> Subscibe(IResolveEventStreamContext context)
        {
            return Data.AllMessages();
        }
    }
}
