Feature: Create an Item above
As a logged user, the user wants to create an item above the item selected so that he can keep manage the order of the tasks.

Background:
    Given the user is logged in
        And the user has an existing project
        And the project has one or more existing items

    @Draft
    @Acceptance
    Scenario: Create an Item above Successfully
        Given the user clicks on an item
        When the user clicks on the Add item above
        Then the user enters an item name
        Then the item should be displayed above the selected item in the project list
