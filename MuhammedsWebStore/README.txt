Assignment 2 PART 1
2023-10-30 - 11:27 EST

Welcome to Muhammed's Web Store MVC app for the 4th time, Again I messed up the Git pull and push 

11:28	Created Muhammeds Book Store project using ASP.NET Core Web App (MVC) - SDK 5.0
11:28	Created README.txt
11:28	Comment out the port number in order for the app to work at school - in properties folder/launchSetting.json

11:29	updated Database by going to NuGet console manager, PM then inserted the command
11:29	Checked the website - Its working on the default view- we are going to change that soon
11:30	removed between () in startup.cs services.addDefaultIdentity<IdentityUser> Line 35
11:52	Added 2 breakpoints (debugging) on index and privacy methods in the HomeControllers.cs
11:52	Downloaded my favourite theme on bootswatch.com - Slate
11:53	Replaced the existing bootstrap.css file with the new downloaded one ( Lib -> dist -> css)
11:55	changed the link on layout.cshtml on line 7 from the minifind version to the regular one.
------------------------------------------------------
2023-10-31
00:01	Removed the text dark from the home and privacy links
00:03	Removed the text dark from the login and Register in LoginPartial.cshtml
00:22	Added the Datepicker from jqueryui.com, the box is not working or move with my mouse, iam going to fix that later
00:23	Adding a new dropdown menu with extra 3 subs
11:45	comment out the dragablle box as its not working as it should
11:45	Created 3 Projects of the solution Muhammed's DataAccess -Models & Utility
11:46	copied the data folder to the dataAccess
11:47	Installed Microsoft Entity Framework - tools - Manage NuGet Package for solution - install 5.0.11 as mentioned in the slides
11:48	installed the following libraries to MuhammedsWebStore

Installing:

Microsoft.EntityFrameworkCore.Relational.5.0.11

MuhammedsBooks.DataAccess

Installing:

Microsoft.EntityFrameworkCore.5.0.11
Microsoft.EntityFrameworkCore.Abstractions.5.0.11
Microsoft.EntityFrameworkCore.Analyzers.5.0.11
Microsoft.EntityFrameworkCore.Relational.5.0.11
Microsoft.Extensions.Caching.Abstractions.5.0.0
Microsoft.Extensions.Caching.Memory.5.0.0
Microsoft.Extensions.Configuration.Abstractions.5.0.0
Microsoft.Extensions.DependencyInjection.5.0.2
Microsoft.Extensions.DependencyInjection.Abstractions.5.0.0
Microsoft.Extensions.Logging.5.0.0
Microsoft.Extensions.Logging.Abstractions.5.0.0
Microsoft.Extensions.Options.5.0.0
Microsoft.Extensions.Primitives.5.0.0
System.Collections.Immutable.5.0.0
System.ComponentModel.Annotations.5.0.0
System.Diagnostics.DiagnosticSource.5.0.1

MuhammedsBooks.Models

Installing:

Microsoft.EntityFrameworkCore.5.0.11
Microsoft.EntityFrameworkCore.Abstractions.5.0.11
Microsoft.EntityFrameworkCore.Analyzers.5.0.11
Microsoft.EntityFrameworkCore.Relational.5.0.11
Microsoft.Extensions.Caching.Abstractions.5.0.0
Microsoft.Extensions.Caching.Memory.5.0.0
Microsoft.Extensions.Configuration.Abstractions.5.0.0
Microsoft.Extensions.DependencyInjection.5.0.2
Microsoft.Extensions.DependencyInjection.Abstractions.5.0.0
Microsoft.Extensions.Logging.5.0.0
Microsoft.Extensions.Logging.Abstractions.5.0.0
Microsoft.Extensions.Options.5.0.0
Microsoft.Extensions.Primitives.5.0.0
System.Collections.Immutable.5.0.0
System.ComponentModel.Annotations.5.0.0
System.Diagnostics.DiagnosticSource.5.0.1

MuhammedsBooks.Utility

Installing:

