# Google Sign-In Integration - Setup Guide

## Pasos para configurar Google Authentication

### 1. Obtener Client ID de Google
- Ve a [Google Cloud Console](https://console.cloud.google.com/)
- Crea un nuevo proyecto o selecciona uno existente
- Ve a "APIs & Services" → "Credentials"
- Crea una "OAuth 2.0 Client ID" de tipo "Web application"
- En "Authorized JavaScript origins" agrega:
  - `http://localhost:8000` (para desarrollo local)
  - `http://localhost:5000` (si usas este puerto)
  - Tu dominio en producción (ej: `https://tudominio.com`)
- En "Authorized redirect URIs" agrega:
  - `http://localhost:8000/`
  - Tu URL base en producción

### 2. Copiar el Client ID

Una vez creada la credencial, obtendrás un Client ID que se verá así:
```
xxxxxxxxxx-xxxxxxxxxx.apps.googleusercontent.com
```

### 3. Actualizar el código

En el archivo `scripts/scriptLogin.js`, reemplaza:

```javascript
const GOOGLE_CLIENT_ID = 'YOUR_GOOGLE_CLIENT_ID_HERE';
```

Con tu Client ID real:

```javascript
const GOOGLE_CLIENT_ID = 'xxxxxxxxxx-xxxxxxxxxx.apps.googleusercontent.com';
```

### 4. Probar la integración

1. Abre `login.html` en tu navegador
2. Deberías ver:
   - El formulario de login tradicional (usuario/contraseña)
   - Un divisor "or"
   - El botón "Sign in with Google"
3. Haz clic en el botón de Google y completa el flujo de autenticación

## Cómo funciona

1. **Google Sign-In Button**: Se renderiza automáticamente en el elemento con id `google-signin-button`
2. **Token Decodificación**: El JWT token de Google se decodifica sin necesidad de backend
3. **Session Storage**: Los datos del usuario se guardan en `sessionStorage` para la sesión actual
4. **Redirect**: Tras login exitoso, redirige a `index.html`

## Datos del usuario capturados

Cuando el usuario se autentica con Google, se capturan:
- `email`: Email del usuario de Google
- `name`: Nombre completo
- `picture`: URL del avatar
- `role`: Se asigna "client" por defecto para usuarios de Google
- `permissions`: `['quoterequest', 'history']` por defecto
- `provider`: Marcado como "google"

## Notas de seguridad

⚠️ **Importante**:
- El Client ID se comparte públicamente (es normal)
- El token JWT se decodifica en el navegador (no en el servidor)
- Los datos sensibles no deben almacenarse en `sessionStorage`
- Para un sistema de producción, implementa validación del token en el backend

## Mantener acceso tradicional

El formulario de login tradicional (usuario/contraseña) sigue funcionando con los usuarios locales:
- Chef: `chef` / `chef123`
- Cliente: `cliente` / `cliente123`

## Problemas comunes

### "Google is not defined"
- Asegúrate de que el script de Google está cargado: `<script src="https://accounts.google.com/gsi/client" async defer></script>`

### El botón no aparece
- Verifica que el elemento `<div id="google-signin-button"></div>` exista en el HTML
- Comprueba la consola del navegador (F12) para errores

### Error de CORS
- Asegúrate de que tu dominio está en "Authorized JavaScript origins" en Google Cloud Console

### Token expirado
- Los tokens de Google expiran después de 1 hora
- Para renovación, implementa refresh tokens en el backend
