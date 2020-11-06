using GraphQL.Types;
using GraphQLDemo.Samples.Queries;
using GraphQL.Utilities;
using System;
using GraphQLDemo.Samples.Mutations;
using GraphQLDemo.Samples.Subsciptions;

namespace GraphQLDemo.Samples
{
    public class MessageSchema : Schema
    {
        public MessageSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<MessageQuery>();
            Mutation = provider.GetRequiredService<MessageMutation>();
            Subscription = provider.GetRequiredService<MessageSubsciption>();
        }
    }
}
