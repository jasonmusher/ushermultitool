rmdir "C:\Temp\x64_HP_OM_Agent_11.14\" /S /Q
pushd \\tsclient\C\My_Files\Files\64bit\
XCOPY \\tsclient\C\My_Files\Files\64bit\x64_HP_OM_Agent_11.14\* C:\Temp\x64_HP_OM_Agent_11.14\ /s /i
c:
cd C:\Temp\x64_HP_OM_Agent_11.14\
start Install.bat
pause
rmdir "C:\Temp\x64_HP_OM_Agent_11.14\" /S /Q