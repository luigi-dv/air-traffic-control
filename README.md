# Proyecto de Programación Grupo 6

Simulador de vuelo  del grupo G6 

## Authors: 
* Edgar Albiol:   edgar.albiol@estudiantat.upc.edu 
* Andrea Chong:   andrea.victoria.chong@estudiantat.upc.edu 
* Luigelo Davila: luigelo.miguel.davila@estudiantat.upc.edu


## Installation

Usando la herramienta [git clone](https://git-scm.com/docs/git-clone) para descargar el programa.
Se creará una carpeta llamada "ProjectG6" en el origen.
```bash
git clone https://github.com/LuigeloDV/ProjectG6.git
```
Descargando manualmente el fichero comprimido .zip
```bash
 C:\Users\user\Download\ProjectG6.zip
```


## Run
 Ejecuta el archivo "ProjectG6.sln". Una vez en la ventana de Visual Studio pulsa F5.
 
 Se construirá y ejecutará el programa.
 
```c#
Build started...
========== Build: 0 succeeded, 0 failed, X up-to-date, 0 skipped ==========
```

## Load Resources From Debug
  En caso de querer cargar los recursos desde la carpeta bin/debug de cada programa es necesario 
  realizar los siguientes pasos:
  
  Formato inicial
  ```bash
  C:\Users\user\Directory\ProjectG6\Resources 
  ```
   
   
   Formato final
```bash
C:\Users\user\Directory\ProjectG6\Program_Folder\bin\debug\Resources
```

   Copiamos la carpeta dentro del *program_folder* el cual es el directorio del programa que hagamos el debug.
   
   
## Functionalities
 Las funcionalidades adicionales de este proyecto son las siguientes:
 
- Register: 
    - El programa registra un usuario recoge el email, username, password. 
    - Hay una opción para que el usuario pueda ver la contraseña que ha introducido y una confirmación de contraseña para que     el usuario no introduzca valores incorrectos.
    - Al registrarse se envia un código de confirmación al email del usuario para confirmar el registro.
    - Una vez registrado se redirige al formulario principal del programa y se muestra su username.
- Login:
    - El programa pide al usuario introducir sus datos y se comprueba si son validos. 
- Remember simulated flights: 
    - El programa muestra una lista de todas las simulaciones hechas por el usuario desde que creo su cuenta
- Visit Github Repo: 
    - El programa redirige hacia el repositorio Github del proyecto.
    

## Mailing

Usted puede introducir los servidores de correos y clientes que desee de la siguiente manera.

En Register.cs en las primeras lineas de código (15-25)
```bash
private const string EMAIL = "YOUR EMAIL";
private const string SERVER = "YOUR SMTP SERVER";
private const int PORT = YOUR SMTP SERVER PORT;
```
En la consola de su editor de texto, IDE o en sqlite3.exe:

```bash
INSERT INTO emailClients VALUES (id, "username", "psw")
```
* username es un VARCHAR donde se introducirá el email 
* psw es un VARCHAR donde se introducirá la contraseña
 

## Errors
En caso de presentar errores en el programa asegurese de que la carpeta "Resources" existe. 
En caso contrario proceda a descargar el repositiorio e insertela en el origen manualmente.  
 
 *Si todo lo anterior no funciona porfavor pongase en contacto con nosotros encontrará nuestra información [aquí](#Authors)
 
 
 
 
## Contributing
Los "pull requests" son bienvenidas. Para cambios importantes, abra un problema primero para discutir qué le 
gustaría cambiar.

Asegúrese de actualizar las pruebas según corresponda.
## License
[MIT](https://choosealicense.com/licenses/mit/)
