using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    
    
        public class FriendController : ApiController
    {
        List<Friend> friends = new List<Friend>
        {
            new Friend(1,"Bansi","Bhimani","Rajkot",DateTime.Today),
            new Friend(2,"Kishan","Patel","Rajkot",DateTime.Today),
            new Friend(3,"Vishwa","Bhimani","Surat",DateTime.Today),
            new Friend(4,"Shrey","Patel","Ahmedabad",DateTime.Today)
        };
        //GET :api/Friend
        [HttpGet]
        public List<Friend> Get()
        {
            return friends;
        }

        // GET: api/Friend/5
        [HttpGet]
        public Friend Get(int id)
        {
            Friend friend = friends.Find(f => f.id == id);
            return friend;
        }
        // POST: api/Friend
        [HttpPost]
        public List<Friend> Post([FromBody]Friend friend)
        {
            friends.Add(friend);
            return friends;
        }

        // PUT: api/Friend/5
        [HttpPut]
        public List<Friend> Put(int id, [FromBody]Friend friend)
        {
            Friend friendToUpdate = friends.Find(f => f.id == id);
            int index = friends.IndexOf(friendToUpdate);

            friends[index].firstname = friend.firstname;
            friends[index].lastname = friend.lastname;
            friends[index].location = friend.location;
            friends[index].dateOfHire = friend.dateOfHire;

            return friends;
        }

        // DELETE: api/Friend/5
        [HttpDelete]
        public List<Friend> Delete(int id)
        {
            Friend friend = friends.Find(f => f.id == id);
            friends.Remove(friend);
            return friends;
        }
    }
}
