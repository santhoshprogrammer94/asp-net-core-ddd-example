﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AspNetCore.Example.Application.Mapping.Response
{
    public class Response
    {
        private readonly IList<string> _messages = new List<string>();

        public IEnumerable<string> Errors { get; }

        public object Result { get; }

        public Response() => Errors = new ReadOnlyCollection<string>(_messages);

        public Response(object result) : this() => Result = result;

        public bool IsValid() => !Errors.Any();

        public Response AddError(string message)
        {
            _messages.Add(message);
            return this;
        }
    }
}
