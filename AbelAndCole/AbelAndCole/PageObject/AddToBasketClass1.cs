using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbelAndCole.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AbelAndCole.PageObject
{
    public class AddToBasketClass1


    {
        public AddToBasketClass1()
        {
            PageFactory.InitElements(Hooks1.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='ccc-notify-accept']")]
        private IWebElement accept { get; set; }

        public void ClickAccept()

        {
            accept.Click();
        }

        [FindsBy(How = How.CssSelector, Using = "li.product-item:nth-child(2) > div:nth-child(3) > div:nth-child(3) > div:nth-child(2) > div:nth-child(1)")]
        private IWebElement addbutton { get; set; }

        public void AddButton()

        {
            addbutton.Click();
        }

        [FindsBy(How = How.CssSelector, Using = "li.product-item:nth-child(2) > div:nth-child(3) > div:nth-child(3) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(3)")]
        private IWebElement plussign { get; set; }

        public void ClickPlusSign()

        {
            plussign.Click();
        }

        [FindsBy(How = How.CssSelector, Using = "li.product-item:nth-child(3) > div:nth-child(3) > div:nth-child(3) > div:nth-child(2) > div:nth-child(1)")]
        private IWebElement addbuttonhummus { get; set; }

        public void ClickAddButtonHummus()

        {
            addbuttonhummus.Click();
        }

        [FindsBy(How = How.CssSelector, Using = "li.product-item:nth-child(3) > div:nth-child(3) > div:nth-child(3) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(3)")]
        private IWebElement plussignhummus { get; set; }

        public void ClickPlusSignHummus()

        {
            plussignhummus.Click();
        }

        [FindsBy(How = How.CssSelector, Using = "li.product-item:nth-child(3) > div:nth-child(3) > div:nth-child(3) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(3)")]
        private IWebElement plusiconhummus1 { get; set; }

        public void ClickPlusIconHummus1()

        {
            plusiconhummus1.Click();
        }

        [FindsBy(How = How.CssSelector, Using = "li.product-item:nth-child(7) > div:nth-child(3) > div:nth-child(3) > div:nth-child(2) > div:nth-child(1)")]
        private IWebElement addsignsimplysalted { get; set; }

        public void ClickAddSignSimplySalted()

        {
            addsignsimplysalted.Click();
        }

        [FindsBy(How = How.Id, Using = "BasketCount")]
        private IWebElement basketicon { get; set; }

        public void ClickBasketIcon()

        {
            basketicon.Click();
        }

        [FindsBy(How = How.CssSelector, Using = "div.basket-product:nth-child(3) > div:nth-child(3) > img:nth-child(1)")]
        private IWebElement removesimplysalted { get; set; }

        public void ClickRemoveSimplySalted()

        {
            removesimplysalted.Click();
        }

        [FindsBy(How = How.CssSelector, Using = ".green-message")]
        private IWebElement greenmessage { get; set; }

        public bool IsGreenMsgDisplayed()

        {
            return greenmessage.Displayed;
        }
    }
}