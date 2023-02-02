Feature: Set priority
    As a logged in user, I want to be able to set priority to my notes


    Background:
        Given the user is logged in
        And the user has existing notes

    @acceptance
    Scenario Outline: Set priority to notes
        Given the user wants to set a priority to the notes
        When the user hovers over the desired note
        And clicks on the menu list
        And clicks on the priority "<priority>" button
        Then the note name should be displayed in color "<color>"

        Examples:
            | priority | color |
            | 1        | Red   |
            | 2        | Blue  |
            | 3        | Green |
            | 4        | Black |