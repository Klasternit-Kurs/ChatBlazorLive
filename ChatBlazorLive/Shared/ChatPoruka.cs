using System;
using System.Collections.Generic;
using System.Text;

namespace ChatBlazorLive.Shared
{
	public class ChatPoruka
	{
		public string Korisnik { get; set; }
		public string Sadrzaj { get; set; }
		public DateTime VremeSlanja { get; set; }
	}
}
