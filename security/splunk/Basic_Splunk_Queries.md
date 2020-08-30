# Basic Splunk Queries

### Last 24 hours
- Asterisk - all events in the last 24 hours)
- earliest=-24@h (last 24 hours)

### Failed Splunk Portal Login Attempts
```
index=_audit action="login attempt" info=failed
```
### Failed Splunk Portal Login Attempts (Visualization)
```
index=_audit action="login attempt" info=failed | timechart count
```
### Failed root Login Attempts (Visualization)
```
source="/var/log/secure" failed "root" | timechart count
```
### Top Users
```
* | top user
```

# References
1. https://www.splunk.com/pdfs/solution-guides/splunk-quick-reference-guide.pdf
2. https://www.color-hex.com/