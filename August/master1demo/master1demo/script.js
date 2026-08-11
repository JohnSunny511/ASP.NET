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
            const email = document.getElementById("loginEmail").value;
            alert("Logged in successfully as " + email + "! (Visual placeholder)");
        });
    }

    // 3. Handle Register Form Submission (register.html)
    const registerForm = document.getElementById("registerForm");
    if (registerForm) {
        registerForm.addEventListener("submit", function (event) {
            event.preventDefault(); // Prevents browser page reload
            const name = document.getElementById("registerName").value;
            alert("Account registered successfully for " + name + "! (Visual placeholder)");
        });
    }
});
