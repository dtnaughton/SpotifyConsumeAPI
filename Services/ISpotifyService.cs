using SpotifyConsumeAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotifyConsumeAPI.Services
{
    public interface ISpotifyService
    {
        Task<IEnumerable<Release>> GetNewRelease(string countryCode, int limit, string token);
    }
}