Microsoft.EntityFrameworkCore.5.0.11
Microsoft.EntityFrameworkCore.Abstractions.5.0.11
Microsoft.EntityFrameworkCore.Analyzers.5.0.11
Microsoft.EntityFrameworkCore.Relational.5.0.11
Microsoft.Extensions.Caching.Abstractions.5.0.0
Microsoft.Extensions.Caching.Memory.5.0.0
Microsoft.Extensions.Configuration.Abstractions.5.0.0
Microsoft.Extensions.DependencyInjection.5.0.2
Microsoft.Extensions.DependencyInjection.Abstractions.5.0.0
Microsoft.Extensions.Logging.5.0.0
Microsoft.Extensions.Logging.Abstractions.5.0.0
Microsoft.Extensions.Options.5.0.0
Microsoft.Extensions.Primitives.5.0.0
System.Collections.Immutable.5.0.0
System.ComponentModel.Annotations.5.0.0
System.Diagnostics.DiagnosticSource.5.0.1

-----------------------------------------------------
11:51	Installing SQL server package 5.0.11
MuhammedsWebStore

Updates:

Microsoft.EntityFrameworkCore.SqlServer.5.0.17 -> Microsoft.EntityFrameworkCore.SqlServer.5.0.11

MuhammedsBooks.DataAccess

Installing:

Microsoft.CSharp.4.5.0
Microsoft.Data.SqlClient.2.0.1
Microsoft.Data.SqlClient.SNI.runtime.2.0.1
Microsoft.EntityFrameworkCore.5.0.11
Microsoft.EntityFrameworkCore.Abstractions.5.0.11
Microsoft.EntityFrameworkCore.Analyzers.5.0.11
Microsoft.EntityFrameworkCore.Relational.5.0.11
Microsoft.EntityFrameworkCore.SqlServer.5.0.11
Microsoft.Extensions.Caching.Abstractions.5.0.0
Microsoft.Extensions.Caching.Memory.5.0.0
Microsoft.Extensions.Configuration.Abstractions.5.0.0
Microsoft.Extensions.DependencyInjection.5.0.2
Microsoft.Extensions.DependencyInjection.Abstractions.5.0.0
Microsoft.Extensions.Logging.5.0.0
Microsoft.Extensions.Logging.Abstractions.5.0.0
Microsoft.Extensions.Options.5.0.0
Microsoft.Extensions.Primitives.5.0.0
Microsoft.Identity.Client.4.14.0
Microsoft.IdentityModel.JsonWebTokens.5.6.0
Microsoft.IdentityModel.Logging.5.6.0
Microsoft.IdentityModel.Protocols.5.6.0
Microsoft.IdentityModel.Protocols.OpenIdConnect.5.6.0
Microsoft.IdentityModel.Tokens.5.6.0
Microsoft.NETCore.Platforms.3.1.0
Microsoft.NETCore.Targets.1.1.3
Microsoft.Win32.Registry.4.7.0
Microsoft.Win32.SystemEvents.4.7.0
Newtonsoft.Json.10.0.1
runtime.native.System.4.3.0
System.Collections.4.3.0
System.Collections.Concurrent.4.3.0
System.Collections.Immutable.5.0.0
System.Collections.NonGeneric.4.3.0
System.Collections.Specialized.4.3.0
System.ComponentModel.4.3.0
System.ComponentModel.Annotations.5.0.0
System.ComponentModel.Primitives.4.3.0
System.ComponentModel.TypeConverter.4.3.0
System.Configuration.ConfigurationManager.4.7.0
System.Diagnostics.Debug.4.3.0
System.Diagnostics.DiagnosticSource.5.0.1
System.Diagnostics.Tools.4.3.0
System.Diagnostics.Tracing.4.3.0
System.Drawing.Common.4.7.0
System.Dynamic.Runtime.4.3.0
System.Globalization.4.3.0
System.Globalization.Extensions.4.3.0
System.IdentityModel.Tokens.Jwt.5.6.0
System.IO.4.3.0
System.IO.FileSystem.4.3.0
System.IO.FileSystem.Primitives.4.3.0
System.Linq.4.3.0
System.Linq.Expressions.4.3.0
System.Net.NameResolution.4.3.0
System.Net.Primitives.4.3.0
System.ObjectModel.4.3.0
System.Private.DataContractSerialization.4.3.0
System.Private.Uri.4.3.2
System.Reflection.4.3.0
System.Reflection.Emit.4.3.0
System.Reflection.Emit.ILGeneration.4.3.0
System.Reflection.Emit.Lightweight.4.3.0
System.Reflection.Extensions.4.3.0
System.Reflection.Primitives.4.3.0
System.Reflection.TypeExtensions.4.3.0
System.Resources.ResourceManager.4.3.0
System.Runtime.4.3.0
System.Runtime.Caching.4.7.0
System.Runtime.Extensions.4.3.0
System.Runtime.Handles.4.3.0
System.Runtime.InteropServices.4.3.0
System.Runtime.Numerics.4.3.0
System.Runtime.Serialization.Formatters.4.3.0
System.Runtime.Serialization.Json.4.3.0
System.Runtime.Serialization.Primitives.4.3.0
System.Security.AccessControl.4.7.0
System.Security.Cryptography.Cng.4.5.0
System.Security.Cryptography.Primitives.4.3.0
System.Security.Cryptography.ProtectedData.4.7.0
System.Security.Permissions.4.7.0
System.Security.Principal.Windows.4.7.0
System.Security.SecureString.4.3.0
System.Text.Encoding.4.3.0
System.Text.Encoding.CodePages.4.7.0
System.Text.Encoding.Extensions.4.3.0
System.Text.RegularExpressions.4.3.0
System.Threading.4.3.0
System.Threading.Tasks.4.3.0
System.Threading.Tasks.Extensions.4.3.0
System.Windows.Extensions.4.7.0
System.Xml.ReaderWriter.4.3.0
System.Xml.XDocument.4.3.0
System.Xml.XmlDocument.4.3.0
System.Xml.XmlSerializer.4.3.0

