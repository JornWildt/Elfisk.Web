xcopy bin\Elfisk.* ..\..\Xyperico.Website\Xyperico.Website.Host\bin\Areas /I /Y

mkdir ..\..\Xyperico.Website\Xyperico.Website.Host\Areas\Elfisk\Views
xcopy Areas\Elfisk\Views\*.* ..\..\Xyperico.Website\Xyperico.Website.Host\Areas\Elfisk\Views\ /I /Y /S
