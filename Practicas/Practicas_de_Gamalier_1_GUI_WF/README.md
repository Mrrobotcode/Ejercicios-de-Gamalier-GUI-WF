# Proyecto de Gestión de Empleados

Este proyecto es una aplicación de escritorio desarrollada en C# utilizando **Windows Forms**. Permite gestionar empleados, realizar cálculos relacionados con sus sueldos y bonificaciones, y guardar los datos en un archivo de texto con formato tabular.

## Características

- **Formulario de Entrada:**  
  En la primera página del **Tab Control**, el usuario puede ingresar los datos del empleado, como nombre, cargo, sueldo, y cantidad de hijos.  
  También incluye etiquetas (`Labels`) para mostrar resultados de cálculos.

- **Tabla de Datos:**  
  En la segunda página del **Tab Control**, se muestra un **DataGridView** que almacena la información de los empleados ingresados.

- **Cálculos Automáticos:**  
  - Cálculo del sueldo bruto, bonificación por hijos, y sueldo neto.
  - Cálculo de descuentos por AFP y SFS.
  - Determinación del ISR basado en el ingreso anual.

- **Opciones de Gestión:**  
  - Agregar nuevos empleados.
  - Modificar datos de empleados existentes seleccionando filas en el **DataGridView**.
  - Guardar los datos en un archivo de texto con un diseño tabular.

## Diseño de la Aplicación

### Primera Página: Formulario
- **Campos de entrada**:
  - Nombre del empleado.
  - Cargo.
  - Sueldo.
  - Cantidad de hijos.
- **Resultados calculados**:
  - Sueldo neto.
  - Descuentos por AFP y SFS.
  - ISR y total de descuentos.

### Segunda Página: Tabla de Datos y Generacion y Visualizacion de Archivo
- Contiene un **DataGridView** donde se listan los empleados con las siguientes columnas:
  - Nombre.
  - Cargo.
  - Sueldo Bruto.
  - Hijos.
  - Incentivo.
  - AFP.
  - SFS.
  - ISR.
  - Total Descuentos.
  - Sueldo Neto.

- Contiene un **Boton** para genera un archivo de texto que contenga la informacion del **DataGridView**.
- Contiene un **Boton** para limpiar todos los datos del **DataGridView**.

## Uso de la Aplicación

1. **Ingreso de Datos:**
 - Completa todos los campos en la primera página del **Tab Control**.
 - Los resultados de los cálculos aparecerán automáticamente en las etiquetas.

2. **Agregar al DataGridView:**
 - Presiona el botón **Guardar** para agregar la información al **DataGridView** en la segunda página.

3. **Modificar Datos:**
 - Selecciona una fila en el **DataGridView**.
 - Los datos seleccionados se cargarán automáticamente en los campos del formulario.
 - Modifica los datos y presiona el botón **Modificar** para actualizar la fila.

4. **Guardar en Archivo:**
 - Presiona el botón **Guardar Archivo** para exportar los datos a un archivo de texto.

## Requisitos del Sistema
- **Lenguaje:** C#  
- **Framework:** .NET Framework 4.7.2 o superior  
- **IDE:** Visual Studio 2019 o superior  
- **Sistema Operativo:** Windows  

## Autor
Desarrollado por Jose Genuel Mercedes Abreu, **A.K.A: MrRobotCode**