MuhammedsBooks.Models

Installing:

Microsoft.CSharp.4.5.0
Microsoft.Data.SqlClient.2.0.1
Microsoft.Data.SqlClient.SNI.runtime.2.0.1
Microsoft.EntityFrameworkCore.5.0.11
Microsoft.EntityFrameworkCore.Abstractions.5.0.11
Microsoft.EntityFrameworkCore.Analyzers.5.0.11
Microsoft.EntityFrameworkCore.Relational.5.0.11
Microsoft.EntityFrameworkCore.SqlServer.5.0.11
Microsoft.Extensions.Caching.Abstractions.5.0.0
Microsoft.Extensions.Caching.Memory.5.0.0
Microsoft.Extensions.Configuration.Abstractions.5.0.0
Microsoft.Extensions.DependencyInjection.5.0.2
Microsoft.Extensions.DependencyInjection.Abstractions.5.0.0
Microsoft.Extensions.Logging.5.0.0
Microsoft.Extensions.Logging.Abstractions.5.0.0
Microsoft.Extensions.Options.5.0.0
Microsoft.Extensions.Primitives.5.0.0
Microsoft.Identity.Client.4.14.0
Microsoft.IdentityModel.JsonWebTokens.5.6.0
Microsoft.IdentityModel.Logging.5.6.0
Microsoft.IdentityModel.Protocols.5.6.0
Microsoft.IdentityModel.Protocols.OpenIdConnect.5.6.0
Microsoft.IdentityModel.Tokens.5.6.0
Microsoft.NETCore.Platforms.3.1.0
Microsoft.NETCore.Targets.1.1.3
Microsoft.Win32.Registry.4.7.0
Microsoft.Win32.SystemEvents.4.7.0
Newtonsoft.Json.10.0.1
runtime.native.System.4.3.0
System.Collections.4.3.0
System.Collections.Concurrent.4.3.0
System.Collections.Immutable.5.0.0
System.Collections.NonGeneric.4.3.0
System.Collections.Specialized.4.3.0
System.ComponentModel.4.3.0
System.ComponentModel.Annotations.5.0.0
System.ComponentModel.Primitives.4.3.0
System.ComponentModel.TypeConverter.4.3.0
System.Configuration.ConfigurationManager.4.7.0
System.Diagnostics.Debug.4.3.0
System.Diagnostics.DiagnosticSource.5.0.1
System.Diagnostics.Tools.4.3.0
System.Diagnostics.Tracing.4.3.0
System.Drawing.Common.4.7.0
System.Dynamic.Runtime.4.3.0
System.Globalization.4.3.0
System.Globalization.Extensions.4.3.0
System.IdentityModel.Tokens.Jwt.5.6.0
System.IO.4.3.0
System.IO.FileSystem.4.3.0
System.IO.FileSystem.Primitives.4.3.0
System.Linq.4.3.0
System.Linq.Expressions.4.3.0
System.Net.NameResolution.4.3.0
System.Net.Primitives.4.3.0
System.ObjectModel.4.3.0
System.Private.DataContractSerialization.4.3.0
System.Private.Uri.4.3.2
System.Reflection.4.3.0
System.Reflection.Emit.4.3.0
System.Reflection.Emit.ILGeneration.4.3.0
System.Reflection.Emit.Lightweight.4.3.0
System.Reflection.Extensions.4.3.0
System.Reflection.Primitives.4.3.0
System.Reflection.TypeExtensions.4.3.0
System.Resources.ResourceManager.4.3.0
System.Runtime.4.3.0
System.Runtime.Caching.4.7.0
System.Runtime.Extensions.4.3.0
System.Runtime.Handles.4.3.0
System.Runtime.InteropServices.4.3.0
System.Runtime.Numerics.4.3.0
System.Runtime.Serialization.Formatters.4.3.0
System.Runtime.Serialization.Json.4.3.0
System.Runtime.Serialization.Primitives.4.3.0
System.Security.AccessControl.4.7.0
System.Security.Cryptography.Cng.4.5.0
System.Security.Cryptography.Primitives.4.3.0
System.Security.Cryptography.ProtectedData.4.7.0
System.Security.Permissions.4.7.0
System.Security.Principal.Windows.4.7.0
System.Security.SecureString.4.3.0
System.Text.Encoding.4.3.0
System.Text.Encoding.CodePages.4.7.0
System.Text.Encoding.Extensions.4.3.0
System.Text.RegularExpressions.4.3.0
System.Threading.4.3.0
System.Threading.Tasks.4.3.0
System.Threading.Tasks.Extensions.4.3.0
System.Windows.Extensions.4.7.0
System.Xml.ReaderWriter.4.3.0
System.Xml.XDocument.4.3.0
System.Xml.XmlDocument.4.3.0
System.Xml.XmlSerializer.4.3.0

