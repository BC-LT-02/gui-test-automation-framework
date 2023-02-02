Feature: Project Retrieval
    As a logged in user, the user should be able to see their existing projects.
    
    Background:
        Given the user is logged in

    @Smoke @Regression @create.project @delete.project
    Scenario: Retrieve your projects
        When the user has an existing project
        Then the existing projects should be displayed in the projects list
