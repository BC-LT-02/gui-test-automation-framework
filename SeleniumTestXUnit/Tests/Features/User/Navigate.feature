Feature: User navigates
    The user should be able to navigate to certain HostUrl

    @Draft
    @Smoke
    Scenario: User navigates to url succesfully
        Given an existing url
        When the user navigates to the existing url
        Then the user will be redirected to the existing url