MuhammedsBooks.Utility

Installing:

Microsoft.CSharp.4.5.0
Microsoft.Data.SqlClient.2.0.1
Microsoft.Data.SqlClient.SNI.runtime.2.0.1
Microsoft.EntityFrameworkCore.5.0.11
Microsoft.EntityFrameworkCore.Abstractions.5.0.11
Microsoft.EntityFrameworkCore.Analyzers.5.0.11
Microsoft.EntityFrameworkCore.Relational.5.0.11
Microsoft.EntityFrameworkCore.SqlServer.5.0.11
Microsoft.Extensions.Caching.Abstractions.5.0.0
Microsoft.Extensions.Caching.Memory.5.0.0
Microsoft.Extensions.Configuration.Abstractions.5.0.0
Microsoft.Extensions.DependencyInjection.5.0.2
Microsoft.Extensions.DependencyInjection.Abstractions.5.0.0
Microsoft.Extensions.Logging.5.0.0
Microsoft.Extensions.Logging.Abstractions.5.0.0
Microsoft.Extensions.Options.5.0.0
Microsoft.Extensions.Primitives.5.0.0
Microsoft.Identity.Client.4.14.0
Microsoft.IdentityModel.JsonWebTokens.5.6.0
Microsoft.IdentityModel.Logging.5.6.0
Microsoft.IdentityModel.Protocols.5.6.0
Microsoft.IdentityModel.Protocols.OpenIdConnect.5.6.0
Microsoft.IdentityModel.Tokens.5.6.0
Microsoft.NETCore.Platforms.3.1.0
Microsoft.NETCore.Targets.1.1.3
Microsoft.Win32.Registry.4.7.0
Microsoft.Win32.SystemEvents.4.7.0
Newtonsoft.Json.10.0.1
runtime.native.System.4.3.0
System.Collections.4.3.0
System.Collections.Concurrent.4.3.0
System.Collections.Immutable.5.0.0
System.Collections.NonGeneric.4.3.0
System.Collections.Specialized.4.3.0
System.ComponentModel.4.3.0
System.ComponentModel.Annotations.5.0.0
System.ComponentModel.Primitives.4.3.0
System.ComponentModel.TypeConverter.4.3.0
System.Configuration.ConfigurationManager.4.7.0
System.Diagnostics.Debug.4.3.0
System.Diagnostics.DiagnosticSource.5.0.1
System.Diagnostics.Tools.4.3.0
System.Diagnostics.Tracing.4.3.0
System.Drawing.Common.4.7.0
System.Dynamic.Runtime.4.3.0
System.Globalization.4.3.0
System.Globalization.Extensions.4.3.0
System.IdentityModel.Tokens.Jwt.5.6.0
System.IO.4.3.0
System.IO.FileSystem.4.3.0
System.IO.FileSystem.Primitives.4.3.0
System.Linq.4.3.0
System.Linq.Expressions.4.3.0
System.Net.NameResolution.4.3.0
System.Net.Primitives.4.3.0
System.ObjectModel.4.3.0
System.Private.DataContractSerialization.4.3.0
System.Private.Uri.4.3.2
System.Reflection.4.3.0
System.Reflection.Emit.4.3.0
System.Reflection.Emit.ILGeneration.4.3.0
System.Reflection.Emit.Lightweight.4.3.0
System.Reflection.Extensions.4.3.0
System.Reflection.Primitives.4.3.0
System.Reflection.TypeExtensions.4.3.0
System.Resources.ResourceManager.4.3.0
System.Runtime.4.3.0
System.Runtime.Caching.4.7.0
System.Runtime.Extensions.4.3.0
System.Runtime.Handles.4.3.0
System.Runtime.InteropServices.4.3.0
System.Runtime.Numerics.4.3.0
System.Runtime.Serialization.Formatters.4.3.0
System.Runtime.Serialization.Json.4.3.0
System.Runtime.Serialization.Primitives.4.3.0
System.Security.AccessControl.4.7.0
System.Security.Cryptography.Cng.4.5.0
System.Security.Cryptography.Primitives.4.3.0
System.Security.Cryptography.ProtectedData.4.7.0
System.Security.Permissions.4.7.0
System.Security.Principal.Windows.4.7.0
System.Security.SecureString.4.3.0
System.Text.Encoding.4.3.0
System.Text.Encoding.CodePages.4.7.0
System.Text.Encoding.Extensions.4.3.0
System.Text.RegularExpressions.4.3.0
System.Threading.4.3.0
System.Threading.Tasks.4.3.0
System.Threading.Tasks.Extensions.4.3.0
System.Windows.Extensions.4.7.0
System.Xml.ReaderWriter.4.3.0
System.Xml.XDocument.4.3.0
System.Xml.XmlDocument.4.3.0
System.Xml.XmlSerializer.4.3.0

