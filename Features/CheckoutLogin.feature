Feature: Checkout login validation

    Scenario: Try to login with invalid email during checkout
        Given I am on the homepage
        When I navigate to the "Power Tools" section from the "Categories" menu
        And I select the first product
        And I add the product to the cart
        And I go to the cart and proceed to checkout
        And I enter an invalid email and any password
        And I click the login button
        Then I should see an error message for invalid credentials
        
    Scenario: Login with invalid credentials from cart checkout
        Given I am on the homepage
        When I navigate to the "Power Tools" section from the "Categories" menu
        And I select the first product
        And I add the product to the cart
        And I proceed to checkout
        And I enter invalid email "invalid@example.com" and password "123456"
        And I attempt to login
        Then I should see an error message for invalid credentials