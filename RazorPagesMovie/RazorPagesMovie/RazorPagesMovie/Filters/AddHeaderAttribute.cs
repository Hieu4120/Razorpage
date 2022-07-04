﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RazorPagesMovie.Filters
{
    public class AddHeaderAttribute : ResultFilterAttribute
    {
        private readonly string _name;
        private readonly string _value;

        public AddHeaderAttribute(string name, string value)
        {
            _name = name;
            _value = value;
        }

        public AddHeaderAttribute(string v, string[] vs)
        {
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add(_name, new string[] { _value });
        }
    
    }
}
