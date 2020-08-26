# How to alert on Failed Login attempts

### Setup the alert
1. Login to the Splunk Portal
2. Verify the below query returns failed login events
```
index=_audit action="login attempt" info=failed
```
3. Save As\Alert
4. Alert type: Scheduled
5. Run every day
6. Trigger Conditions\Trigger alert when Number of Results is greater than 3
7. Once
8. Trigger Actions\Email and enter your e-mail address
9. Check Attach CSV
10. Save
11. View Alert

### Add an additional action
1. Edit\Edit Alert
2. Trigger Actions\Add to Triggered Alerts (add this alert to the triggered alerts list,so it's also viewable in the portal)
3. Save\Done

# Tokens

### Search Metadata Tokens
- $name$ - alert name
- $alert.severity$ - alert severity level
- $results_link$ - link to search results_link$

### Results Tokens
- $result.host$ - hostname of the first result in search
- $result.source$ - source of the first result in search
- $result.fieldname$ - any field from first result