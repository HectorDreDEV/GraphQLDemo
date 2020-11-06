using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.Samples.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
    }

    public static class Data
    {
        public static List<Message> Messages = new List<Message>();

        public static IObservable<Message> AllMessages()
        {
            return Messages.ToObservable();
        }
    }
}
