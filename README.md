El Reto: El "SettingsManager" ⚙️
Imagina que estás desarrollando un videojuego. Tienes muchas partes del código (el menú, el motor de sonido, el motor gráfico) que necesitan saber cuál es el Volumen y la Resolución. No quieres que cada parte tenga su propia configuración; todos deben leer la misma.

Tu tarea:
Crea una clase llamada SettingsManager.

Aplica el patrón Singleton.

Agrega dos propiedades:

int Volumen (predeterminado en 50).

string Resolucion (predeterminada en "1080p").

En el Main:

Obtén la instancia a través de una variable llamada accesoMenu.

Cambia el volumen a 100.

Luego, obtén la instancia en otra variable llamada accesoSonido.

Imprime el volumen usando accesoSonido.
