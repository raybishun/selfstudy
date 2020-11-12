$params = @{
 LogName = 'Application'
 Source = 'WSH'
 EntryType = 'Information'
 EventId = 4
 Message = 'This is a test from Startup.ps1.'
}
Write-EventLog @params