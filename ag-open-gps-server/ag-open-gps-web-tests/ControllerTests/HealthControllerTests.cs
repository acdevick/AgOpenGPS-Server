using ag_open_gps_web.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace ag_open_gps_web_tests.ControllerTests
{
    public class HealthControllerTests
    {
        private readonly HealthController _healthController;
        
        public HealthControllerTests()
        {
            _healthController = new HealthController();  
        }
        
        [Fact]
        public void ShouldReturnPong()
        {
            var expected = "pong";
            
            var result = _healthController.Get();
            
            var okObject = result as OkObjectResult;
            
            okObject?.Value.Should().BeEquivalentTo(expected);
        }
    }
}