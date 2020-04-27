# Standard SCM Example

### Create a new branch (locally)
- git branch alpha
- git branch --list

### Checkout the alpha branch
- git checkout alpha

### Alternatively, create and checkout a branch at the same time
- git checkout -b beta

### Verify you are using the alpha branch
- git status

### Make your source code changes
- [...]

### Push to/and create alpha on https://github.com/
- git push --set-upstream origin alpha

### View last 3 git log entries
- git log -3

### Merge branches
- git checkout master
- git merge alpha

### View activity (in graph mode)
- git log --graph

### Finally push master to github
- git push
