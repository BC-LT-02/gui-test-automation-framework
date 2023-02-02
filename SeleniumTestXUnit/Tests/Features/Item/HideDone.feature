Feature: Hide notes
    As a logged in user, I want to be able to hide all my done notes


    Background:
        Given the user is logged in
        And the user has existing notes

    @acceptance
    Scenario: Hide notes
        Given the user wants to hide the notes marked as done
        When the user clicks on the Hide button
        Then the note should be hide from the dashboard

