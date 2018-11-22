using System;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Text.RegularExpressions;

namespace EInvoice.Common
{
	public static class Utility
	{
		public static DateTime GetNistTime()
		{
			var dateTime = DateTime.MinValue;

			var request = (HttpWebRequest)WebRequest.Create("http://nist.time.gov/actualtime.cgi?lzbc=siqm9b");
			request.Method = "GET";
			request.Accept = "text/html, application/xhtml+xml, */*";
			request.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; Trident/6.0)";
			request.ContentType = "application/x-www-form-urlencoded";
			request.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore); //No caching
			var response = (HttpWebResponse)request.GetResponse();
			if (response.StatusCode == HttpStatusCode.OK)
			{
				var stream = new StreamReader(response.GetResponseStream());
				var html = stream.ReadToEnd();//<timestamp time=\"1395772696469995\" delay=\"1395772696469995\"/>
				var time = Regex.Match(html, @"(?<=\btime="")[^""]*").Value;
				var milliseconds = Convert.ToInt64(time) / 1000.0;
				dateTime = new DateTime(1970, 1, 1).AddMilliseconds(milliseconds).ToLocalTime();
			}

			return dateTime;
		}
	}
}