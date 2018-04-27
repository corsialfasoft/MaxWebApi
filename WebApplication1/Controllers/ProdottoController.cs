using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DraxManUC001.Models;

namespace WebApplication1.Controllers
{
	public class ProdottoController : ApiController
	{
		DomainModel dm = new DomainModel();
		// GET api/<controller>
		public IEnumerable<Prodotto> Get()
		{
			return dm.Search("");
		}

		// GET api/<controller>/5
		public Prodotto Get(int id)
		{
			return dm.Search(id);
		}

		// POST api/<controller>
		public void Post([FromBody]string value)
		{
		}

		// PUT api/<controller>/5
		public void Put(int id,[FromBody]string value)
		{
		}

		// DELETE api/<controller>/5
		public void Delete(int id)
		{
		}
	}
}