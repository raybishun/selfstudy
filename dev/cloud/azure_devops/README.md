# Azure DevOps 101

### Getting Started

#### Create an Azure DevOps Project and WebApp
1. Create a Azure DevOps project (based on Git and Agile)
2. From VS19, Choose 'Clone or check out code'
3. From Azure DevOps, retrieve and populate the Repository location URL in VS19 'Clone or check out code' form
4. Select your local path (the destination folder must be empty)
5. Clone
6. Wait about 60 seconds
7. Team Explorer will show: The repository was cloned successfully
8. Verify the .git and .vs (hidden) folders were created
9. Create a new Solution and Project
10. Add an xUnit Test Project

#### Initial Commit
1. From VS19
2. File\Add to Source Control
2. Team Explorer
3. Changes
4. Commit All
5. Sync\Push
6. Verify the Azure DevOps repo now contains your Project with Unit Test

#### Set a Build Pipeline (aka CI Pipeline)
1. Pipelines\Create Pipeline
2. Use the classic editor
3. Source: Azure Repos Git
4. Continue
5. Select a Template: ASP.NET Core (.NET Framework)
6. Apply
7. Change Agent Specification to: windows-2019
8. Click to select the Triggers tab
9. Check - Enable continuous integration
10. From Save & queue, select Save
11. Save

#### Run the Pipeline for the first time
1. Pipeline
2. Run Pipeline (Get started and run the pipeline for the first time)
3. Run
4. Verify you received a Build succeeded e-mail 

#### Test the CI Pipeline works
- That is, auto builds when new code is checked into the Master branch
1. Make a code change to the app
2. Check in the code
3. Commit and Push
4. Verify you received a Build succeeded e-mail 



# References
1. Azure Pipelines - Build: https://www.youtube.com/watch?v=7pzBwuMjpP0
2. Azure Pipelines - Releases: https://www.youtube.com/watch?v=UUmgg2xqFxU