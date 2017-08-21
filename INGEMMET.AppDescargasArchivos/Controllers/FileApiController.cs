using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace INGEMMET.AppDescargasArchivos.Controllers
{
    public class FileApiController : ApiController
    {
        private static HttpClient Client = new HttpClient();

        public async Task<HttpResponseMessage> Get()
        {
            try
            {                
                var stream = await Client.GetStreamAsync("http://geocatminapp.ingemmet.gob.pe/complementos/descargas/Mapas/Geologia50/28-s1.zip");
                FileStream fileStream = stream as FileStream;               

                var result = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StreamContent(stream),
                };
                
                result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                result.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
                result.Content.Headers.ContentDisposition.FileName = fileStream.Name;

                return result;
            }
            catch (Exception ex)
            {             
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }


        //// Sample content used to demonstrate range requests     
        //private static readonly byte[] _content = File.ReadAllBytes(HttpContext.Current.Server.MapPath("~/Content/airports.csv"));

        //// Content type for our body
        //private static readonly MediaTypeHeaderValue _mediaType = MediaTypeHeaderValue.Parse("text/csv");

        //public HttpResponseMessage Get(bool IsLengthOnly)
        //{
        //    //if only length is requested
        //    if (IsLengthOnly)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, _content.Length);
        //    }
        //    else
        //    {
        //        MemoryStream memStream = new MemoryStream(_content);

        //        // Check to see if this is a range request (i.e. contains a Range header field)               
        //        if (Request.Headers.Range != null)
        //        {
        //            try
        //            {
        //                HttpResponseMessage partialResponse = Request.CreateResponse(HttpStatusCode.PartialContent);
        //                partialResponse.Content = new ByteRangeStreamContent(memStream, Request.Headers.Range, _mediaType);
        //                return partialResponse;
        //            }
        //            catch (InvalidByteRangeException invalidByteRangeException)
        //            {
        //                return Request.CreateErrorResponse(invalidByteRangeException);
        //            }
        //        }
        //        else
        //        {
        //            // If it is not a range request we just send the whole thing as normal
        //            HttpResponseMessage fullResponse = Request.CreateResponse(HttpStatusCode.OK);
        //            fullResponse.Content = new StreamContent(memStream);
        //            fullResponse.Content.Headers.ContentType = _mediaType;
        //            return fullResponse;
        //        }
        //    }
        //}
    }
}

