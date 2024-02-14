using App.Service;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("api")]
    public class LongestIncreasingSubsequenceController : ControllerBase
    {
        private readonly ILongestIncreasingSubsequenceService _service;

        public LongestIncreasingSubsequenceController(ILongestIncreasingSubsequenceService service)
        {
            _service = service;
        }

        [HttpGet]
        public string FindLongestIncreasingSubsequence(string input)
        {
            if (_service.ValidateInput(input) == false)
            {
                return "Invalid format, try again";
            };

            return _service.FindLongestIncreasingSubsequence(input);
        }
    }
}
