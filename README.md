# 🎮 Undertale Fan game



---

## Índice

1. [🏠 Menu Inicial](#menuinicial)
2. [🛡️ Checkpoint](#checkpoint)
3. [⚔️ Fight](#fight)
4. [🎛️ Master](#master)
5. [🏃‍♂️ Movement](#movement)
6. [👤 Player](#player)
7. [📝 PlayerName](#playername)
8. [⏩ Skip](#skip)

---

## 🏠 Menu Inicial

### Descripción

Este script gestiona el menú inicial del juego, permitiendo al usuario iniciar el juego o salir de la aplicación.

### Métodos Clave

- **`Jugar()`**: Carga la siguiente escena según el índice en **Build Settings**.
- **`Salir()`**: Cierra la aplicación.

### 🛠️ Configuración

1. Añade este script a un GameObject en la escena inicial.
2. Configura las escenas en **File > Build Settings** para que estén en el orden correcto.

---

## 🛡️ Checkpoint

### Descripción

Permite al jugador guardar su posición y escena actual al interactuar con un checkpoint.

### Funcionalidades

- Guarda la posición y escena actual del jugador.
- Muestra animaciones relacionadas al checkpoint.
- Permite la interacción con la tecla `Z`.

### 🛠️ Configuración

1. Asigna el objeto del jugador y los checkpoints en el Inspector.
2. Incluye las animaciones necesarias y configúralas en los menús.

---

## ⚔️ Fight

### Descripción

Este script inicia una secuencia de pelea cuando el jugador entra en una zona específica, mostrando un video introductorio y cargando la escena de pelea.

### Métodos Clave

- **`OnTriggerEnter2D(Collider2D)`**: Detecta al jugador y activa el video.
- **`EndReached(VideoPlayer)`**: Carga la escena de pelea una vez que termina el video.

### 🛠️ Configuración

1. Asigna un **VideoPlayer** y un **AudioSource** en el Inspector.
2. Configura la escena de pelea en **Build Settings**.

---

## 🎛️ Master

### Descripción

Este script actúa como un controlador global que persiste entre escenas, guardando información como la posición del checkpoint y la escena actual.

### Funcionalidades

- Persistencia de datos a través de `DontDestroyOnLoad`.
- Almacena la posición inicial y de checkpoint.

### 🛠️ Configuración

1. Añade este script a un GameObject en la escena inicial.
2. Configura las posiciones predeterminadas según sea necesario.

---

## 🏃‍♂️ Movement

### Descripción

Gestiona el movimiento entre escenas basado en la posición del jugador. Permite cargar diferentes escenas dependiendo de la dirección del movimiento.

### Métodos Clave

- **`OnTriggerEnter2D(Collider2D)`**: Detecta la entrada del jugador y cambia de escena, ajustando su posición inicial según corresponda.

### 🛠️ Configuración

1. Configura las posiciones de destino (`targetposition`) en el Inspector.
2. Asigna el objeto del jugador en la escena.

---

## 👤 Player

### Descripción

Gestiona el movimiento y animaciones del jugador, ajustando su posición según los datos guardados en el script **Master**.

### Funcionalidades

- Movimiento en 2D con físicas.
- Animaciones basadas en la dirección y velocidad.
- Ajuste de posición al cargar una escena nueva o morir.

### Métodos Clave

- **`Flip()`**: Invierte la dirección del jugador al cambiar de lado.
- **`FixedUpdate()`**: Maneja las físicas del movimiento.

### 🛠️ Configuración

1. Asigna los componentes necesarios, como `Rigidbody2D` y `Animator`, al objeto del jugador.
2. Ajusta la velocidad de movimiento (`MovSpeed`) en el Inspector.

---

## 📝 PlayerName

### Descripción

Este script guarda el nombre del jugador y reproduce un video introductorio antes de cargar la siguiente escena.

### Funcionalidades

- Almacena el nombre del jugador en `PlayerPrefs`.
- Reproduce un video con música de fondo.
- Carga la escena principal tras el video.

### Métodos Clave

- **`SaveData()`**: Guarda el nombre y activa el video.
- **`EndReached(VideoPlayer)`**: Carga la escena de entrada.

### 🛠️ Configuración

1. Asigna un campo de entrada de texto (**TMP_InputField**) en el Inspector.
2. Configura los videos y audios correspondientes.

---

## ⏩ Skip

### Descripción

Permite al jugador saltar secuencias y volver al menú principal presionando `Z`.

### Métodos Clave

- **`Skip()`**: Detecta la tecla `Z` y carga el menú principal.

### 🛠️ Configuración

1. Añade este script a un GameObject en escenas donde sea posible saltar secuencias.
2. Configura el menú principal en **Build Settings**.

---

## 📌 Notas Generales

- **Persistencia de datos**: El script **Master** es esencial para mantener la continuidad del juego. Asegúrate de no duplicarlo.
- **Configuración de escenas**: Todas las escenas mencionadas deben estar correctamente añadidas en **File > Build Settings**.
- **Inputs**: Los controles predeterminados usan teclas como `Z` para interactuar y navegar. Puedes cambiarlos según tus necesidades.

---




