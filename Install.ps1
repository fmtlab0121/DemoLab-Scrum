$temp_path = "D:\"
$installer_url = "https://download.visualstudio.microsoft.com/download/pr/19a5a3cc-b297-4a10-9b22-1184a0aeb990/5af443d748d2c5fb444477f202a11470/dotnet-hosting-3.1.12-win.exe"
$installer_file = $temp_path + [System.IO.Path]::GetFileName( $installer_url )
 
Try
{
	add-windowsfeature web-server -includeallsubfeature
	Invoke-WebRequest -Uri $installer_url -OutFile $installer_file
 
	$args = New-Object -TypeName System.Collections.Generic.List[System.String]
	$args.Add("/quiet")
	$args.Add("/norestart")
	Start-Process -FilePath $installer_file -ArgumentList $args -NoNewWindow -Wait -PassThru
	
	Invoke-WebRequest "https://datalust.co/download/begin?version=2021.1.5307" -outfile "Seq.msi"
	Start-Process -Wait -FilePath msiexec -ArgumentList '/quiet /i Seq.msi WIXUI_EXITDIALOGOPTIONALCHECKBOX=0 INSTALLFOLDER="C:\Program Files\Seq"'
	seq service install --storage="C:\ProgramData\Seq" --listen="http://localhost:5341"
	seq service start	
 
}
Catch
{
   Write-Output ( $_.Exception.ToString() )
   Break
}