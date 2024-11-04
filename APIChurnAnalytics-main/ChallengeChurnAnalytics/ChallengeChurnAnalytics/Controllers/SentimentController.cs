
using ChallengeChurnAnalytics.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeChurnAnalytics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SentimentController : ControllerBase
    {
        private readonly SentimentAnalysisService _sentimentService;

        public SentimentController(SentimentAnalysisService sentimentService)
        {
            _sentimentService = sentimentService;
        }

        [HttpPost("analyze")]
        public IActionResult AnalyzeSentiment(string text)
        {
            var result = _sentimentService.PredictSentiment(text);
            return Ok(new { Sentiment = result });
        }
    }
}
