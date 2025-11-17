const USERS = {
    chef: {
        username: 'chef',
        password: 'chef123',
        role: 'chef',
        name: 'Chef Principal',
        permissions: ['calendar', 'clients','recipes', 'ingredients', 'conversion', 'scaling', 'costs', 'quotes']
    },
    cliente: {
        username: 'cliente',
        password: 'cliente123',
        role: 'client',
        name: 'Cliente',
        permissions: ['quoterequest', 'history']  // Solo estas dos secciones
    }
};

const loginForm = document.getElementById('loginForm');
const errorMessage = document.getElementById('errorMessage');

loginForm.addEventListener('submit', handleLogin);

function handleLogin(event) {
    event.preventDefault();
    
    const username = document.getElementById('username').value.trim();
    const password = document.getElementById('password').value;
    
    const user = USERS[username];
    
    if (!user || user.password !== password) {
        showError('Invalid username or password');
        return;
    }
    
    // Guardar sesión
    const sessionData = {
        username: user.username,
        role: user.role,
        name: user.name,
        permissions: user.permissions,
        loginTime: new Date().toISOString()
    };
    
    sessionStorage.setItem('userSession', JSON.stringify(sessionData));
    
    // Redireccionar al dashboard
    window.location.href = 'index.html';
}

function showError(message) {
    errorMessage.textContent = message;
    errorMessage.classList.add('show');
    
    setTimeout(() => {
        errorMessage.classList.remove('show');
    }, 5000);
}

// Verificar si ya hay sesión activa
function checkExistingSession() {
    const session = sessionStorage.getItem('userSession');
    if (session) {
        window.location.href = 'index.html';
    }
}

checkExistingSession();

// ============ Google Sign-In Integration ============
function initializeGoogleSignIn() {
    // Reemplaza con tu Client ID de Google
    const GOOGLE_CLIENT_ID = '643509229684-5p5ss9hct2bjtnf7gaa2av7q4fkse9dr.apps.googleusercontent.com';
    
    google.accounts.id.initialize({
        client_id: GOOGLE_CLIENT_ID,
        callback: handleGoogleSignIn
    });

    google.accounts.id.renderButton(
        document.getElementById('google-signin-button'),
        {
            theme: 'outline',
            size: 'large',
            width: '100%',
            text: 'signin_with'
        }
    );
}

function handleGoogleSignIn(response) {
    if (!response.credential) {
        showError('Error de autenticación con Google');
        return;
    }

    // Decodificar el JWT token
    const googleUser = parseJwt(response.credential);
    
    console.log('Usuario de Google:', googleUser);

    // Crear sesión basada en el email de Google
    const sessionData = {
        username: googleUser.email,
        email: googleUser.email,
        name: googleUser.name,
        picture: googleUser.picture,
        role: 'client', // Por defecto, usuarios de Google son clientes
        permissions: ['quoterequest', 'history'],
        loginTime: new Date().toISOString(),
        provider: 'google'
    };

    sessionStorage.setItem('userSession', JSON.stringify(sessionData));
    window.location.href = 'index.html';
}

// Decodificar JWT token de Google
function parseJwt(token) {
    const base64Url = token.split('.')[1];
    const base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
    const jsonPayload = decodeURIComponent(
        atob(base64)
            .split('')
            .map((c) => '%' + ('00' + c.charCodeAt(0).toString(16)).slice(-2))
            .join('')
    );
    return JSON.parse(jsonPayload);
}

// Inicializar Google Sign-In cuando el DOM esté listo
document.addEventListener('DOMContentLoaded', () => {
    if (window.google) {
        initializeGoogleSignIn();
    } else {
        console.error('Google Identity Services no se cargó correctamente');
    }
});
