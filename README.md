# CJ-Tourism-platform-back-end-development
基于.NetCore开发的“寸金游”（后端开发）




## 关于复现

* 修改appsettings.json中的DbContext的ConnectionString属性，使用visual Studio配备的SqlServer中，右键点击该数据库的属性，即可找到需填入的连接字符串。
* 更新数据库，使用Package Manage Console (PMC)（程序包管理器控制台）更新数据库，使用下方命令更新其数据库和表。

```c#
add-migration initialMigration0
    
update-database
```

* 本项目基于.net core3.1，所以请安装好所对应的microsoft.aspnetcore.identity.entityframeworkcore包，在这里使用的为3.1.3版本，如果报错，请降低entityframeworkcore包版本。

## API根文档

```json
[
    {
        
            // 自我链接
        "href": "https://localhost:44381/api",
        "rel": "self",
        "method": "GET"
    },
    {
        
            // 一级链接 旅游路线 “GET api/touristRoutes”
        "href": "https://localhost:44381/api/TouristRoutes",
        "rel": "get_tourist_routes",
        "method": "GET"
    },
    {
                    // 一级链接 旅游路线 “POST api/touristRoutes”
        "href": "https://localhost:44381/api/TouristRoutes",
        "rel": "create_tourist_route",
        "method": "POST"
    },
    {
                    // 一级链接 订单 “GET api/shoppingCart”
        "href": "https://localhost:44381/api/shoppingCart",
        "rel": "get_shopping_cart",
        "method": "GET"
    },
    {
        
            // 一级链接 购物车 “GET api/orders”
        "href": "https://localhost:44381/api/orders",
        "rel": "get_orders",
        "method": "GET"
    }
]
```
