using ChatBlazorLive.Shared;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatBlazorLive.Server.Hubovi
{
	public class ChatHub : Hub
	{
		public void PrimiPoruku(ChatPoruka poruka)
		{
			Console.WriteLine($"[{poruka.VremeSlanja}] {poruka.Korisnik}: {poruka.Sadrzaj}");
			Clients.All.SendAsync("pp", poruka);
		}
	}
}
