Feature: Postpone Date for an Item
As a logged user, the user wants to postpone the date for an item
So that the user can keep track of the revised deadlines for his tasks

Background:
    Given the user is logged in
        And the user has an existing project
        And the project has one or more existing items
        And the item selected has a date

    @Draft
    @Acceptance
    Scenario: Successfully Postpone Date for an Item
        Given the user clicks on the date of the item
        When the user selects one of the options to postpone the date
        Then clicks on Postpone button
        Then the item should be displayed in the list with the postponed date
