winform获取文件路径

string str1 =Process.GetCurrentProcess().MainModule.FileName;//获得当前执行的exe的文件名。
string str2=Environment.CurrentDirectory;//获取和设置当前目录的完全限定路径。
string str3=Directory.GetCurrentDirectory();//获取应用程序的当前工作目录。
string str4=AppDomain.CurrentDomain.BaseDirectory;//获取基目录，它由程序集冲突解决程序用来探测程序集。
string str5=Application.StartupPath;//获取启动了应用程序的可执行文件的路径，不包括可执行文件的名称。
string str6=Application.ExecutablePath;//获取启动了应用程序的可执行文件的路径，包括可执行文件的名称。
string str7=AppDomain.CurrentDomain.SetupInformation.ApplicationBase;//获取或设置包含该应用程序的目录的名称。

“Application.StartupPath”:获取当前应用程序所在目录的路径，最后不包含“\”；
“Application.ExecutablePath ”:获取当前应用程序文件的路径，包含文件的名称；
“AppDomain.CurrentDomain.BaseDirectory”:获取当前应用程序所在目录的路径，最后包含“\”；
“System.Threading.Thread.GetDomain().BaseDirectory”:获取当前应用程序所在目录的路径，最后包含“\”；
“Environment.CurrentDirectory”:获取当前应用程序的路径，最后不包含“\”；
“System.IO.Directory.GetCurrentDirectory”:获取当前应用程序的路径，最后不包含“\”；

 

String[] files = System.IO.Directory.GetFiles(path) //返回指定目录下的文件名

string str = System.IO.Path.GetFileNameWithoutExtension(path);//返回不具有扩展名的指定路径字符串的文件名
 

1、取得控制台应用程序的根目录方法
     方法1、Environment.CurrentDirectory 取得或设置当前工作目录的完整限定路径
     方法2、AppDomain.CurrentDomain.BaseDirectory 获取基目录，它由程序集冲突解决程序用来探测程序集
 2、取得Web应用程序的根目录方法
     方法1、HttpRuntime.AppDomainAppPath.ToString();//获取承载在当前应用程序域中的应用程序的应用程序目录的物理驱动器路径。用于App_Data中获取
     方法2、Server.MapPath("") 或者 Server.MapPath("~/");//返回与Web服务器上的指定的虚拟路径相对的物理文件路径
     方法3、Request.ApplicationPath;//获取服务器上ASP.NET应用程序的虚拟应用程序根目录
 3、取得WinForm应用程序的根目录方法
     1、Environment.CurrentDirectory.ToString();//获取或设置当前工作目录的完全限定路径
     2、Application.StartupPath.ToString();//获取启动了应用程序的可执行文件的路径，不包括可执行文件的名称
     3、Directory.GetCurrentDirectory();//获取应用程序的当前工作目录
     4、AppDomain.CurrentDomain.BaseDirectory;//获取基目录，它由程序集冲突解决程序用来探测程序集
     5、AppDomain.CurrentDomain.SetupInformation.ApplicationBase;//获取或设置包含该应用程序的目录的名称
其中：以下两个方法可以获取执行文件名称
     1、Process.GetCurrentProcess().MainModule.FileName;//可获得当前执行的exe的文件名。
     2、Application.ExecutablePath;//获取启动了应用程序的可执行文件的路径，包括可执行文件的名称
     3、System.IO.Path类中有一些获取路径的方法，可以在控制台程序或者WinForm中根据相对路径来获取绝对路径

获取web物理路径的方法是Server.MpaPath("~")

http://www.cnblogs.com/bq-blog/archive/2012/09/01/2666394.html