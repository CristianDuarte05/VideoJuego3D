# 🎮 Videojuego 3D en Unity – Proyecto Académico

Este proyecto corresponde a un **videojuego 3D desarrollado en Unity**, creado como parte de una **evaluación sumativa** de la asignatura *Desarrollo de Videojuegos*.

El juego está basado en la recolección de monedas, progresión por niveles, uso de interfaz gráfica (UI), temporizador, sonido y mecánicas básicas de movimiento.

---

## 🧩 Descripción del Juego

El jugador controla un personaje que debe **moverse por distintos escenarios**, recolectando monedas para avanzar de nivel.

### 🎯 Objetivo
- Recolectar monedas
- Superar obstáculos
- Avanzar por 3 niveles
- Finalizar el juego con un mensaje de victoria

---

## 🕹️ Controles

| Acción | Tecla |
|------|------|
| Moverse | W, A, S, D o Flechas |
| Saltar | Barra espaciadora |
| Cámara | Automática (sigue al jugador) |

---

## 🧱 Niveles del Juego

- **Nivel 1**  
  - Recolectar 5 monedas

- **Nivel 2**  
  - Recolectar 10 monedas

- **Nivel 3**  
  - Recolectar 15 monedas  
  - Finaliza el juego

Cada nivel contiene:
- Obstáculos
- Monedas coleccionables
- Punto de aparición (spawn) del jugador

---

## 🖥️ Interfaz de Usuario (UI)

La interfaz muestra en tiempo real:
- Cantidad de monedas recolectadas
- Nivel actual
- Tiempo de juego
- Mensaje final de *Juego Finalizado*

---

## 🔊 Sonido y Música

- Música de fondo durante el juego
- Sonido al recolectar monedas
- Música diferente al finalizar el juego

> El proyecto admite archivos de audio en formato **MP3 o WAV**.

---

## 🛠️ Tecnologías Utilizadas

- **Unity 3D**
- **C#**
- **TextMeshPro**
- **AudioSource**
- **Rigidbody & Colliders**

---

## 📁 Estructura del Proyecto

```plaintext
Assets/
│── Audio/
│── Materials/
│── Prefabs/
│── Scenes/
│── Scripts/
│── UI/
```

---

## 📜 Scripts Principales

- `PlayerController.cs` → Movimiento y salto del jugador
- `CamaraController.cs` → Cámara que sigue al jugador
- `RotarMoneda.cs` → Rotación de monedas
- `MonedaPickup.cs` → Recolección de monedas
- `GameManager.cs` → Gestión de niveles, monedas y estado del juego
- `Temporizador.cs` → Control del tiempo de juego
- `AudioManager.cs` → Gestión de música y efectos

---

## ▶️ Cómo ejecutar el proyecto

1. Abrir **Unity Hub**
2. Seleccionar **Open Project**
3. Abrir la carpeta del proyecto
4. Cargar la escena principal
5. Presionar **Play**

---

## 👨‍🎓 Contexto Académico

Proyecto desarrollado con fines **educativos**, cumpliendo los criterios de:
- Programación en motor de videojuegos
- Creación de escenarios 3D
- Interacción y mecánicas de juego
- Interfaces gráficas
- Gestión de niveles

---

## 📌 Autor

- **Estudiante:** Cristian Duarte Santos
- **Asignatura:** Desarrollo de Videojuegos
---

¡Gracias por revisar este proyecto! 🚀
