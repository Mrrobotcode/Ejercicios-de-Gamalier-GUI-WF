Este proyecto es un sistema de reserva de proveedores y productos desarrollado con Windows Forms. 
## Sistema de Mantenimiento para Proveedores y Productos

## Descripción

El sistema consta de un formulario MDI que organiza las funcionalidades mediante un menú principal con las siguientes opciones:

- **Mantenimiento:** Permite gestionar proveedores y productos.
  - **Proveedores:**
    - Formulario para registrar proveedores con campos de entrada y botones:
      - **Enviar:** Transfiere los datos ingresados a un DataGridView.
      - **Salir:** Cierra el formulario actual.
      - **Limpiar:** Vacía los campos del formulario.
    - Una sección adicional dentro de un Tab Control que contiene:
      - **DataGridView:** Muestra la lista de proveedores registrados.
      - **Botones:**
        - **Eliminar:** Borra un proveedor seleccionado.
        - **Limpiar:** Limpia los datos mostrados.
        - **Buscar:** Localiza registros específicos.
        - **Salir:** Cierra el formulario.
  - **Productos:**
    - Funciona de manera similar al módulo de proveedores, con formularios y opciones para gestionar los productos.

- **Salir:** Finaliza la ejecución del formulario MDI.

## Requisitos del Sistema

- **Sistema Operativo:** Windows 7 o superior.
- **Entorno de desarrollo:** Visual Studio 2022 (versión 17.11 o superior).
- **.NET Framework:** Compatible con la configuración predeterminada del proyecto.

### Pasos para abrir el proyecto

1. Clonar o descargar este repositorio en su máquina local.
2. Abrir el archivo `Practica_de_Gamalier_2_GUI_WF.sln` en Visual Studio.
3. Seleccionar la configuración deseada (Debug o Release).
4. Compilar y ejecutar el proyecto presionando `F5` o seleccionando la opción de inicio en Visual Studio.

## Funcionalidades Implementadas

- **Gestión de Proveedores:** Registro, visualización, búsqueda, eliminación y limpieza de registros.
- **Gestión de Productos:** Registro, visualización, búsqueda, eliminación y limpieza de registros.
- **Tab Control:** Organización de información y acciones en pestañas.
- **Formulario MDI:** Navegación centralizada a través de menús.
- **Interfaz gráfica intuitiva:** Controles optimizados para facilitar la interacción del usuario.

## Licencia

Este proyecto está licenciado bajo los términos que se establezcan en el repositorio original o según lo defina el creador del proyecto

## Autor

Desarrollado por Jose Genuel Mercedes Abreu, **A.K.A: Mrrobotcode**