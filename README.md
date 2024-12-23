# HuntingForum

„HuntingForum“ tai platforma, kurioje medžiotojai gali bendrauti vienas su kitu, dalintis savo medžioklės įspūdžiais. Platformoje gali kurti grupes, rašyti komentarus, bei reaguoti į vienas kito pranešimus.

# Sprendžiamo uždavinio aprašymas

## 1. Sistemos paskirtis

   
„HuntingForum“ yra medžiotojų bendruomenės forumas.
## 2. Funkciniai reikalavimai

   
### Vartotojų autentifikacija ir autorizacija:
•	Naudotojai turi galimybę registruotis, prisijungti prie sistemos bei atsijungti.

•	Vartotojai skirstomi į tris roles: forumo narys (gali tik naršyti), medžiotojas (gali kurti turinį) ir administratorius (gali valdyti sistemą).

### Grupės su įrašais ir komentarais:
•	Vartotojai gali kurti grupes, jose rašyti įrašus ir komentuoti kitų jau sukurtus įrašus, taip pat gali reguoti į įrašą.

## 3. Pasirinktų technologijų aprašymas
### Backend:

•	.NET naudojamas kaip serverio pusės sprendimas, leidžiantis kurti REST API.

•	Autentifikacija ir autorizacija įgyvendinama naudojant JWT (JSON Web Tokens).

•	MySQL naudojama kaip duomenų bazė.

### Frontend:

•	React.js naudojamas kurti interaktyvią ir greitą naudotojo sąsają.

## 4. Sistemos dizainas
### Sistemos išvaizda
![image](https://github.com/user-attachments/assets/e9d89618-e4c5-444d-9b1b-7ad5d1804cba)
![image](https://github.com/user-attachments/assets/190cff31-f2c5-4738-94e6-2aae4af49374)
![image](https://github.com/user-attachments/assets/db50a222-ab79-4de0-b07e-d72a219d3c6d)

### Modalinis langas
![image](https://github.com/user-attachments/assets/f0628cad-e03c-4cc9-a8a2-abd1858f1607)


## 5. UML "Deployment" Diagrama 
![image](https://github.com/user-attachments/assets/19165050-8c51-4ca5-bfca-7db209f32702)


## 7. „OpenAPI" specifikacija
Buvo realizuotos grupių, įrašų ir komentarų CRUD operacijos, vartotojų registracija, prisijungimas, profilio redagavimas.
```json
{
  "openapi": "3.0.1",
  "info": {
    "title": "PVP.Server",
    "version": "1.0"
  },
  "paths": {
    "/api/Auth/register": {
      "post": {
        "tags": [
          "Auth"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/RegisterDto"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/RegisterDto"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/RegisterDto"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Auth/login": {
      "post": {
        "tags": [
          "Auth"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/LoginDto"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/LoginDto"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/LoginDto"
              }
            }
          }
        }
