if not exist "C:\temp" md "C:\temp"
copy "%~dp0\*.*" "C:\temp"
cd c:\temp
cmd /c app_capture_No_Payload_3.9_452_v2_pc_intel_win.exe /s /f1"c:\temp\OPNet39.iss" /f2"C:\temp\OPNet39.log"
exit