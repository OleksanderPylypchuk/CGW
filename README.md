        Lazy initialization
Лінива ініціалізація - це породжувальний патерн дизайну, згідно якого об'єкт повинен створюватись вперше лише тоді, коли метод/властивість цього об'єкта вперше викликається/запитується. Це допомагає обмежити використовувані ресурси, та надавати користувачу лише той функціонал, який йому необхідний.
classDiagram
Class01 <|-- AveryLongClass : Cool
Class03 *-- Class04
Class05 o-- Class06
Class07 .. Class08
Class09 --> C2 : Where am i?
Class09 --* C3
Class09 --|> Class07
Class07 : equals()
Class07 : Object[] elementData
Class01 : size()
Class01 : int chimp
Class01 : int gorilla
Class08 <--> C2: Cool label


        Proxy
Проксі - структурний патерн дизайну, що дозволяє змінювати об'єкт, що виконує певні дії, об'єктом, що надає до нього доступ. Це дозволяє відсіювати некоректні запити до оригінального об'єкта, а також зменшувати на нього навантаження. Зазвичай використовується під час створення додатків з доступом до баз даних, серверних додатків, тощо. 


        Strategy
Стратегія - поведінковий патерн дизайну, згідно якого ПЗ повинно створюватись з передбаченням майбутніх розришень. Суть патерну полягає у тому, що б розділіти клас, що робить щось специфічне багатьма способами, на декілька класів-стратегій, що поділяють між собою функціонал. Це забезпечує чистоту та зрозумілість коду, а також полегшує розробку та випуск майбутніх оновлень.


        Monitor Object
Моніторинговий об'єкт - паралелістичний патерн дизайну, згідно з яким необідно інкапсулювати асинхронні методи всередині об'єкта. Це дозволяє обмежувати доступ до ресурсів та забезпечує те, що лише один із потоків одночасно буде мати доступ до перегляду та редагування ресурсів.