-----------------------------------------------------

11:53	Delete the migration folder
11:54	Install NuGet Package Identity Entity FrameWork Core as requested in the slides 5.0.2
11:59	Modify the namespace to namespace MuhammedsWebStore.DataAccess.Data in ApplicationDbcontext.cs
12:01	Deleted the default class1.cs file in all projects
12:05	Copied the model folder from the webstore to the MuhammedsBooks.Models folder
12:07	Add project Reference to .DataAccess and . Models by going to the solution right click add project references then I rename the model folder to ViewModels
12:08	Changed the errorViewModels.cs namespace to .Models.ViewModels
12:17	changed the project reference to the new @model MuhammedsWebStore.Models.ViewModels.ErrorViewModel

12:37	Created class in the utility project called it SD.cs and changed the properties of the class  from class SD to public static class SD
12:40	Added project references to models and utility Models
12:45	Added Area - Customer to Area Folder
12:45	Changed the scaffoldingReadMe.txt to pattern : "{area:exists}/{controller=Home}/{action=Index}/{id?}"
12:47	changed the route in startup.cs to pattern : "{area:exists}/{controller=Home}/{action=Index}/{id?}"
12:48	moved the HomeControllers.cs to the area - customer - controller Folder and deleted the data and models
12:49	Defined the homecontroller.cs in the customer Area
12:55	Copied viewImport and viewstart to customer area
12:55	Modified the layout reference in _ViewStart.cshtml for the new path
12:59	Added new area in Areas and called it Admin
13:01	Deleted the controller Folder
-------------------------------------------------------
									PART 2

14:50 Built the new application
14:50 changed the code in  appsetting.json from "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=MuhammedsWebStore;Trusted_Connection=True;MultipleActiveResultSets=true" to the new one as per the powerpoint

