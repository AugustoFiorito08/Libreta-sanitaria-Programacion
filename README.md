



# Libreta-sanitaria-Programacion

 **Resumen del Contexto del Proyecto**

La proyecto propuesto busca hacer un programa para dueños de mascotas y veterinarios, que permita registrar, consultar y mantener actualizada la información sanitaria de los animales.

 **Descripción breve del sistema**

El sistema **gestiona información sanitaria de mascotas**, incluyendo vacunaciones, tratamientos, turnos y datos médicos generales.
Permitirá el registro de dos tipos de usuarios: **dueños de mascotas** y **veterinarios**, cada uno con permisos y funcionalidades específicas.

 **Entidades principales:**

* **Mascota:** nombre, especie, raza, edad, sexo, peso, código QR.
* **Vacunación:** nombre, dosis, tipo, fecha, lugar.
* **Usuario (Dueño/Veterinario):** datos personales, credenciales de acceso.
* **Historial médico:** conjunto de vacunas, tratamientos y observaciones asociadas a cada mascota.


 **Objetivos y funcionalidades previstas**

**Objetivo general:**

Permita gestionar la información sanitaria de las mascotas, el seguimiento médico y la comunicación entre dueños y veterinarios.

**Objetivos específicos:**

1. Permitir el **registro y acceso seguro** de usuarios según su rol (Dueño o Veterinario) (ABM Usuario).
2. Permitir el **registro de una mascota** (AMB Mascotas)
3. Facilitar la **gestión completa de las mascotas**, incluyendo vacunaciones, tratamientos y turnos.
4. Ofrecer **recordatorios automáticos y notificaciones** sobre vacunas y citas próximas.


 **Funcionalidades con Alta, Baja y Modificación**

 1. **Gestión de Mascotas**
* **Alta:** El dueño registra una nueva mascota completando sus datos (nombre, especie, raza, edad, sexo).
* **Baja:** El usuario puede eliminar una mascota del sistema.
* **Modificación:** Se pueden editar los datos básicos o actualizar el peso y estado sanitario.

 2. **Gestión de Vacunaciones**
* **Alta:** El veterinario o dueño carga una nueva vacunación con nombre, dosis, tipo, fecha y lugar.
* **Baja:** Se puede eliminar un registro de vacunación erróneo.
* **Modificación:** Permite actualizar la información de una vacunación (por ejemplo, fecha o tipo).

**Reportes previstos**

1. **Reporte de historial médico por mascota**
Genera una lista con todas las vacunas, tratamientos y observaciones médicas registradas para una mascota específica.
Incluye nombre del veterinario, fechas, dosis y observaciones relevantes.

2. **Reporte de vacunaciones próximas**
Permite visualizar un listado de vacunas que están por vencer o próximas a aplicarse, con fechas y tipo de vacuna.
Este reporte puede ser generado automáticamente o consultado manualmente por el usuario.

**Explicacion de Cada Capa**

Para guardar un registro en la base de datos, primero vamos a tener una clase ApplicationDbContext para crear la coneccion con esta con EntityFramework, luego una carpeta Repositorys donde se van a crear todos los repositorios necesarios para cada clase, conectandose con la carpeta de Models donde van a estar cada una de las clases. Como ultima capa vamos a tener los WindowsForm, o Front donde los usuarios van a poder interactuar, ingresando los datos necesarios para la creacion, modificacion o eliminacion de un registro. Tambien como poder ver listas o registros. 

**Diagrama de Clases**

[Link Diagrama de Clases](https://lucid.app/lucidchart/f0e4fb76-1a8e-4995-be2d-61d92bf68501/edit?viewport_loc=-184%2C-1353%2C3251%2C1538%2C0_0&invitationId=inv_ba4a12ba-e3d8-4172-9df8-5c23d8b7959d)

