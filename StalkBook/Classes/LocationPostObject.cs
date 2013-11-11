using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StalkBook.Classes
{
    public class LocationPostObject
    {
        String userID;         //the id of the User who made the post
        double latitude;       //latitude of the location post
        double longitude;      //longitude of the location post
        String timeOfPost;     //the Facebook formatted string for when the post was made
        String city;           //the city of the post (to be combined in the toString()
        String state;          //the state of the post (to be combined in the toString(). This should be the US Government designation (South Carolina = SC)
        String ZIP;            //the ZIP code of the post (to be combined in the toString()
        
        //Default Constructor- in case we want to create a dummy value for indexing 
        public LocationPostObject()
        {
            userID = "";
            latitude = 0.0;
            longitude = 0.0;
            timeOfPost = "";
            city = "";
            state = "";
            ZIP = "";
        }

        //Constructor- takes the information from the Facebook Query to create a LocationPostObject to be linked in another class
        public LocationPostObject(String uid, double lat, double lon, String postTime, String city_loc, String state_loc, String zip_loc)
        {
            userID = uid;
            latitude = lat;
            longitude = lon;
            timeOfPost = postTime;
            city = city_loc;
            state = state_loc;
            ZIP = zip_loc;
            
        }





    }
}