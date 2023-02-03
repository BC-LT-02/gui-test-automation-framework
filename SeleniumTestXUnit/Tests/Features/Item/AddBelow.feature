Feature: Add Note Below
    As a logged in user, I want to be able to create a note below another


    Background:
        Given the user is logged in
        And the user has existing notes

    @acceptance
    Scenario: Add below
        Given the user wants to add a new note below an existing one
        When the user hovers over the desired note
        And clicks on the menu list
        And clicks on the priority "Add item below" button
        And an input box should be displayed
        And the user types the name for the new note
        And clicks on the save button
        Then the new note will be created below the existing one

