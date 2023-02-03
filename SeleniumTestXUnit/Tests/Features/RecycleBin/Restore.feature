Feature: Restore item from bin
    As a logged in user, the user should be able to restore a deleted item

    Background:
        Given the user is logged in
        And has deleted items
        And has an existing project

    @Draft
    @Acceptance
    Scenario: Restore a deleted item from bin succesfully
        When the user drags the deleted item to an existing project
        Then the item will be restored and added to the project