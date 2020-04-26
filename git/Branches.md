# Branches

### View all branches, and identify the current branch
- git branch

### Create, checkout and switch to a new branch (using the feature/<featureName> pattern)
1. git checkout -b feature/userprofile
2. git branch

### Create/update a file in the feature/userprofile branch
[...]

### Push changes to the new branch (locally)
1. git status
2. git add README.md (the file that was created/changed)
3. git commit -m "Made trivial change to the README.md file"
4. git push --set-upstream origin feature/userprofile (required if not previously set, in other words, you don't use --set on subsequent pushes)

### Merge changes from the (new) feature/userprofile branch to the master branch
1. https://github.com/raybishun/apps/tree/feature/userprofile
2. 'New pull request'
3. A developer would write a comment to describe their code change, i.e. "Completed the new userprofile feature, please review and merge."
4. The developer would then 'Create pull request'
5. The lead developer would then 'Merge pull request', and 'Confirm merge'
6. Additionally, after the feature/userprofile has been merged with the master branch, it can be deleted using 'Delete branch'

### Pull the now merged master branch (locally)
1. git checkout master
2. git pull

### Merge changes from master into another branch (locally)
1. git checkout -b feature/userprofile2
2. git merge master
3. git push

### Switching between branches
1. git checkout <branch name>
2. git checkout - (switch to previous branch)

### Deleting a branch
1. git checkout -b feature/userprofile2 (creating a new branch, to demo delete)
2. git checkout master
3. git branch -D feature/userprofile2 (only deletes branch from your local repo)
4. git branch
5. Use https://github.com/ to delete the branch from GitHub