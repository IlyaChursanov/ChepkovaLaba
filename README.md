Для создания таблицу пользователем запрос SQL:
CREATE TABLE Users (
UserID SERIAL PRIMARY KEY,
Username VARCHAR(50) UNIQUE NOT NULL,
Password VARCHAR(50) NOT NULL,
Role VARCHAR(20) NOT NULL
);
Для создания таблицы ремонта заявок:
CREATE TABLE Repairs (
RequestNumber SERIAL PRIMARY KEY,
DateAdded DATE NOT NULL,
Equipment VARCHAR(100) NOT NULL,
FaultType VARCHAR(100) NOT NULL,
ProblemDescription TEXT NOT NULL,
Client VARCHAR(100) NOT NULL,
Status VARCHAR(20) NOT NULL
);
