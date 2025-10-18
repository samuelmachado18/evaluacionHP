Readme.md
Figuras Geométricas
Descripción del proyecto
Aplicación de escritorio que permite crear, almacenar y mostrar figuras
geométricas tales como rectángulos, círculos, triángulos y líneas sobre
un lienzo con base en información proporcionada por el usuario (posición
en eje X y Y, tamaño y color). Adicionalmente permite tener un conteo de
figuras creadas y a su vez reiniciar el contador si así se desea
Tecnología
-Plataforma de desarrollo: Visual Studio - Windows Forms
-Lenguaje de programación: C#
Controles de desarrollo
-ComboBox: para seleccionar el tipo de figura (rectángulo, círculo,
triángulo y línea)
-NumericUpDown:

1. define el valor que tendrá la posición inicial de la figura en
los eje X-Y

2. en el caso del rectángulo, círculo y triángulo permite establecer el
tamaño (ancho y largo)

4. en el caso de la línea permite asignar el valor a los puntos X2 y Y2,
donde se definirá la longitud de la misma
-PictureBox:
1. servirá como el lienzo del dibujo
2. mostrará una vista previa del color que se desea para la figura
a crear
-ColorDialog:
-cuando se conjuga esta herramienta con el PictureBox, permite mostrar al
usuario una interfaz donde seleccionará entre una gran cantidad de
opciones el color que desea para su figura
-Button:

1. se usa para crear un botón de crear que al hacer click sobre él
dibujará automáticamente la figura con los datos previamente
digitados
2. se usa para crear un botón de limpiar que limpiará el lienzo y
reiniciará el contador de figuras creadas hasta el momento

-TextBox:
-mostrará en el cuadro de texto la cantidad de figuras que han sido
creadas (contador)
Ejecución
1. Ejecutar el programa
2. Seleccionar tipo de figura, color y tamaño
3. Presionar el botón &quot;Crear&quot; para dibujar la figura
4. Presionar el botón &quot;Limpiar&quot; para limpiar el lienzo
Autores
Samuel Machado Espitia - Herramientas de programación 2 - 2025-2
Nicolle Carvajal Gómez - Herramientas de programación 2 - 2025-2
