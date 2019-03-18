Feature: AddToBasket
	As AbleandCole web User
	I want to be able to add my shopping items into Basket
	And as well able to remove from my shopping basket 

@mytag
Scenario: Add and Remove from Shopping Basket
	Given I navigate to https://www.abelandcole.co.uk/pantry/chocolate-snacks
	When I click on accept cookies 
	And I click on add button for brownie mini bite
	And I click on plus icon
	And I click on add button for Hummus chips
	And I click on plus sign for Humus chips
	And I click on plus icon for Humus chips
	And I click on add button for simply salted popcorn
	And i click on the basket icon
	And I click on X button to remove simply salted popcorn
	Then I should be able to view my items in the baskets
