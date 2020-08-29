# Basic Splunk Queries

### Failed Splunk Portal Login Attempts
```
index=_audit action="login attempt" info=failed
```
### Top Users
```
* | top user
```

# References
1. https://www.splunk.com/pdfs/solution-guides/splunk-quick-reference-guide.pdf