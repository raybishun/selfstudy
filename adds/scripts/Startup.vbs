On Error Resume Next 
Dim WshShell
Set WshShell = Wscript.CreateObject("Wscript.shell")
WshShell.LogEvent 4, "This is a test from Startup.vbs."