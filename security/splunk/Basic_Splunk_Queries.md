# Basic Splunk Queries

### Failed Splunk Portal Login Attempts
```
index=_audit action="login attempt" info=failed
```
### Failed Splunk Portal Login Attempts (Visualization)
```
index=_audit action="login attempt" info=failed timechart count
```
### Failed root Login Attempts (Visualization)
```
* source="/var/log/secure" failed "root" | timechart count
```
### Top Users
```
* | top user
```

# References
1. https://www.splunk.com/pdfs/solution-guides/splunk-quick-reference-guide.pdf