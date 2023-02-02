Feature: Item Deletion
    As a logged in user, the user should be able to delete existing items from a project.
    @Acceptance

    Background:
        Given the user is logged in
        And the user has an existing project

    Scenario: Delete a pending item
        Given the user has a pending item in the main items section
        When the user hovers over the item
        And clicks on the menu list 
        And clicks on the delete option
        Then the item should be removed from the section 
        And it should be added to the Recycle Bin section

    Scenario: Delete all done items
        Given I have at least two done items located in the done items section
        When the user clicks on the delete all option
        Then the items should be removed from the section
        And they should be added to the Recycle bin section






