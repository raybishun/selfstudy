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

#### Setup a Build Pipeline (aka CI Pipeline)
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
3. Commit All and Push
4. Verify you received a Build succeeded e-mail 

#### Creating a new Branch in VS19
1. Team Explorer
2. Home
3. Branches
4. New Branch: FEA-SomeNewFeatureV1.1
5. Create Branch
6. Ensure the new Branch is selected
7. Solution Explorer
8. Make a code change
9. Press the 'Pen Check-in' Icon in the status bar
10. Commit All and Push

#### Merge the Feature Branch with Master
- NOTE, then can be done in either the Azure DevOps portal or in VS19
1. Repos
2. Select the FE-SomeNewFeatureV1 Branch
3. Create a pull request
4. Create
5. Approve
6. Complete
7. Complete merge

#### Setup a Release Pipeline (aka CD Pipeline)
1. Pipelines
2. Releases
3. New pipeline


# References
1. Azure DevOps Docs: https://aka.ms/vst/azuredevopsdocs
2. Azure Pipelines - Build: https://www.youtube.com/watch?v=7pzBwuMjpP0
3. Azure Pipelines - Releases: https://www.youtube.com/watch?v=UUmgg2xqFxU