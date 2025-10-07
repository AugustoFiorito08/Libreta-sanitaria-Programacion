[Link Diagrama de Clases](https://lucid.app/lucidchart/f0e4fb76-1a8e-4995-be2d-61d92bf68501/edit?viewport_loc=-184%2C-1353%2C3251%2C1538%2C0_0&invitationId=inv_ba4a12ba-e3d8-4172-9df8-5c23d8b7959d)


# Libreta-sanitaria-Programacion

 **Resumen del Contexto del Proyecto**

El proyecto **“Libreta Sanitaria Digital”** surge ante la necesidad de modernizar el control sanitario de las mascotas.
Actualmente, la mayoría de los dueños anotan las vacunas, tratamientos o turnos en libretas físicas o directamente no llevan un registro adecuado, lo que genera pérdida de información y desorganización en la atención veterinaria.

La aplicación propuesta busca **digitalizar este proceso**, brindando a los dueños de mascotas y veterinarios una herramienta práctica, que permita registrar, consultar y mantener actualizada la información sanitaria de los animales.

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

Permita gestionar de forma digital la información sanitaria de las mascotas, optimizando el seguimiento médico y la comunicación entre dueños y veterinarios.

**Objetivos específicos:**

1. Permitir el **registro y acceso seguro** de usuarios según su rol (Dueño o Veterinario).
2. Facilitar la **gestión completa de las mascotas**, incluyendo vacunaciones, tratamientos y turnos.
3. Ofrecer **recordatorios automáticos y notificaciones** sobre vacunas y citas próximas.
4. Generar **reportes y certificados en PDF**, asegurando la disponibilidad y respaldo de la información.
5. Garantizar la **funcionalidad offline**, sincronizando los datos cuando se recupere la conexión.


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

