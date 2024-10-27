####***[Серверная часть приложения]([https://github.com/username/my-awesome-project](https://github.com/Gandoler/Cpo_server))***

### 1. **Перечень технологий для реализации проекта**

Для реализации вашего проекта (десктопное приложение, подключающееся к базе данных и взаимодействующее с Telegram API) потребуются следующие технологии:

#### Языки и платформы:
- **C# (WPF или Windows Forms)** – для создания десктопного приложения.
- **.NET Core или .NET Framework** – платформа для разработки десктопного приложения, поддерживающая работу с библиотеками и сетевыми интерфейсами.
- **Python** --для создания серверной части нашего проекта.
- **freesqldatabase** - для развертки базы данных на движке **InnoDB**
  
#### Взаимодействие с API:
- **Telegram Bot API** – для работы с контактами в Telegram.
- **Hugging Face API** - для генерации  поздравдения исппользуя бесплатный аналог ChatGPT
    
#### Управление базой данных:
- **freesqldatabase** - для развертки базы данных на движке **InnoDB**

#### Библиотеки и инструменты для уведомлений:
- **Shedule** – библиотеки для реализации системы оповещений, работающей по расписанию.

### 2. **Обоснование выбора технологий**

1. **C#,Windows Forms,Python**:
   - **Почему C#?** Это мощный язык для создания десктопных приложений с отличной поддержкой экосистемы .NET. 
   - **Почему  Windows Forms?** Это надежные платформы для создания GUI-приложений, с удобными возможностями для создания пользовательских интерфейсов и быстрой настройкой.
   - - **Почему  Python ** Удобство работы с телеграм Api и Api нейросети для генарации текста.
   
2. **Telegram Bot API**:
   - **Почему Telegram API?** Это простое и удобное API для работы с контактами Telegram, предоставляющее мощные возможности для интеграции.
   
3. **Hugging Face API**:
   - **Почему Hugging Face?** -бесплатный и очень плохой аналог CHATGPT Api .
   
4. **freesqldatabase**:
   - **Почему реляционные базы данных на freesqldatabase?** -бесплатный сервис для развртывания баззы данных на сервере.
   

6. **Shedule**:
   - **Почему таймеры?**- простая библиотека на Python для работы по расписанию.

### 3. **Декомпозиция разрабатываемой системы и модули**

Для успешной реализации проекта система будет разбита на следующие модули:

#### 1. **Интерфейс пользователя (UI)**
   - **Описание**: Модуль, отвечающий за визуализацию и взаимодействие пользователя с приложением. Он будет включать экраны входа, регистрации, для отображения друзей(добавления,удаления,обновления).
   - **Технология**: Windows Forms.

#### 2. **Модуль взаимодействия с Telegram API**
   - **Описание**: Модуль, отвечающий за интеграцию с Telegram API для получения данных о контактах и их днях рождения.
   - **Технология**: HTTP-клиент с использованием Telegram Bot API.
   - **Функции**:
     - Получение списка контактов.
     - Обновление информации о днях рождения.

#### 3. **freesqldatabase**
   - **Описание**: Модуль для работы с базой данных, который будет обрабатывать запросы на сохранение и получение данных.
   - **Технология**: InbnoDB.
   - **Функции**:
     - Сохранение данных о друзьях (возраст, интересы, дни рождения).
     - Получение данных для отображения в UI.

#### 4. **Shedule**
   - **Описание**: Модуль для создания и отправки уведомлений пользователю о предстоящих событиях (дни рождения, праздники).
   - **Технология**:Shedule.
   - **Функции**:
     - Создание расписания для уведомлений.
     - Оповещение пользователя через интерфейс программы.

#### 5. **Модуль бизнес-логики**
   - **Описание**: Основной модуль приложения, который будет координировать работу всех остальных модулей. В нем будет реализована логика взаимодействия с API, базой данных и генерацией уведомлений.
   - **Технология**: .NET Core.
   - **Функции**:
     - Взаимодействие между интерфейсом и модулями.
     - Обработка данных, поступающих от пользователя и базы данных.



Эта декомпозиция помогает структурировать проект, распределяя ответственность между модулями, и обеспечивает модульную архитектуру, где каждый модуль выполняет свою отдельную задачу.
