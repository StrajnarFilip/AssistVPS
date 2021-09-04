using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace PublicIp
{
    public class PublicIp
    {
        public static string GetMyIP()
        {
            var services = new string[] {
                    "http://icanhazip.com/",
                    "https://wtfismyip.com/text",
                    "https://checkip.amazonaws.com/",
                    "https://api.ipify.org/",
                    "http://ipinfo.io/ip"
                };
            var responses = services
            .Select((service) =>
            {
                try
                {
                    return new HttpClient()
                        .GetAsync(service).Result.Content
                        .ReadAsStringAsync().Result
                        .TrimEnd();
                }
                catch
                {
                    return "";
                }
            }
            );

            var distinct_ips = responses.Distinct();
            var max_count = distinct_ips.Select(x => responses.Count(y => y == x)).Max();

            var most_common_result = distinct_ips.First(distinct => responses.Count(x => x == distinct) == max_count);

            return most_common_result;
        }
    }
}
