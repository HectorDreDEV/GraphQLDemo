using GraphQL;
using GraphQL.Types;
using GraphQLDemo.Samples.Models;
using GraphQLDemo.Samples.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.Samples.Queries
{
    public class MessageQuery : ObjectGraphType
    {
        public MessageQuery()
        {
            Field<ListGraphType<MessageType>>("messages",
                resolve: context => Data.Messages
            );

            Field<MessageType>("message",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return new Message
                    {
                        Id = id,
                        Content = "Testing"
                    };
                }
            );
        }
    }
}
