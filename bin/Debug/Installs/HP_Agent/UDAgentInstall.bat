md "C:\Program Files (x86)\UD Certificates\"

copy acstrust.cert "C:\Program Files (x86)\UD Certificates\"

copy agentca.pem "C:\Program Files (x86)\UD Certificates\"

msiexec /i hp-ud-agent-win32-x86.msi SETUPTYPE=Enterprise PORT=2738 TIMEOUT=900 CERTPATH="C:\Program Files (x86)\UD Certificates\" SOFTWAREUTILIZATION=ON URL0=10.150.99.115 URL1=10.150.99.116 /qn

rd "C:\Program Files (x86)\UD Certificates\" /s /q

exit