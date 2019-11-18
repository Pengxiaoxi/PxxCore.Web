# PxxCore.Web
PxxCore.Web

DotNet Core 2.0 + EF Core 2.2(Code First)
目前集成 Swagger + 

C Cool

2019-11-1 18:02:47   Add 

## Swagger:

![Image text](https://github.com/Pengxiaoxi/PxxCore.Web/blob/master/PxxCore.Web/02_GitImg/Swagger.jpg)


## 怎样跑起来？
1、检查 NetCore SDK、引用的程序集（NuGet包）等

2、编译无问题，修改AppSetting中数据库连接字符串Uid及Pwd，最后在程序包管理控制台依次执行以下命令自动创建数据库、表
  Add-Migration V1
  Update-Database

3、F5运行即可看到上面Swagger页面
