# Sistema de Gestión de Alumnos

Aplicación de consola desarrollada en C# para gestionar alumnos de una facultad.

El proyecto consiste en un ejercicio de Programación 2 en el que se aplica el patrón MVC y se trabaja con clases, objetos, métodos y listas.

## Funcionalidades

- Establecer y consultar la cuota general.
- Agregar alumnos con nombre, apellido y legajo.
- Buscar y mostrar los datos de un alumno por su legajo.
- Listar todos los alumnos registrados.
- Eliminar un alumno por su legajo.

## Clases

- `CVista`: se encarga de mostrar el menú, pedir datos y mostrar resultados.
- `CAlumnoControladora`: coordina las acciones de la aplicación.
- `CAlumnos`: administra la lista de alumnos.
- `CAlumno`: representa a cada alumno y gestiona la cuota general.

## Tecnologías y conceptos

- C#
- Programación orientada a objetos
- Patrón MVC
- Listas (`List<T>`)
- Constructores y métodos
- Atributos y métodos estáticos

## Cómo ejecutar

Abrir el proyecto en Visual Studio y ejecutar la aplicación desde `Program.cs`.

Los alumnos se almacenan en una lista en memoria, por lo que los datos se pierden al cerrar el programa.
