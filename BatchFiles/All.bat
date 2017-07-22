if not exist "C:\temp" mkdir C:\temp
Echo %computername%>>C:\temp\server.txt
cscript 01changew32time.vbs
cscript 02disableprintlog20082012.vbs
cscript 03globaldnssuffixorder.vbs
cscript 04setpowershell.vbs
cscript 05setrdpsessioninfo.vbs
del "C:\temp\server.txt" 
exit