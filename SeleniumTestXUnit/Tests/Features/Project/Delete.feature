Feature: Project Deletion
    As a logged in user, I want to be able to delete my project.


    Background:
        Given the user is logged in
        And the user has an existing project

    @acceptance
    Scenario: Delete a project
        Given the user wants to delete a project
        When the user hovers over the project
        And clicks on the menu list
        And clicks on the delete option
        And clicks on the "OK" button
        Then the project should be removed from the dashboard

    @negative
    Scenario: Failed to delete a project
        Given the user wants to delete a project
        When the user hovers over the project
        And clicks on the menu list
        And clicks on the delete option
        And clicks on the "Cancel" button
        Then the project should not be removed from the dashboard

