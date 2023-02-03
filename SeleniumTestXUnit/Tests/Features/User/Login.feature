Feature: User Login
    As a non-logged in user, the user should be able to login into the site

    @Draft
    @Smoke
    Scenario: Login into the site succesfully
        Given the user navigates to "HostUrl"
        When the user clicks the login button
        And introduces his credentials
        Then the user should be able to see the main page