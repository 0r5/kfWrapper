using System;
using System.Net;
using Newtonsoft.Json.Linq;
using kfWrapper.API.Endpoints;
using System.Text;
using kfWrapper.API.Utils;

namespace kfWrapper.API
{
    public class Groups
    {
        static string? groupID;

        public static void FromID(string id)
        {
            groupID = id;
        }

        public static string GetInfo(string method)
        {

            if (groupID == null) { return "bruh"; }

            using (WebClient client = new WebClient())
            {
                string api = client.DownloadString(Endpoints.Endpoints.Group(groupID));
                JToken data = JToken.Parse(api);
                try
                {
                    if (method.ToLower() == "owner")
                    {
                        return data["data"][0]["owner"]["id"].ToString();
                    }
                    else
                    {
                        return data["data"][0][method.ToLower()].ToString();
                    }

                }
                catch
                {
                    Console.WriteLine("Oops, something went wrong!");
                }


            }
            return String.Empty;
        }
    }


    public class Games
    {
        static string? group;
        static string? user_id;

        public static void FromGroup(string id)
        {
            group = id;
        }

        public static void FromUser(string id)
        {
            user_id = id;
        }

        public static string GroupGameInfo(string method)
        {
            if (group == null) { return "not ok"; }

            using (WebClient client = new WebClient())
            {
                string api = client.DownloadString(Endpoints.Endpoints.GroupGame(group));
                JToken game_data = JToken.Parse(api);

                try
                {
                    if (method.ToLower() == "creator")
                    {
                        return game_data["data"][0]["creator"]["id"].ToString();
                    } else if (method.ToLower() == "visits")
                    {
                        return game_data["data"][0]["placeVisits"].ToString();
                    } else
                        return game_data["data"][0][method.ToLower()].ToString();

                } 
                catch
                {
                    Console.WriteLine("Oops, something went wrong!");
                }

            }

            return String.Empty;

        }

    }
    public class Assets
    {
        static string? id;

        public static void FromID(string asset_id)
        {
            id = asset_id;
        }

        public static string GetInfo(string method)
        {
            if (id == null) { return "not ok"; }

            using (WebClient client = new WebClient())
            {
                string api = client.DownloadString(Endpoints.Endpoints.Asset(id));
                JToken data = JToken.Parse(api);

                try
                {
                    if (method == "CreatorName")
                    {
                        return data["Creator"]["Name"].ToString();
                    } else if (method == "CreatorId")
                    {
                        return data["Creator"]["Id"].ToString();
                    } else
                    {
                        return data[method].ToString();
                    }
                }
                catch
                {
                    Console.WriteLine("Oops, something went wrong!");
                }

            }
            return String.Empty;
        }
    }
    public class UserDetails
    {
        static string? id;

        public static void SetID(string user_id)
        {
            id = user_id;
        }

        public static string GetInfo(string method)
        {
            if (id == null) { return "not ok"; }

            using (WebClient client = new WebClient())
            {
                string api = client.DownloadString(Endpoints.Endpoints.UserDetails(id));
                JToken data = JToken.Parse(api);
                
                try
                {
                    if (method == "DisplayName")
                    {
                        return data["displayName"].ToString();
                    } else if (method == "IsBanned")
                    {
                        return data["isBanned"].ToString();
                    } else
                    {
                        return data[method.ToLower()].ToString();
                    }
                }
                catch
                {
                    Error.ShowError("while getting user details!");
                }
            }
            return String.Empty;
        }
    }
}