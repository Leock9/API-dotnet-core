# API

[![Codacy Badge](https://api.codacy.com/project/badge/Grade/cede65f341a4437abd6ab5b2ad774535)](https://app.codacy.com/manual/Leock9/API-dotnet-core?utm_source=github.com&utm_medium=referral&utm_content=Leock9/API-dotnet-core&utm_campaign=Badge_Grade_Dashboard)

## Tecnologias
 * [.NET Core 3.1](https://dotnet.microsoft.com/download)
 * [ASP.NET Core 3.1](https://docs.microsoft.com/en-us/aspnet/core)
 * [Entity Framework Core 3.1](https://docs.microsoft.com/en-us/ef/core)

## Ferramentas
* [Visual Studio Code](https://code.visualstudio.com)
* [Insomnia](https://insomnia.rest/)

 
 ## Requisições
 
 ### Adicionar Aluno 
 
* **URL**

  /Aluno/Adicionar

* **HTTP:**
  
   `POST` 
  

* **Body:JSON**

  {
    "Nome":"Seu Nome",
    "Idade":18,
    "Matricula":12345, 
    "Status": true
  }

* **Success Response:**

  * **Code:** 200 <br />

 ### Atualizar Aluno
 
* **URL**

  /Aluno/Atualizar

* **HTTP:**
  
   `PUT` 
  

* **Body:JSON**

  {
    "Id":"Guid"
    "Nome":"Seu Nome",
    "Idade":18,
    "Matricula":12345, 
    "Status": true
  }

* **Success Response:**

  * **Code:** 200 <br />
  
### Excluir Aluno
  
* **URL**

  /Aluno/Excluir?matricula=

* **Method:**

   `DELETE` 
  
*  **URL Params**

   /Aluno/Excluir?matricula=12345

   **Required:**
 
   `matricula=[int]`


* **Success Response:**
 
  * **Code:** 200 <br />

### Obter Aluno por Matricula
  
* **URL**

  /Aluno/Obter/Matricula?matricula=

* **Method:**

   `GET` 
  
*  **URL Params**

   Aluno/Obter/Matricula?matricula=12345

   **Required:**
 
   `matricula=[int]`


* **Success Response:**
 
  * **Code:** 200 <br />
  **Content:** `  
  {
    "Id":"Guid"
    "Nome":"Seu Nome",
    "Idade":18,
    "Matricula":12345, 
    "Status": true
  }`
  
### Obter Todos os Alunos
  
* **URL**

  /Aluno/Obter/Alunos

* **Method:**

   `GET` 
  
* **Success Response:**
 
  * **Code:** 200 <br />
  **Content:** `  
 [ {
    "Id":"Guid"
    "Nome":"Seu Nome",
    "Idade":18,
    "Matricula":12345, 
    "Status": true
  } ]`  
  
 
