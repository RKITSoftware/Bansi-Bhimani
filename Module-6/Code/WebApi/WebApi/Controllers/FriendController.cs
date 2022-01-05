using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class FriendList
    {
    List<Friend> friends = new List<Friend>();
    public FriendList()
    {
        friends.Add(new Friend { id = 1, firstname="Bansi", lastname="Bhimani", location="Rajkot", hiredate=DateTime.Today });
        friends.Add(new Friend() { id = 2, firstname = "Vishwa", lastname = "Bhimani", location = "Rajkot", hiredate = DateTime.Today });
        friends.Add(new Friend() { id = 3, firstname = "Hetvi", lastname = "Patel", location = "Surat", hiredate = DateTime.Today });
        friends.Add(new Friend() { id = 4, firstname = "Komal", lastname = "Dangar", location = "Rajkot", hiredate = DateTime.Today });
        }

    public List<Friend> GetCompleteList()
    {
        return friends;
    }

    public Friend GetListByID(int id)
    {
        return friends.Where(temp => temp.id == id).FirstOrDefault();

    }

    public void AddItem(Friend newFriend)
    {
        friends.Add(newFriend);
    }

    public void RemoveItem(int id)
    {
        friends.Remove(friends.Where(x => x.id == id).FirstOrDefault());
    }

    public void EditItem(int id, Friend EditFriend)
    {
        friends[id] = EditFriend;
    }
}
    public class FriendController : ApiController
    {
        FriendList objFriendList = new FriendList();
        // Read all friend 
        public List<Friend> Get()
        {
            List<Friend> friends= objFriendList.GetCompleteList();
            return friends;
        }

        // Read friend by id
        public Friend Get(int id)
        {
            return objFriendList.GetListByID(id);
        }

        // add friend
        public void Post(Friend newFriend)
        {
            objFriendList.AddItem(newFriend);
        }

        // edit friend by id
        public void Put(int id, Friend editFriend)
        {
            objFriendList.EditItem(id, editFriend);
        }

        // Delete friend
        public void Delete(int id)
        {
            objFriendList.RemoveItem(id);
        }
    }
    
}
