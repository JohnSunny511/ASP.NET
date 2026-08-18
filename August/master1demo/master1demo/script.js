// =========================================================
// SCRIPT.JS - Basic JavaScript for CamStore
// Simple, beginner-friendly interaction handlers.
// =========================================================

// Wait for the HTML document to finish loading
document.addEventListener("DOMContentLoaded", function () {
    console.log("CamStore Page Loaded Successfully!");

    // 1. Select all category "View Products" buttons (Homepage)
    const viewButtons = document.querySelectorAll(".view-btn");
    viewButtons.forEach(function (button) {
        button.addEventListener("click", function () {
            alert("Viewing products... (This is a visual placeholder)");
        });
    });

    // 2. Handle Login Form Submission (login.html)
    const loginForm = document.getElementById("loginForm");
    if (loginForm) {
        loginForm.addEventListener("submit", function (event) {
            event.preventDefault(); // Prevents browser page reload
            const usernameInput = document.getElementById("loginUsername") || document.getElementById("loginEmail");
            const username = usernameInput ? usernameInput.value : "User";
            alert("Logged in successfully as " + username + "! (Visual placeholder)");
        });
    }

    // 3. Handle User Register Form Submission (user-register.html)
    const userRegisterForm = document.getElementById("userRegisterForm") || document.getElementById("registerForm");
    if (userRegisterForm) {
        userRegisterForm.addEventListener("submit", function (event) {
            event.preventDefault(); // Prevents browser page reload
            const nameInput = document.getElementById("userFullName") || document.getElementById("registerName");
            const name = nameInput ? nameInput.value : "User";
            alert("User account created successfully for " + name + "! (Visual placeholder)");
        });
    }

    // 4. Handle Admin Register Form Submission (admin-register.html)
    const adminRegisterForm = document.getElementById("adminRegisterForm");
    if (adminRegisterForm) {
        adminRegisterForm.addEventListener("submit", function (event) {
            event.preventDefault(); // Prevents browser page reload
            const nameInput = document.getElementById("adminFullName");
            const name = nameInput ? nameInput.value : "Admin";
            alert("Admin account created successfully for " + name + "! (Visual placeholder)");
        });
    }
});
