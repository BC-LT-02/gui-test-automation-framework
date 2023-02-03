Feature: Postpone an existing date
    As a logged in user, I want to be able to update the due date of an existing note


    Background:
        Given the user is logged in
        And the user has existing notes

    @acceptance
    Scenario Outline: Update due date
        Given the user wants to update the due date of an existing note
        When the user hovers over the desired note
        And clicks on the displayed date
        And the user types "<date>" as new Due Date in the input box
        And clicks the Save button
        Then the note due date will be updated

        Examples:
            | date             |
            | 1 Mar, 12:00 AM  |
            | 24 Mar, 03:00 PM |
            | 15 Jun, 03:00 PM |

