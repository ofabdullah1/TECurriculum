﻿using System.Collections.Generic;
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
       

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionMemoryDao();
            }
            else
            {
                dao = auctionDao;
            }
        }

        // Get here with /auctions
        [HttpGet()]

        public List<Auction> ListAuctions(string title_like = "", double currentBid_lte = 0)
        {
            
            if(title_like !=null && currentBid_lte > 0)
            {
                return dao.SearchByTitleAndPrice(title_like,currentBid_lte);
            }
            if(title_like != null)
            {
                return dao.SearchByTitle(title_like);
            }
            else if(currentBid_lte > 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }
            else
            {
            return dao.List();
            }
            
        }

        [HttpGet("{id}")]

        public ActionResult<Auction> GetAuction(int id)
        {
            Auction auction = dao.Get(id);


            if (auction != null)
            {
                return Ok(auction);
            }
            else
            {
                return NoContent();
            }

        }

        [HttpPost()]
        public ActionResult<Auction> CreateReservation(Auction auction)
        {
            Auction result = dao.Create(auction);
            if (result == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(result);
            }
        }


        
    }
}
