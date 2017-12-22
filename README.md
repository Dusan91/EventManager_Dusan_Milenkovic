Title: Application for managing events
by Dusan Milenkovic
	
Application URL: "https://github.com/DusanSilni/EventManager_Dusan_Milenkovic.git"

Setup Guide

1) System Requirements 

- Processor	 1 GHz
- RAM		512 MB
- OS Windows Vista(or higher)
- Disk space (minimum)	
- 32-bit	4.5 GB
- 64-bit	4.5 GB


2) Installation requirements

  The .NET Framework requires administrator privileges for installation. 
  If you don't have administrator rights to the computer where you'd like
  to install the .NET Framework, contact your network administrator.

3) Overview of System 

- Visual Studio 2010 (or higher)
- Microsoft SQL Server 2016 LocalDB
- Entity Framework (NuGet package ) v6.2.0
- Bootstrap 			    v3.0.0
- JQuery 			    v3.2.1
- Microsoft.ApplicationInsights.Web v2.2.0
- Microsoft.AspNet.Mvc 		    v5.2.3
- Microsoft.AspNet.Razor 	    v3.2.3
- Microsoft.AspNet.Web.Optimization v1.1.3
- Microsoft.AspNet.WebPages 	    v3.2.3
- Microsoft.AspNet.Web 		    v2.2.0
- Microsoft.AspNet.Razor 	    v3.2.3
- WebGrease 			    v1.5.2

4) Set-Up Configurations

  To install the application, it is necessary to download it from github.
  If you do not know how to use Git read user-manual : "https://git-scm.com/docs/user-manual.html"
  Url for download : "https://github.com/DusanSilni/EventManager_Dusan_Milenkovic.git"
  After download, run WebEvents.sln or open it with Visual Studio.
  When it is opened, click on Build->Rebuild Solution.
  Make sure you do not have another table with name "Events".
  Because the application uses a local database, there is no need for other settings, 
  but if you want to use your own base, in Web.config change "connectionString".
  
  "<connectionStrings>	
    <add name="EventsConnection" connectionString="Data Source={$Your_base_name};AttachDbFilename=|DataDirectory|\				{$Your_table_name};Initial Catalog=EventsInfo;Integrated Security=True" providerName="System.Data.SqlClient"/>
  </connectionStrings>"
  
  In Package Manager Console type "update-database".
  When process is finished open application. 
  If you want to start application and debug it, click on Debug->Start Debugging (or press F5 on keyboard).
  If you just want to start application, click on Debug->Start Without Debugging (or press Ctrl+F5 on keyboard).
  



