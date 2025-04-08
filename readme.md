# PocSII - Prototipo de API de Facturación Electrónica para Chile

## 📌 Objetivo Principal

Desarrollar un prototipo funcional (Proof of Concept, POC) de una API moderna para la emisión de Documentos Tributarios Electrónicos (DTE) en Chile, específicamente una factura tipo 33 básica.

---

## 🎯 Objetivos Clave

- Crear endpoints REST para:
  - Emitir un DTE
  - Consultar el estado de envío por folio
- Manejar firma digital y folios (CAF)
- Simular el envío de documentos al Servicio de Impuestos Internos (SII)
- Separar lógica de negocio de la infraestructura
- Contenerización con Docker
- Proveer autenticación mínima mediante JWT

---

## 🏗️ Arquitectura de la Solución

### C4 Nivel 1 - Visión General del Sistema

![C4 Nivel 1](./Diagrama_PocSII-C4%20L1.png)

- **Facturador**: Empresa que emite el DTE
- **PocSII**: API central desarrollada en .NET Core 8, actúa como orquestador
- **SII**: API REST del Servicio de Impuestos Internos de Chile (simulada)
- **SMTP Server**: Simulación de notificaciones por correo (ej. Mailtrap)

---

### C4 Nivel 2 - Componentes Internos de PocSII

![C4 Nivel 2](./Diagrama_PocSII-C4%20L2.png)

- **API REST**: Expone endpoints HTTP para interactuar con el sistema.
- **DTE Business Rules**: Define validaciones, interfaces y lógica de negocio para los DTE.
- **DTE Processor**: Se encarga de armar el XML del DTE, validarlo contra su XSD, y simular su envío al SII.
- **DTE Communications**: Módulo de notificaciones y mensajería.
- **Base de datos**: SQL Server, se usa para almacenar información estructurada de facturas.

---

### 🔧 Entorno de Despliegue Local

![Despliegue Local](./Diagrama_PocSII-Despliegue.png)

El entorno local se basa en `Docker Compose` con los siguientes servicios:

- `PocSII`: API REST en .NET Core 8
- `SQL Server`: Base de datos en contenedor
- `SII Web Services`: Mock del SII creado con Imposter (puerto 8080)

---

## 🚀 Cómo Desplegar Localmente

### Requisitos

- Docker
- Docker Compose

### Pasos

1. Clonar el repositorio:

   ```bash
   git clone https://github.com/tuusuario/PocSII.git
   cd PocSII

2. Ejecutar los contenedores:

   ```bash
   docker compose up -d

