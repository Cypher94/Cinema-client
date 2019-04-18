using FluentAssertions;
using OpenQA.Selenium;

namespace CinemaClient.Spec.PageObjects
{
    public class Navigation
    {
        private readonly IWebDriver _visitorBrowser;

        private const string NavigationBarSelector = "//nav[@class='navigation']/div[@class='navigation-panel']";
        private const string LogoSelector = NavigationBarSelector + "/span[@class='navigation-logo']";
        private const string HomePageBtnSelector = NavigationBarSelector + "/a[1]";
        private const string ProgramPageBtnSelector = NavigationBarSelector + "/a[2]";
        private const string EventsPageBtnSelector = NavigationBarSelector + "/a[3]";
        private const string NewsPageBtnSelector = NavigationBarSelector + "/a[4]";
        private const string ContactPageBtnSelector = NavigationBarSelector + "/a[5]";

        public IWebElement NavigationBarElement { get; set; }
        public IWebElement LogoElement { get; set; }
        public IWebElement HomePageBtnElement { get; set; }
        public IWebElement ProgramPageBtnElement { get; set; }
        public IWebElement EventsPageBtnElement { get; set; }
        public IWebElement NewsPageBtnElement { get; set; }
        public IWebElement ContactPageBtnElement { get; set; }

        public Navigation(IWebDriver visitorBrowser)
        {
            _visitorBrowser = visitorBrowser;
        }

        private void FindNavigationElements()
        {
            NavigationBarElement = _visitorBrowser.FindElement(By.XPath(NavigationBarSelector));
            LogoElement = _visitorBrowser.FindElement(By.XPath(LogoSelector));
            HomePageBtnElement = _visitorBrowser.FindElement(By.XPath(HomePageBtnSelector));
            ProgramPageBtnElement = _visitorBrowser.FindElement(By.XPath(ProgramPageBtnSelector));
            EventsPageBtnElement = _visitorBrowser.FindElement(By.XPath(EventsPageBtnSelector));
            NewsPageBtnElement = _visitorBrowser.FindElement(By.XPath(NewsPageBtnSelector));
            ContactPageBtnElement = _visitorBrowser.FindElement(By.XPath(ContactPageBtnSelector));
        }

        public void CheckIfNavgationElementsExist()
        {
            FindNavigationElements();
            NavigationBarElement.Should().NotBeNull();
            LogoElement.Should().NotBeNull();
            HomePageBtnElement.Should().NotBeNull();
            ProgramPageBtnElement.Should().NotBeNull();
            EventsPageBtnElement.Should().NotBeNull();
            NewsPageBtnElement.Should().NotBeNull();
            ContactPageBtnElement.Should().NotBeNull();
        }
    }
}
