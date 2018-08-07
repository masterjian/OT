<!DOCTYPE html>
<html lang="en">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <title>ASP.NET MVC 应用程序回顾</title>
    <style>
        body {
            background: #fff;
            color: #505050;
            font: 14px 'Segoe UI', tahoma, arial, helvetica, sans-serif;
            margin: 20px;
            padding: 0;
        }

        #header {
            background: #efefef;
            padding: 0;
        }

        h1 {
            font-size: 48px;
            font-weight: normal;
            margin: 0;
            padding: 0 30px;
            line-height: 150px;
        }

        p {
            font-size: 20px;
            color: #fff;
            background: #969696;
            padding: 0 30px;
            line-height: 50px;
        }

        #main {
            padding: 5px 30px;
        }

        .section {
            width: 21.7%;
            float: left;
            margin: 0 0 0 4%;
        }

            .section h2 {
                font-size: 13px;
                text-transform: uppercase;
                margin: 0;
                border-bottom: 1px solid silver;
                padding-bottom: 12px;
                margin-bottom: 8px;
            }

            .section.first {
                margin-left: 0;
            }

                .section.first h2 {
                    font-size: 24px;
                    text-transform: none;
                    margin-bottom: 25px;
                    border: none;
                }

                .section.first li {
                    border-top: 1px solid silver;
                    padding: 8px 0;
                }

            .section.last {
                margin-right: 0;
            }

        ul {
            list-style: none;
            padding: 0;
            margin: 0;
            line-height: 20px;
        }

        li {
            padding: 4px 0;
        }

        a {
            color: #267cb2;
            text-decoration: none;
        }

            a:hover {
                text-decoration: underline;
            }
    </style>
</head>
<body>

    <div id="header">
        <h1>ASP.NET MVC 应用程序回顾</h1>
        <p>今天! 我们通过创建了一个在线测试项目，完成对Asp.Net MVC的概念的回顾，通过此次回顾，你将学会如何创建并完成一个带有业务逻辑功能的网站的开发。</p>
        <p>项目中使用到的技术特性有：</p>
        <ul>
            <li><a href="http://modernizr.cn/">modernizr-一个 JavaScript 库，用于检测并“修复”用户浏览器的 HTML5 与 CSS3 特性</a></li>

        </ul>
        </div>

    <div id="main">
        <div class="section first">
            <h2>此应用程序包含:</h2>
            <ol>
                <li>使用较新（不是最新）的第三方组件（类库）完成系统功能的“搭建”</li>
                <li>使用 <a href="http://go.microsoft.com/fwlink/?LinkID=615519">Bootstrap</a> 进行主题定位</li>
                <li>完成基本的身份验证，如果选择此项，则将显示如何注册和登录</li>
                <li>使用 <a href="http://go.microsoft.com/fwlink/?LinkID=320756">NuGet</a> 管理的 ASP.NET 功能</li>
                <li>充分利用VS2015的脚手架（基架）功能，完成功能开发</li>
                <li>自定义脚手架（基架）自动生成的文件模板</li>
                <li>基于微软测试框架的基本单元测试</li>
                </ol>
        </div>

        <div class="section">
            <h2>自定义应用的功能</h2>
            <ol>
                <li>用户的登录、注册功能。其中管理员由系统内置，不需要单独注册</li>
                <li>系统支持多个班级的考试功能，每个班级下有不同的学生</li>
                <li>系统的学生信息通过Excel导入到系统中</li>
                <li>系统使用的题库，通过Excel导入到系统中</li>
                <li>每道题可以设置分值，题目所属的章节</li>
                <li>系统可以新建试卷，新建试卷时，可以自动指定或者手动指定题目的来源</li>
                <li>考试完成之后，学生可以查看自己的分数，老师可以查看和导出所有学生的考试成绩</li>
                <li></li>
                <li><a href="http://go.microsoft.com/fwlink/?LinkID=615523">更改站点的主题</a></li>
                <li><a href="http://go.microsoft.com/fwlink/?LinkID=615524">使用 NuGet 添加更多库</a></li>
                <li><a href="http://go.microsoft.com/fwlink/?LinkID=615542">配置身份验证</a></li>
                <li><a href="http://go.microsoft.com/fwlink/?LinkID=615526">自定义网站用户的相关信息</a></li>
                <li><a href="http://go.microsoft.com/fwlink/?LinkID=615527">从社交提供商获取信息</a></li>
                <li><a href="http://go.microsoft.com/fwlink/?LinkID=615528">使用 ASP.NET Web API 添加 HTTP 服务</a></li>
                <li><a href="http://go.microsoft.com/fwlink/?LinkID=615529">保护 Web API</a></li>
                <li><a href="http://go.microsoft.com/fwlink/?LinkID=615530">使用 ASP.NET SignalR 添加实时 Web</a></li>
                <li><a href="http://go.microsoft.com/fwlink/?LinkID=615531">使用 Scaffolding 添加组件</a></li>
                <li><a href="http://go.microsoft.com/fwlink/?LinkID=615532">使用 Browser Link 测试应用</a></li>
                <li><a href="http://go.microsoft.com/fwlink/?LinkID=615533">共享项目</a></li>
            </ol>
        </div>

        <div class="section">
            <h2>部署</h2>
            <ol>
                <li>通过文件系统部署</li>
                <li>通过IIS部署</li>
                <li>通过FTP部署</li>
                <li>了解托管服务器的相关知识</li>
            </ol>
        </div>

        <div class="section last">
            <h2>获取帮助</h2>
            <ol>
                <li>什么样的帮助是必须的？</li>
                <li>好的项目管理，是项目成功的保证</li>
            </ol>
        </div>
    </div>

</body>
</html>
