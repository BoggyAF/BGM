using System;
using System.Collections.Generic;
using System.Text;
using Jose;

namespace BGM
{
    class RestService
    {
        protected string apiBaseURL = "https://blaketrader.com/bv2_ui_fe/api/v1/";
        protected string accessToken = "HkywP5pW1JJUrjMEQxMbAGadJyUbDt5s";
        protected string accessTokenSecret = "n6kD5Qirqg2c6e8Nf4FkGmnKhjfG2EFM7FSV1ei1kc6NQF2nY6AprwfHTNuGMaAr";
        protected int oapNum = 3;
        protected int uiServerID = 1;
        protected string iss = "https://www.blakegames.com";
        protected string aud = "https://www.blakegames.com";
        public string token = "";

        //sort type?
        public void getInventory()
        {
            string apiURL = "getinventory.php";
            string fullURL = $"{apiBaseURL}.{apiURL}";

            token = Jose.JWT.Encode(accessToken, accessTokenSecret, JwsAlgorithm.HS256);
            System.Diagnostics.Debug.WriteLine(token);

        }
    }
}
