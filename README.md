# Sistema de Gestión de Empleados con Herencia y Clases Abstractas

## Integrante

* Eduardo Andre Sanchez Cabrera SC262393

---

# Descripción del proyecto

Este proyecto consiste en una aplicación de consola desarrollada en **C#**, cuyo objetivo es gestionar empleados de una empresa utilizando los principios de la **Programación Orientada a Objetos (POO)**.

El sistema permite registrar diferentes tipos de empleados, calcular automáticamente sus salarios, realizar búsquedas por ID, eliminar empleados y mostrar toda la información almacenada.

---

# Objetivos

* Aplicar el concepto de **Herencia**.
* Implementar una **Clase Abstracta**.
* Utilizar métodos **abstract** y **override**.
* Implementar una **Excepción Personalizada**.
* Utilizar una colección **List<Empleado>** para almacenar la información.
* Aplicar validaciones de datos para garantizar la integridad de la información.

---

# Tipos de empleados

El sistema administra tres tipos de empleados:

* Empleado por Hora
* Empleado Asalariado
* Empleado Comisionista

Cada uno implementa su propia forma de calcular el salario mediante el método **CalcularSalario()**, demostrando el uso del polimorfismo.

---

# Jerarquía de clases

La clase **Empleado** es una clase abstracta que contiene los atributos y métodos comunes para todos los empleados.

De ella heredan las siguientes clases:

* EmpleadoPorHora
* EmpleadoAsalariado
* EmpleadoComisionista

Además, se implementó una excepción personalizada llamada **EmpleadoNoEncontradoException**, la cual permite controlar los errores cuando un empleado no existe dentro del sistema.

La clase **Empresa** es la encargada de administrar la lista de empleados y realizar las operaciones principales como agregar, buscar, mostrar y eliminar empleados.

---

# Funcionalidades implementadas

* Agregar empleados.
* Mostrar todos los empleados registrados.
* Buscar un empleado por su ID.
* Eliminar un empleado.
* Calcular salarios automáticamente.
* Validar que el ID no esté repetido.
* Validar que los datos numéricos sean positivos.
* Manejo de excepciones mediante una excepción personalizada.

---

# Diagrama UML

El proyecto incluye un diagrama UML donde se representa:

* La clase abstracta **Empleado**.
* Las clases derivadas:

  * EmpleadoPorHora
  * EmpleadoAsalariado
  * EmpleadoComisionista
* La clase **Empresa**.
* La excepción **EmpleadoNoEncontradoException**.

><img width="653" height="480" alt="image" src="https://github.com/user-attachments/assets/e8b5b7e4-41ed-4135-80ff-8f0e9466338c" />
---

# Cómo ejecutar el proyecto

1. Abrir la solución **SistemaGestionEmpleados** en Visual Studio.
2. Compilar el proyecto.
3. Ejecutar la aplicación.
4. Seleccionar una opción del menú.
5. Probar las diferentes funcionalidades del sistema.

---


# Conclusión

Este proyecto permitió aplicar los principales conceptos de la Programación Orientada a Objetos mediante el desarrollo de un sistema de gestión de empleados. Se utilizaron clases abstractas, herencia, polimorfismo, métodos `override`, listas genéricas y excepciones personalizadas para construir una aplicación organizada, reutilizable y fácil de mantener.
