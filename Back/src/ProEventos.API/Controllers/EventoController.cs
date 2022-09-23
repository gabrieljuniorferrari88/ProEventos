using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class EventoController : ControllerBase
	{

		public EventoController()
		{
		}

		public IEnumerable<Evento> _evento = new Evento[]
			{
				new Evento()
				{
					EventoId = 1,
					Tema = "Angular e .Net 5",
					Local = "BH",
					Lote = "1 lote",
					QtdPessoas = 20,
					DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
					ImagemURL = "https://github.com/gabrieljuniorferrari88.png",
				},
				new Evento()
				{
					EventoId = 2,
					Tema = "dotNet MVC",
					Local = "BH",
					Lote = "1 lote",
					QtdPessoas = 10,
					DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
					ImagemURL = "https://github.com/gabrieljuniorferrari88.png",
				},

			};

		[HttpGet]
		public IEnumerable<Evento> Get()
		{
			return _evento;
		}

		[HttpGet("{id}")]
		public IEnumerable<Evento> GetById(int id)
		{
			return _evento.Where(x => x.EventoId == id);
		}

		[HttpPost]
		public string Post()
		{
			return "Post";
		}

		[HttpPut("{id}")]
		public string Put(int id)
		{
			return $"Alterar o evento com id: {id}";
		}

		[HttpDelete("{id}")]
		public string Delete(int id)
		{
			return $"Deletar o evento com id: {id}";
		}
	}
}
