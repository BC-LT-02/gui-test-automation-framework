Feature: Set Date for an Item
As a logged user, the user wants to set a date for an item
So that he can keep track of deadlines for his tasks

Background:
    Given the user is logged in
        And the user has an existing project
        And the project has one or more existing items

    @Draft
    @Acceptance
    Scenario: Set Date for an Item successfully 
        Given the user selected an item
        When the user clicks on the Set Due Date
        Then enters a date and time and saves
        Then the item should be displayed in the list with the specified date

    @Draft
    @Negative
    Scenario: Failed to Set Date for an Item
        Given the user selected an item
        When the user clicks on the Set Due Date
        Then the user sets an invalid date or time for the item
        Then an error message should be displayed indicating that the date is invalid should be displayed