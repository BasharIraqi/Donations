using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Donations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationController : ControllerBase
    {
        private AllDonations _donations;

        public DonationController()
        {
            _donations = new AllDonations();
        }
       
        [HttpPost("give/{firstName}/{lastName}")]
        public IActionResult Give([FromRoute]string firstName,[FromRoute] string lastName, [FromQuery] int amount,[FromQuery]int numDon, [FromBody] don don )
        {
            _donations.SumDon(amount);
            return Ok($"{firstName} {lastName} donated {amount} Donation nmuber: {numDon}  date: {don.Date} time: {don.generosity} \n Total donations: {_donations.AllDon()}");
        }
           
    }
}
