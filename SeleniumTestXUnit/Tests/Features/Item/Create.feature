Feature: Create an Item in a Project
As a logged user, the user wants to create an item in a project so that he can keep track of my tasks.

Background:
    Given the user is logged in
        And the user has an existing project

    @Draft
    @Acceptance
    Scenario: Create an Item Successfully
        Given the user has selected a project
        When the user clicks on the Add New Todo
        Then the user enters an item name
        Then the item should be displayed in the project list

    @Draft
    @Negative
    Scenario: Failed to Create an Item Due to Empty Name
        Given the user has selected a project
        When the user tries to create an item with an empty
        Then an error message indicating that the item name is required should be displayed
