Feature: Project Creation
    As a logged in user, the user should be able to create a project.
    
    Background:
        Given the user is logged in

    @Smoke @Regression @delete.project
    Scenario: Create a new project
        When the user clicks the New Project button
            And inputs a new project name
            And clicks the Add button
        Then a new project with the chosen name should be displayed in the projects list

    @Negative
    Scenario Outline: Create a new project with an empty name
        When the user clicks the Add New Project button
            And inputs an empty string as the project name
            And clicks the Add button
        Then an error message should be displayed indicating that the project name cannot be empty
