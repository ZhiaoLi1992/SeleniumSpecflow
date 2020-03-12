using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Youtube
{
    [Binding]
    public class OnlineShoppingFeatureSteps
    {
        IWebDriver driver;

        [Given(@"I have navigated to home page")]
        public void GivenIHaveNavigatedToHomePage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://advantageonlineshopping.com/#/");
            driver.Manage().Window.Maximize();
        }
        
        [Given(@"I see home page fully loaded")]
        public void GivenISeeHomePageFullyLoaded()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        
        [When(@"I click Product")]
        public void WhenIClickProduct()
        {
            IWebElement speakers = driver.FindElement(By.XPath("//*[@id=\"speakersTxt\"]"));
            speakers.Click();
        }
        
        [When(@"I click first speaker in the page")]
        public void WhenIClickFirstSpeakerInThePage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            IWebElement firstSpeaker = driver.FindElement(By.XPath("//*[@id=\"20\"]"));
            firstSpeaker.Click();
        }
        
        [When(@"I click Add to cart")]
        public void WhenIClickAddToCart()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            IWebElement addToCart = driver.FindElement(By.XPath("//*[@id=\"productProperties\"]/div[3]/button"));
            addToCart.Click();
        }
        
        [Then(@"I should see the speakers page shows up")]
        public void ThenIShouldSeeTheSpeakersPageShowsUp()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        
        [Then(@"First speaker detail page shows up")]
        public void ThenFirstSpeakerDetailPageShowsUp()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
    }
}
