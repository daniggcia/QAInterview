Feature: Hand Tools Filtering
    Scenario: Filter by category 'Hammer' and brand 'Forge Flex Tools'
        Given I am on the homepage
        When I navigate to the "Hand Tools" section from the "Categories" menu
        And I filter by category "Hammer"
        And I filter by brand "ForgeFlex Tools"
        Then all tool prices should be greater than zero