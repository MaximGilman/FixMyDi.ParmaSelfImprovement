# PARMA TG. ИПР

## Данный проект содержит WEB API .NET CORE приложение
#### В нем **намеренно добавлены ошибки**. Необходимо их исправить таким образом, чтобы оба метода контроллера работали согласно спецификации

<br>
<br>

## Спецификация
Должно быть доступно 2 метода - GET (Ping) и POST (Run). 
Оба должны возвращать значение, которое описано в контроллере

Метод **Ping** возвращает строку "Alive" и служит для проверки работоспособности контроллера.

Метод **Run** имитирует бизнес-логику и работает с параметрами, передаваемыми пользователем.

<br>

> Метод **Run** должен возвращать значение по следующему запросу 

```
curl --location --request POST 'https://localhost:5001/api/weatherforecast/Run?temperature=1'
```
*(порт: 5001 в запросе может быть заменен на локальной машине. Важны **URL и параметры**)*


Необходимо внести 3 изменения для того, чтобы данный проект заработал. Изменения должны решить следующие проблемы, которые были добавлены в код

1. Ошибка в жизненном цикле зависимости
2. Ошибка инъекции зависимости
3. Ошибка в обработке параметра в методах контроллера

Помимо этого, необходимо ответить на вопросы:
> 1. Почему данные ошибки возникают
> 2. Какое есть другое решение, кроме предложенного? 
> 3. По какому URL доступны имеющиеся методы (GET и POST)
 
