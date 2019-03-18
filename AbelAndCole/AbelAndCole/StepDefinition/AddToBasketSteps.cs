using System;
using AbelAndCole.PageObject;
using AbelAndCole.Utilities;
using TechTalk.SpecFlow;

namespace AbelAndCole.StepDefinition
{
    [Binding]
    public class AddToBasketSteps
    {

        AddToBasketClass1 addtobasketclass1;

        public AddToBasketSteps()
        {
            addtobasketclass1 = new AddToBasketClass1();
        }
        

        [Given(@"I navigate to https://www\.abelandcole\.co\.uk/pantry/chocolate-snacks")]
        public void GivenINavigateToHttpsWww_Abelandcole_Co_UkPantryChocolate_Snacks()
        {
            Hooks1.Driver.Navigate().GoToUrl("https://www.abelandcole.co.uk/pantry/chocolate-snacks");
            Hooks1.Driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(7000);
        }
        
        [When(@"I click on accept cookies")]
        public void WhenIClickOnAcceptCookies()
        {
            addtobasketclass1.ClickAccept();
            System.Threading.Thread.Sleep(7000);
        }
        
        [When(@"I click on add button for brownie mini bite")]
        public void WhenIClickOnAddButtonForBrownieMiniBite()
        {
            addtobasketclass1.AddButton();
        }

        [When(@"I click on plus icon")]
        public void WhenIClickOnPlusIcon()
        {
            addtobasketclass1.ClickPlusSign();
        }


        [When(@"I click on add button for Hummus chips")]
        public void WhenIClickOnAddButtonForHummusChips()
        {
            addtobasketclass1.ClickAddButtonHummus();
        }

        [When(@"I click on plus sign for Humus chips")]
        public void WhenIClickOnPlusSignForHumusChips()
        {
            addtobasketclass1.ClickPlusSignHummus();
        }


       

        [When(@"I click on plus icon for Humus chips")]
        public void WhenIClickOnPlusIconForHumusChips()
        {
            addtobasketclass1.ClickPlusIconHummus1();
        }



        [When(@"I click on add button for simply salted popcorn")]
        public void WhenIClickOnAddButtonForSimplySaltedPopcorn()
        {
            addtobasketclass1.ClickAddSignSimplySalted();
        }
        
        
        
        [When(@"i click on the basket icon")]
        public void WhenIClickOnTheBasketIcon()
        {
            addtobasketclass1.ClickBasketIcon();
        }

        [When(@"I click on X button to remove simply salted popcorn")]
        public void WhenIClickOnXButtonToRemoveSimplySaltedPopcorn()
        {
            addtobasketclass1.ClickRemoveSimplySalted();
        }


        [Then(@"I should be able to view my items in the baskets")]
        public void ThenIShouldBeAbleToViewMyItemsInTheBaskets()
        {
            addtobasketclass1.IsGreenMsgDisplayed();
        }


    }
}
