Feature: Rentals Section

    Scenario: Verify tool titles in Rentals section
        Given I am on the homepage
        When I navigate to the "Rentals" section from the "Categories" menu
        Then the titles of the tools should be displayed correctly      