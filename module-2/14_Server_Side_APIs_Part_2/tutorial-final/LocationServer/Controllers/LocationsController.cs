﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Locations.DAO;
using Locations.Models;

namespace Locations.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationDao locationDao;

        public LocationsController(ILocationDao locationDao)
        {
            this.locationDao = locationDao;
        }

        [HttpGet]
        public List<Location> List()
        {
            return locationDao.List();
        }

        [HttpGet("{id}")]
        public ActionResult<Location> Get(int id)
        {
            Location location = locationDao.Get(id);
            if (location != null)
            {
                return Ok(location);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Location> Add(Location location)
        {
            Location returnLocation = locationDao.Create(location);
            return Created($"/locations/{returnLocation.Id}", returnLocation);
        }

        [HttpPut("{id}")]
        public ActionResult<Location> Update(int id, Location location)
        {
            Location existingLocation = locationDao.Get(id);
            if (existingLocation == null)
            {
                return NotFound();
            }

            Location result = locationDao.Update(id, location);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Location location = locationDao.Get(id);
            if (location == null)
            {
                return NotFound();
            }

            locationDao.Delete(id);
            return NoContent();
        }
    }
}
