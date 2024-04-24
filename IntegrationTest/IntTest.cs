using Bunit;
using Plantes;
using Plantes.Components.Pages;
using System.ComponentModel;

namespace IntegrationTest
{
    public class IntTest : TestContext
    {
        [Fact]
        public void ChangeFav()
        {
            var renderedPlant = RenderComponent<Home>();

            renderedPlant.Find("button").Click();
            renderedPlant.Find("h1").MarkupMatches("<h1>Hello Martin.</h1>");
        }
    }
}