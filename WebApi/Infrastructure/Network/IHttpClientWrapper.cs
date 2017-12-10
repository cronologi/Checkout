using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Network
{
    public interface IHttpClientWrapper
    {
        void Post(string address, string json);
    }
}
