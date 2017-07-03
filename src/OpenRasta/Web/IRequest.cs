
using System;
using System.Collections.Generic;
using System.Globalization;

namespace OpenRasta.Web
{
    public interface IRequest : IHttpMessage
    {
        /// <summary>
        /// The request Uri
        /// </summary>
        Uri Uri { get; set; }
        /// <summary>
        /// The name associated with the requested URI
        /// </summary>
        string UriName { get; set; }
        /// <summary>
        /// The culture in which the resource has been requested by the client.
        /// </summary>
        CultureInfo NegotiatedCulture { get; set; }
        /// <summary>
        /// The HTTP method used.
        /// </summary>
        string HttpMethod { get; set; }

        IList<string> CodecParameters { get; }
    }
}

#region Full license
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
#endregion