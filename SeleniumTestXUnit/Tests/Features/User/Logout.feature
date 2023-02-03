Feature: User Logout
    As a logged in user, the user should be able to Logout

    Background:
        Given the user is logged in

    @Draft
    @Smoke
    Scenario: Logout off the site succesfully
        When the user clicks the logout button
        Then the user should be logged out from the site
        And should be able to see the login view