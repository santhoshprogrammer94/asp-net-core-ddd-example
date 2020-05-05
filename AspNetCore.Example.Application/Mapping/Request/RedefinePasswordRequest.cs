﻿using MediatR;
using System;

namespace AspNetCore.Example.Application.Mapping.Request
{
    public class RedefinePasswordRequest:IRequest<string>
    {
        public Guid? Id { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }      
    }
}
