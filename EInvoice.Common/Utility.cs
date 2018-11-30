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

		private static string Chu(string gNumber)
		{
			var result = "";
			switch (gNumber)
			{
				case "0":
					result = "không";
					break;
				case "1":
					result = "một";
					break;
				case "2":
					result = "hai";
					break;
				case "3":
					result = "ba";
					break;
				case "4":
					result = "bốn";
					break;
				case "5":
					result = "năm";
					break;
				case "6":
					result = "sáu";
					break;
				case "7":
					result = "bảy";
					break;
				case "8":
					result = "tám";
					break;
				case "9":
					result = "chín";
					break;
			}
			return result;
		}

		private static string Donvi(string so)
		{
			var Kdonvi = "";

			if (so.Equals("1"))
				Kdonvi = "";
			if (so.Equals("2"))
				Kdonvi = "nghìn";
			if (so.Equals("3"))
				Kdonvi = "triệu";
			if (so.Equals("4"))
				Kdonvi = "tỷ";
			if (so.Equals("5"))
				Kdonvi = "nghìn tỷ";
			if (so.Equals("6"))
				Kdonvi = "triệu tỷ";
			if (so.Equals("7"))
				Kdonvi = "tỷ tỷ";

			return Kdonvi;
		}

		private static string Tach(string tach3)
		{
			var Ktach = "";
			if (tach3.Equals("000"))
				return "";
			if (tach3.Length == 3)
			{
				var tr = tach3.Trim().Substring(0, 1).ToString().Trim();
				var ch = tach3.Trim().Substring(1, 1).ToString().Trim();
				var dv = tach3.Trim().Substring(2, 1).ToString().Trim();
				if (tr.Equals("0") && ch.Equals("0"))
					Ktach = " không trăm lẻ " + Chu(dv.ToString().Trim()) + " ";
				if (!tr.Equals("0") && ch.Equals("0") && dv.Equals("0"))
					Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm ";
				if (!tr.Equals("0") && ch.Equals("0") && !dv.Equals("0"))
					Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm lẻ " + Chu(dv.Trim()).Trim() + " ";
				if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
					Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
				if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
					Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi ";
				if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
					Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
				if (tr.Equals("0") && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
					Ktach = " không trăm mười " + Chu(dv.Trim()).Trim() + " ";
				if (tr.Equals("0") && ch.Equals("1") && dv.Equals("0"))
					Ktach = " không trăm mười ";
				if (tr.Equals("0") && ch.Equals("1") && dv.Equals("5"))
					Ktach = " không trăm mười lăm ";
				if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
					Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
				if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
					Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi ";
				if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
					Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
				if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
					Ktach = Chu(tr.Trim()).Trim() + " trăm mười " + Chu(dv.Trim()).Trim() + " ";

				if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("0"))
					Ktach = Chu(tr.Trim()).Trim() + " trăm mười ";
				if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("5"))
					Ktach = Chu(tr.Trim()).Trim() + " trăm mười lăm ";

			}

			return Ktach;
		}

		public static string Num2Word(double gNum)
		{
			if (gNum == 0)
				return "Không đồng";

			var lso_chu = "";
			var tach_mod = "";
			var tach_conlai = "";
			var Num = Math.Round(gNum, 0);
			var gN = Convert.ToString(Num);
			var m = Convert.ToInt32(gN.Length / 3);
			var mod = gN.Length - m * 3;
			var dau = "[+]";

			// Dau [+ , - ]
			if (gNum < 0)
				dau = "[-]";
			dau = "";

			// Tach hang lon nhat
			if (mod.Equals(1))
				tach_mod = "00" + Convert.ToString(Num.ToString().Trim().Substring(0, 1)).Trim();
			if (mod.Equals(2))
				tach_mod = "0" + Convert.ToString(Num.ToString().Trim().Substring(0, 2)).Trim();
			if (mod.Equals(0))
				tach_mod = "000";
			// Tach hang con lai sau mod :
			if (Num.ToString().Length > 2)
				tach_conlai = Convert.ToString(Num.ToString().Trim().Substring(mod, Num.ToString().Length - mod)).Trim();

			///don vi hang mod
			var im = m + 1;
			if (mod > 0)
				lso_chu = Tach(tach_mod).ToString().Trim() + " " + Donvi(im.ToString().Trim());
			/// Tach 3 trong tach_conlai

			var i = m;
			var _m = m;
			var j = 1;
			var tach3 = "";
			var tach3_ = "";

			while (i > 0)
			{
				tach3 = tach_conlai.Trim().Substring(0, 3).Trim();
				tach3_ = tach3;
				lso_chu = lso_chu.Trim() + " " + Tach(tach3.Trim()).Trim();
				m = _m + 1 - j;
				if (!tach3_.Equals("000"))
					lso_chu = lso_chu.Trim() + " " + Donvi(m.ToString().Trim()).Trim();
				tach_conlai = tach_conlai.Trim().Substring(3, tach_conlai.Trim().Length - 3);

				i = i - 1;
				j = j + 1;
			}
			if (lso_chu.Trim().Substring(0, 1).Equals("k"))
				lso_chu = lso_chu.Trim().Substring(10, lso_chu.Trim().Length - 10).Trim();
			if (lso_chu.Trim().Substring(0, 1).Equals("l"))
				lso_chu = lso_chu.Trim().Substring(2, lso_chu.Trim().Length - 2).Trim();
			if (lso_chu.Trim().Length > 0)
				lso_chu = dau.Trim() + " " + lso_chu.Trim().Substring(0, 1).Trim().ToUpper() + lso_chu.Trim().Substring(1, lso_chu.Trim().Length - 1).Trim() + " đồng chẵn.";

			return lso_chu.ToString().Trim();
		}

	
	}
}