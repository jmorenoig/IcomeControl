# Introducción  
La idea con este proyecto es crear un codigo que sirva para practicar Netcore, SQL Server y a su vez contarlo en Azure DevOps como práctica.
Este programa es un gestor de gastos que permite, ingresar las categorías de cada gasto que se tiene y además de esto ingresar los ingresos y gastos, a su vez filtrarlos por Mes/Año.  

# Inicio 
para poner en funcionamiento el código, se deben seguir los siguientes pasos:  

**Dependencias:** 

para que el Software corra correctamente se debe instalar primero las siquientes dependencias:
- [.NET Core](https://dotnet.microsoft.com/download) version 5.0, como lenguaje de programacion.
- [Visual Studio 2019](https://visualstudio.microsoft.com/es/vs/) como editor de código. 
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) como gestor de base de datos.

**Proceso de instalación:** 
- Cuando estés dentro del repositorio en Git, puedes descargar el software de las siguientes maneras, debe dar clic sobre code y luego, la primera opción es descargando el documento zip, descomprimirlo y ponerlo a correr desde vs 2019 o el editor de tu preferencia, la segunda opción es copiar el link que aparece en la opción clone

![Image-1](https://i.postimg.cc/RFV90zqV/image-1.png)

- Cuando Realice los pasos anteriores, ingresa a la pestaña de comandos de su preferencia, ingresa a la carpeta donde desea guardar el programa y ejecuta el siguiente comando con la línea de comando anteriormente copiada. 
```javascript
git clone https://github.com/jmorenoig/IcomeControl.git
```

- Al finalizar los siquientes pasos el programa esta listo para ser ejecutado, para ejecutarlo debemos abrir la carpete donde se guardo y presionar doble clic sobre IcomeControl.sln

![Image-6](https://i.postimg.cc/BbdH0bV1/Image-6.png)

- se abrira el Vs2019

![Image-7](https://i.postimg.cc/RVHwT1W1/Image-7.png)

- presionamos clic sobre IIS Express

![Image-8](https://i.postimg.cc/zDMnW2GX/Image-8.png)

- despues de esto el programa esta ra listo para ser usado

![Image-9](https://i.postimg.cc/fTgMfb2Y/Image-9.png)

# Construir y Probar
Para construir desde el inicio este código se deben realizar los siguientes pasos:

-	Ingresamos a Visual Studio 2019 y damos clic sobre Crear un nuevo proyecto

![Image-12](https://i.postimg.cc/k5TTGwQm/Image-12.png)
![Image-11](https://i.postimg.cc/SQ3tcZwQ/Image-11.png)

-	Nos aseguramos de colocar el lenguaje deseado en este caso C#, marcamos el sistema operativo, y colocamos la opción de aplicación web

![Image-13](https://i.postimg.cc/6pNjm8WD/Image-13.png)

-	Después de colocar el tipo de lenguaje y donde se va a correr, marcamos la opción de ASP.NET Core Web App (Model-View-Controller)

![Image-14](https://i.postimg.cc/65ZbcrXr/Image-14.png)

-	Llenamos los datos que piden, el cual es el nombre del programa y la versión de .Net que se va a usar para la codificación, debes marcar la casilla de ** Entable Razor runtime compilation** y se creará la siguiente pantalla donde se procederá a crear el código

![Image-15](https://i.postimg.cc/ydWvZ9jS/Image-15.png)

**Las partes importantes del código son**
-	La carpeta Dependencias la cual es donde se almacenan todos los paquetes NuGet.

![Image-16](https://i.postimg.cc/BbKph0dS/Image-16.png)

-	La carpeta wwwroot la cual es donde se almacenan todos los archivos de diseño y viene integrada con Bootstrap

![Image-17](https://i.postimg.cc/HxK34xvv/Image-17.png)

-	La carpeta Controller donde se encuentran almacenados los archivos encargados de controlar el software 

![Image-18](https://i.postimg.cc/jjx8RBJc/Image-18.png)

- Estos archivos se envian a la carpeta View la cual se encarga de generar una interfas grafica para manejar los controladores

![Image-21](https://i.postimg.cc/Pxx2zvWY/Image-21.png)

- Una carpeta tambien muy importante es la carpeta Models, en la cual se almacenen las clases y modelos que se convertiran en la base de datos

![Image-20](https://i.postimg.cc/25T0Z7ZC/Image-20.png)

- El archivo appsettings.json con el siguiente comando realiza la conexión con la base de datos
```javascript
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=IcomeControlDB;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
```

-	El archivo anterior se apoya en la carpeta Data la cual almacena el archivo ApplicationDbContext.cs, quen se encargan de la conexión y gestión de la base de datos

![Image-19](https://i.postimg.cc/GmGPkJ6Z/Image-19.png)

- El archivo Startup.cs es el encargado de todo lo relacionado con la inyeccion de dependencias 

![Image-19](https://i.postimg.cc/LX82tDQD/Image-22.png)


# Contribuir
Para contribuir con el codigo se puede usar Git y Azure DevOps, lo primero es clonar el Software en el quipo que esten usando, para clonarlo se deben seguir los pasoa mostrados en el **Inicio/Proceso de instalación** 

- Despues de clonar el archivo, se realizan las modidificaciones nesesarias, al de hacer dichas modificaciones, se abilitara en la parte inferior derecha una pestaña con el icono de un lapiz mostrando la cantidad de cambios realizados 

![Image-31](https://i.postimg.cc/8c1Jr9qC/Image-31.png)

- Cuando se da clic sobre esa pestaña abre una nueva, con un cuadro de texto para agregar el commit y un boton llamado **Commit All** donde da las diferentes opciones para agregar los cambios al Software, en este caso como se desea montar mejoras se marca la opción **commit All and Push** 

![Image-30](https://i.postimg.cc/k5GdDc1d/Image-30.png)

- Al momento de montar los cambios se crea un Branch en el cual registra los cambios realizados, para integrar este Branch a otra rama se debe ingresar a Repos luego a Pull requests 

![Image-23](https://i.postimg.cc/x8ckRM1r/Image-23.png)

- Cuando ingresas a Pull requests debes seleccionar la rama donde estan los cambios y luego la rama donde deseas unirlos 

![Image-24](https://i.postimg.cc/Zn2WDnWW/Image-24.png)

- al momento de estar seleccionado, se agrega titulo y descrippción y presionas **create**

![Image-25](https://i.postimg.cc/DwVWrWVD/Image-25.png)

- cuando se crea aparece esta pantalla y le damos **Aprove** y si hay mas personas encargadas de la aprobación, se debe esperar a que los demás también lo aprueben 

![Image-26](https://i.postimg.cc/Zq4CQ15x/Image-26.png)

- cuando lo aprueban aparece la siquiente notificacion

![Image-27](https://i.postimg.cc/jS09HpHs/Image-27.png)

- cuando ya este aprovado damos clic sobre **complete** apareciendo la siquiente ventana

![Image-28](https://i.postimg.cc/qB567b1p/Image-28.png)

- ya para finalizar le damos a **Complete merge** para montar los cambios, registrando este mensaje 

![Image-](https://i.postimg.cc/T3KVP1L1/Image-29.png)
