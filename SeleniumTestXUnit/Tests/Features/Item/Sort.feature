Feature: Sort Notes
    As a logged in user, I want to be able to sort my notes.


    Background:
        Given the user is logged in
        And the user has an existing project
        And the user has a set of notes

    @acceptance
    Scenario Outline: Sorting notes
        Given the user wants to sort the notes
        When the user clicks on the Sort By button
        And clicks on the menu list
        And clicks on the "<menu>" option
        Then the notes should by sorted by "<sorted>"

        Examples:
            | menu     | sorted   |
            | Order    | Order    |
            | Priority | Priority |
            | Due Date | Due Date |

