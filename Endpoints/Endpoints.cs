using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kfWrapper.API.Endpoints
{
    public static class Endpoints
    {
        public static string Group(string id) => $"https://groups.roblox.com/v2/groups?groupIds={id}";
        public static string GroupGame(string id) => $"https://games.roblox.com/v2/groups/{id}/games?sortOrder=Asc&limit=10";
        public static string Asset(string id) => $"https://api.roblox.com/Marketplace/ProductInfo?assetId={id}";
        public static string UserDetails(string id) => $"https://users.roblox.com/v1/users/{id}";
    }
}
