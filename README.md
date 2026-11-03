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
* 
  <img width="648" height="201" alt="Screenshot from 2026-11-03 15-48-41" src="https://github.com/user-attachments/assets/a4578fd7-9d0c-474a-a995-45e4c1346639" />
  <img width="655" height="216" alt="Screenshot from 2026-11-03 15-48-02" src="https://github.com/user-attachments/assets/605e293a-f58b-4bee-9632-a9536e10ebae" />
   <img width="648" height="201" alt="Screenshot from 2026-11-03 15-49-23" src="https://github.com/user-attachments/assets/530751dd-1d46-47c2-8886-f3a5ae00ca6c" />
   <img width="648" height="201" alt="Screenshot from 2026-11-03 15-49-10" src="https://github.com/user-attachments/assets/02b9462e-49ef-4277-a50a-ad75716928f0" />
    <img width="648" height="201" alt="Screenshot from 2026-11-03 15-49-23" src="https://github.com/user-attachments/assets/d409987f-f2d9-4497-bf6b-5dbbf410e615" />
    
* **Caso de error o validación (PIN incorrecto o retiro inválido):**
  <img width="655" height="216" alt="Screenshot from 2026-11-03 15-47-35" src="https://github.com/user-attachments/assets/d7b3b36e-e081-40fe-b977-f1acb5c5782f" />
  <img width="655" height="216" alt="Screenshot from 2026-11-03 15-47-15" src="https://github.com/user-attachments/assets/cda6e8c0-2bad-4fcf-a333-21fd12818aa1" />


### Ejercicio 2: Simulador de Préstamo
* **Caso exitoso (Cálculo de préstamo y tabla de amortización):**
<img width="661" height="398" alt="Screenshot from 2026-11-03 15-53-56" src="https://github.com/user-attachments/assets/68843df8-45bd-4ccc-b2bc-916a34b4312a" />
<img width="661" height="398" alt="Screenshot from 2026-11-03 15-53-19" src="https://github.com/user-attachments/assets/be0e8780-196e-44aa-a0d7-a49afe330403" />
<img width="648" height="201" alt="Screenshot from 2026-11-03 15-51-50" src="https://github.com/user-attachments/assets/76ca2040-4fd1-4d6e-adfd-f0306ba1db5b" />


<img width="661" height="398" alt="Screenshot from 2026-11-03 15-54-27 (Copy)" src="https://github.com/user-attachments/assets/de6c22ae-9ba0-44d7-a527-edffbc08a31a" />
<img width="661" height="398" alt="Screenshot from 2026-11-03 15-54-27" src="https://github.com/user-attachments/assets/7b10f3a1-a206-4320-91fb-830c4df494d9" />





  *(Inserta aquí tu captura de pantalla)*<
  *(Inserta aquí tu captura de pantalla)*
