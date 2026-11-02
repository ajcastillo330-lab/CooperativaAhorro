# Proyecto: Cooperativa "Ahorro Seguro"

## 1. Datos de los Autores
* **Nombre completo:** 
* **Matrícula:** 
* **Asignatura:** Algoritmos Computacionales
* **Profesor:** Gamalier Reyes del Carmen
* **Institución:** Universidad Dominicana O&M

---

## 2. Descripción del Proyecto
Aplicación de consola desarrollada en C# diseñada para modernizar dos procesos manuales de la Cooperativa "Ahorro Seguro":
1. **Cajero Automático (Ejercicio 1):** Simula operaciones bancarias con validación de PIN (hasta 3 intentos de bloqueo), consulta de saldo inicial de RD$ 10,000.00, depósitos, retiros condicionados (múltiplos de 100) y reporte de estadísticas al salir.
2. **Simulador de Préstamo (Ejercicio 2):** Calcula cuotas fijas mensuales basadas en el monto (RD$ 5,000 a 500,000), plazo (6 a 60 meses) y categoría del socio (A, B, C), generando una tabla completa de amortización y permitiendo repetir la simulación de manera interactiva.

---

## 3. Datos de Entrada
* **Ejercicio 1:**
  * PIN de acceso (4 dígitos).
  * Opción del menú principal y del submenú del cajero.
  * Montos numéricos para depósitos (mayores a cero).
  * Montos numéricos para retiros (mayores a cero, menores o iguales al saldo y múltiplos de 100).
* **Ejercicio 2:**
  * Monto solicitado del préstamo.
  * Plazo en meses.
  * Categoría del socio (A, B o C).
  * Respuesta de control (`S` / `N`) para realizar otra simulación.

---

## 4. Datos que Procesa
* Validación de intentos de PIN y bloqueo de cuenta.
* Cálculo matemático de saldos actualizados (suma de depósitos, resta de retiros y conteo de transacciones).
* Determinación de tasas de interés anual y mensual según la categoría del socio.
* Cálculo de la cuota fija mensual mediante la fórmula financiera de amortización:
  $$\text{Cuota} = \text{Monto} \cdot \frac{i(1+i)^n}{(1+i)^n - 1}$$
* Desglose iterativo mes a mes de los intereses, abono a capital y saldo pendiente para la tabla de amortización.

---

## 5. Datos de Salida
* Mensajes de estado, validación de errores y alertas en consola mediante `TryParse`.
* **Ejercicio 1:** Saldo actual, cantidad total de depósitos realizados, cantidad de retiros y saldo final al salir del sistema.
* **Ejercicio 2:** Tabla de amortización detallada (cuota, interés, abono a capital y saldo por cada mes) y el acumulado de totales pagados al finalizar el plazo.

---

## 6. Tecnología Utilizada
* **Lenguaje:** C# (.NET Core / Console Application)
* **Entorno de desarrollo:** Visual Studio / GitHub Codespaces
* **Control de versiones:** Git y GitHub

---

## 7. Capturas del Programa

### Ejercicio 1: Cajero Automático
* **Caso exitoso (Consulta, depósito y retiro válido):**
  *(Inserta aquí tu captura de pantalla)*
* **Caso de error o validación (PIN incorrecto o retiro inválido):**
  *(Inserta aquí tu captura de pantalla)*

### Ejercicio 2: Simulador de Préstamo
* **Caso exitoso (Cálculo de préstamo y tabla de amortización):**
  *(Inserta aquí tu captura de pantalla)*
* **Caso de error o validación (Monto/plazo fuera de rango o categoría inválida):**
  *(Inserta aquí tu captura de pantalla)*
