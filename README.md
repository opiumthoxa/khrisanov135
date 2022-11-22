**Процесс увольнения**
===================
<h2 align="center">Описание предметной области</h2> 
Увольнение — согласно нормам права прекращение трудовых отношений между работником, который перестает выполнять свои служебные обязанности и работодателем, который перестает выплачивать сотруднику заработную плату. Процесс увольнения работника прописан в Трудовом кодексе РФ. Это основной нормативный документ, который регламентирует
взаимоотношения между сотрудником и работодателем. Кроме этого, расторжение трудового договора должно полностью соответсвовать Трудовому кодексу РФ и не противоречить ему.  

В случае ухода сотрудника — по собственному желанию или поинициативе руководства — компании выполняют ряд типовых процедур. Нужно оформить документы, уведомить руководителей, провести расчеты с увольняемым по заработной плате, удаление учетных записей для входа в системы, выдача трудовой книжки. При увольнении сотрудника по собственному желанию нужно рассмотреть его заявление об увольнении сотрудником отдела кадров. Далее проверяется правильно ли заполнена заявка, если нет, тогда её отправляют обратно инициатору для исправления ошибок. Затем увольняемый занимается отработкой положенного времени. После отдел кадров издает приказ об увольнении и происходит процесс увольнения. Если работника увольняют по инициативе руководства, тогда отдел кадров издает приказ об увольнении вместе с её причиной. Затем руководитель компании принимает решение в отношении к инициатору увольнения и передает его сотруднику отдела кадров. Далее решается судьба сотрудника, его либо оставляют на рабочем месте, либо увольняют. После всех процессов работнику выдают трудовую книжку вместе с записью в ней, затем бухгалтер производит расчеты по зарплате с увольняемым. В конце начальник отдела Ит удаляет все данные с учетной записи сотрудника и закрывает ему доступ к предприятию. Если связать все операции по увольнению сотрудников в единый бизнес-процесс и обеспечить его исполнение, сотрудникам становится ясно, что и в какой последовательности им нужно сделать. Это не только позволяет избежать лишних вопросов и уточнений, тем самым сократить время выполнения процедур. Сама компания получает уверенность, что все необходимые операции по процессу в итоге
действительно были выполнены.  

Данная предметная область непосредственно связана с калькулятором, он необходим для бухгалтерского расчета с увольняемым по его зарплате и многим другим вопросам. Калькулятор за счёт автоматизации упрощает поиск ошибок и сокращает время вычисления необходимых данных. Это способствует сокращению времени и более продуктивной работе.
<h2 align="center">BPMN модель</h2> 

Модель и нотация бизнес-процессов (BPMN) - это стандарт моделирования бизнес-процессов, который предоставляет графическую нотацию для указания бизнес-процессов в диаграмме бизнес-процессов (BPD), основанный на методе блок-схем, очень похожем на диаграммы действий из Unified Modeling Language (UML). Целью BPMN является поддержка управления бизнес-процессами как для технических пользователей, так и для бизнес-пользователей, предоставляя нотацию, которая интуитивно.

* Процесс увольнения сотрудника
![image](https://user-images.githubusercontent.com/105438468/195516864-0dde401f-3762-4615-aa91-270755d35289.png)
* Подпроцесс увольнения сотрудника по собственному желанию 
![image](https://user-images.githubusercontent.com/105438468/195517736-bcc3b910-f1c7-4ff1-8272-582b4da86d1b.png)
* Подпроцесс увольнения сотрудника по инициативе руководства
![image](https://user-images.githubusercontent.com/105438468/195517956-d68945e2-6a21-4f33-a610-98bd4d21bea2.png)
* Подпроцесс завершения увольнения
![image](https://user-images.githubusercontent.com/105438468/195517982-99131eee-b2ea-42d6-a1b3-39d56eeb013b.png)
<h2 align="center">Use case диаграмма</h2> 


![image](https://user-images.githubusercontent.com/105438468/197378366-a81415a6-a9ec-404d-b453-1f781bcaa99b.png)

<h2 align="center">IDEF1X модель</h2> 

![image](https://user-images.githubusercontent.com/105438468/198070127-c01c04e9-c053-4327-9ce6-63930ee36ea9.png)
### ***Описание основных сущностей ПО***
На основании проведенного анализа предметной области можно выделить следующие сущности:
* Сотрудники — перечень людей, работающих в компании и оказывающих услуги;
*  Увольнение по инициативе руководства — строго регламентированный законом процесс, нарушение которого дает уволенному право обратиться в суд и потребовать восстановления на работе;
* Увольнение по собственному желанию — одно из самых распространенных оснований расторжения трудового договора. Инициатива прекращения трудовых отношений исходит от работника и не предполагает ее одобрения работодателем;
*  Отдел кадров — это структура в организации, которая занимается управлением персоналом;
    
 Для  каждой сущности  есть атрибуты :

* Для сущности Сотрудники атрибутами будут является ФИО, должность;
* Для сущности Увольнение по инициативе руководства - это Номер приказа, Личный код, Дата, Причина;
* Для сущности Увольнение по собственному желанию — Номер заявления, Личный код, Дата, Причина;
* Для сущности Отдел кадров — Личный код, Номер приказа, Номер заявления, Дата, Причина;





