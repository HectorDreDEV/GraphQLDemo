using GraphQL;
using GraphQL.Types;
using GraphQLDemo.Samples.Models;
using GraphQLDemo.Samples.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.Samples.Mutations
{
    public class MessageMutation : ObjectGraphType
    {
        public MessageMutation()
        {
            Field<MessageType>("createMessage",
                arguments: new QueryArguments(new QueryArgument<MessageInputType>
                {
                    Name = "message"
                }),
                resolve: context =>
                {
                    var message = context.GetArgument<Message>("message");
                    Data.Messages.Add(message);
                    return message;
                });
        }
    }
}
