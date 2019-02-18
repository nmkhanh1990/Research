if (!(Test-Path "ngrok.exe")) 
{
	wget https://bin.equinox.io/c/4VmDzA7iaHb/ngrok-stable-windows-amd64.zip -outfile ngrok.zip
	Expand-Archive .\ngrok.zip -dest .
	rm .\ngrok.zip
}

./ngrok.exe http 3000
