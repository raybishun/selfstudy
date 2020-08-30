# Basic Splunk Queries

### Last 24 hours
- Asterisk - all events in the last 24 hours)

### From top of hour to whatever whatever time it is now, i.e. 6:00PM to 6:50PM (assuming it's 6:50PM now)
- earliest=-24@h (overrides the Splunk time-dropdown)

### Top Users
```
* | top user
```

# Failed Login Attempts

### Root

#### Failed Login Attempts for root User
```
source="/var/log/secure" failed "root"
source="/var/log/secure" failed "root" | dedup src_ip
```
#### Failed Login Attempts for root User(Visualization)
```
source="/var/log/secure" failed "root" | timechart count
source="/var/log/secure" failed "root" | stats distinct_count(src_ip)
source="/var/log/secure" failed "root" | timechart span=1d distinct_count(src_ip) as attacker | trendline sma10(attacker) as attacker_sma10
```

### Splunk Portal

#### Failed Login Attempts to the Splunk Portal 
```
index=_audit action="login attempt" info=failed
```
#### Failed Login Attempts to the Splunk Portal (Visualization)
```
index=_audit action="login attempt" info=failed | timechart count
```


# References
1. https://www.splunk.com/pdfs/solution-guides/splunk-quick-reference-guide.pdf
2. https://www.color-hex.com/