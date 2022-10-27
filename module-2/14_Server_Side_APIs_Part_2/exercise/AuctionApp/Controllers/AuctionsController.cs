using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao)
        {
            dao = auctionDao;
        }

        [HttpGet]
        public List<Auction> List(string title_like = "", double currentBid_lte = 0)
        {
            if (title_like != "")
            {
                return dao.SearchByTitle(title_like);
            }
            if (currentBid_lte > 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }

            return dao.List();
        }

        [HttpGet("{id}")]
        public ActionResult<Auction> Get(int id)
        {
            Auction auction = dao.Get(id);
            if (auction != null)
            {
                return Ok(auction);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Auction> Create(Auction auction)
        {
            Auction added = dao.Create(auction);
            return Created($"/auctions/{added.Id}", added);
           
            if(added != null)
            {
                return Created($"/auctions/{added.Id}", added);
            }

            return NotFound();
            

            
        }


        [HttpPut("{id}")]
        public ActionResult<Auction> Update(int id, Auction auction)
        {
            var result = dao.Get(id);

            if(result == null)
            {
                return NotFound();
            }

            if(auction.Id != auction.Id)
            {
                return BadRequest();
            }

            return auction;
        }

        [HttpDelete("/auctions/{id}")]
        public ActionResult<Auction> Delete(int id)
        {
           if (dao.Delete(id))
            {
                return NoContent();
            }
            return NotFound();
        }

            
    }
}
