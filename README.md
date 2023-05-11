# 66bitPractice

Тестовое задание "Каталог футболистов 3.0: сделать веб-приложение с отображением списка игроков и возможностями добавлять, изменять и удалять их.<br>
<a href="https://practice.66bit.ru/task/csharp.pdf">Ссылка на оригинал задания</a><br>
Файл создания базы данных находится в проекте => <a href="https://github.com/Abzaparov-Nikolay/66bitPractice/blob/main/script_encoding_utf16.sql">script_encoding_utf16.sql файл</a><br>
Строка подключения к бд расположена в файле <a href="https://github.com/Abzaparov-Nikolay/66bitPractice/blob/main/appsettings.json">appsettings.json</a> Параметр <i>"DefaultConnectionString"</i>

Взгляд на страницу с игроками: <br>
!["ShowView"](githubImages/ShowView.png)

<br>
Взгляд на страницу добавления игрока: <br> 

!["ShowView"](githubImages/AddView.png)
<br>
Там же можно добавить новую команду:<br>

!["ShowView"](githubImages/AddViewAddTeam.png)<br>

Игроков можно редактировать:

!["ShowView"](githubImages/EditView.png)<br>

Реализовано отображение данных по игрокам в реальном времени. При изменении записей другим пользователем, данные обновляются у всех пользователей сразу же: 

!["ShowView"](githubImages/signalRShowcase.gif)<br>

Изменения реализованы с помощью библиотеки отправки уведомлений SignalR
