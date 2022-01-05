using System.Collections.Generic;
using System.Web.Http;
using CrudDemo.Models;
using CrudDemo.BLClass;

namespace CrudDemo.Controllers
{
    /// <summary>
    /// This is controller class of Friend
    /// </summary>
    public class FriendController : ApiController
    {
        //Object of BL class
        BLfriend objBLfriend = new BLfriend();

        /// <summary>
        /// GetAll method
        /// </summary>
        /// <returns>List<Friend></returns>
        
        // GET all friends
        [Route("api/Getall")]
        public List<Friend> GetAll()
        {
            return (objBLfriend.selectAll());
        }

        /// <summary>
        /// Get Method
        /// </summary>
        /// <param name="id">This is id of friend</param>
        /// <returns>Friend</returns>
        // GET friends by id
        [Route("api/Get/{id}")]
        public Friend Get(int id)
        {
            return (objBLfriend.getFriendById(id));
        }

        /// <summary>
        /// Add Method
        /// </summary>
        // Add friend
        [HttpPost]
        [Route("api/Add")]
        public void Add([FromBody] Friend objFriend)
        {
            objBLfriend.addFriend(objFriend);
        }

        /// <summary>
        /// Update Method
        /// </summary>
       //update friend data
        [HttpPost]
        [Route("api/Update")]
        public void Update([FromBody] Friend objFriend)
        {
            objBLfriend.updateFriend(objFriend);
        }

        /// <summary>
        /// Delete Method
        /// </summary>
        /// <param name="id"></param>
        // DELETE friend by id
        [Route("api/Delete/{id}")]
        public void Delete(int id)
        {
            objBLfriend.deleteFriend(id);
        }
    
}
}