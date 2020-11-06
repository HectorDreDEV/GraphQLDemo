using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.Samples.Types
{
    public class MessageInputType : InputObjectGraphType
    {
        public MessageInputType()
        {
            Name = "ItemInput";
            Field<NonNullGraphType<IntGraphType>>("id");
            Field<NonNullGraphType<StringGraphType>>("content");
        }
    }
}
