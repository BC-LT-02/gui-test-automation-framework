   Feature: Uncheck an Item
As a logged user, the user wants to check an item
So that the user can keep track of the items that are not done


Background:
    Given the user is logged in
        And the user has an existing project
        And the project has one or more existing items

    @Draft
    @Acceptance
    Scenario: Successfully Check an Item
        Given the user has selected an item
        When the user unchecks the item
        Then the item should not be displayed in the Done Items list
