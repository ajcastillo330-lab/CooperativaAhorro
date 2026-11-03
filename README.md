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
  *(Inserta aquí tu captura de pantalla)*<img width="655" height="216" alt="Screenshot from 2026-11-03 15-46-31" src="https://github.com/user-attachments/assets/f3144e79-a864-4c1f-a21d-baf5994a2f01" />  <img width="651" height="488" alt="Screenshot from 2026-11-03 15-54-53" src="https://github.com/user-attachments/assets/a2f6e862-4f8d-4ee6-93e3-07d2f13d6194" />
<img width="661" height="398" alt="Screenshot from 2026-11-03 15-54-27" src="https://github.com/user-attachments/assets/f8420b6a-3aa2-4591-8868-7123e876d0c9" />
<img width="661" height="398" alt="Screenshot from 2026-11-03 15-53-56" src="https://github.com/user-attachments/assets/19e975f3-3d9b-4ab1-9510-a5ff2b34f681" />
<img width="661" height="398" alt="Screenshot from 2026-11-03 15-53-19" src="https://github.com/user-attachments/assets/2c2c43d1-fc4b-47b5-9170-c2e4f575c8cf" />
<img width="648" height="201" alt="Screenshot from 2026-11-03 15-52-58" src="https://github.com/user-attachments/assets/c86e59f0-e4b4-4137-b2a5-2209a094bbfc" />
<img width="648" height="201" alt="Screenshot from 2026-11-03 15-51-50" src="https://github.com/user-attachments/assets/552c9b34-0aa6-489c-be2a-3aef84ab73ae" />
<img width="648" height="201" alt="Screenshot from 2026-11-03 15-51-04" src="https://github.com/user-attachments/assets/976d17cb-6b0a-4a9b-a533-5d0f137982ce" />
<img width="648" height="201" alt="Screenshot from 2026-11-03 15-50-41" src="https://github.com/user-attachments/assets/889aa370-03ea-49de-a541-55d096a04882" />
<img width="648" height="201" alt="Screenshot from 2026-11-03 15-49-57" src="https://github.com/user-attachments/assets/296b8c28-6265-414e-9812-525f1d29c366" />
<img width="648" height="201" alt="Screenshot from 2026-11-03 15-49-23" src="https://github.com/user-attachments/assets/5ffbca6a-6ee5-49c9-b29c-4493700d89d8" />
<img width="648" height="201" alt="Screenshot from 2026-11-03 15-49-10" src="https://github.com/user-attachments/assets/b94c3edb-0834-4b83-af85-e06a043b6a88" />
<img width="648" height="201" alt="Screenshot from 2026-11-03 15-48-41" src="https://github.com/user-attachments/assets/8923c196-0cc0-4e9c-a95d-328312f3c265" />
<img width="655" height="216" alt="Screenshot from 2026-11-03 15-48-02" src="https://github.com/user-attachments/assets/a73b98fc-7d95-4cd3-871f-3e665cd7d132" />
<img width="655" height="216" alt="Screenshot from 2026-11-03 15-47-35" src="https://github.com/user-attachments/assets/2b1bc1c5-67e1-49a1-a871-af4990e054d8" />
<img width="655" height="216" alt="Screenshot from 2026-11-03 15-47-15" src="https://github.com/user-attachments/assets/d3b04329-bf03-4f52-914c-a98fad3ab7fa" />


* **Caso de error o validación (Monto/plazo fuera de rango o categoría inválida):**
  *(Inserta aquí tu captura de pantalla)*
