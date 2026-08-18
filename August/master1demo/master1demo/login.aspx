<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login - CamStore</title>
    
    <!-- Bootstrap 5 CSS CDN -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
    
    <!-- Custom CSS File -->
    <link rel="stylesheet" href="style.css">
</head>
<body>

    <!-- ================= NAVBAR SECTION ================= -->
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <div class="container">
            <!-- Brand Logo / Website Name -->
            <a class="navbar-brand fw-bold" href="index.html">📷 CamStore</a>
            
            <!-- Mobile Toggle Button -->
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            
            <!-- Navbar Links -->
            <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav ms-auto">
                    <li class="nav-item">
                        <a class="nav-link" href="index.html">Home</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="index.html#categories">Categories</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="cart.html">Cart</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link active" href="login.html">Login</a>
                    </li>
                    <!-- Dropdown for Register -->
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" href="#" id="registerDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                            Register
                        </a>
                        <ul class="dropdown-menu" aria-labelledby="registerDropdown">
                            <li><a class="dropdown-item" href="user-register.html">User</a></li>
                            <li><a class="dropdown-item" href="admin-register.html">Admin</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <!-- ================= LOGIN FORM SECTION ================= -->
    <main class="container my-5">
        <div class="row justify-content-center">
            <div class="col-12 col-md-6 col-lg-4">
                <!-- Simple Login Card -->
                <div class="card shadow-sm">
                    <div class="card-body p-4">
                        <h3 class="card-title text-center fw-bold mb-4">Login</h3>
                        
                        <form id="loginForm" runat="server">
                            <!-- Username Input -->
                            <div class="mb-3">
                                <label for="loginUsername" class="form-label">Username</label>
                                <br />
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
&nbsp;</div>
                            
                            <!-- Password Input -->
                            <div class="mb-3">
                                <label for="loginPassword" class="form-label">Password</label>
                                <br />
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
&nbsp;</div>
                            
                            <!-- Submit Button -->
                            <button type="submit" class="btn btn-primary w-100 fw-bold">Login</button>
                        </form>

                        <!-- Link to Register Page -->
                        <div class="text-center mt-3">
                            <p class="small text-muted mb-1">Don't have an account? <a href="user-register.html" class="text-decoration-none fw-bold">Register as User</a></p>
                            <p class="small text-muted mb-0">Or register as <a href="admin-register.html" class="text-decoration-none fw-bold">Admin</a></p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </main>

    <!-- ================= FOOTER SECTION ================= -->
    <footer class="bg-dark text-white text-center py-3 mt-auto">
        <div class="container">
            <p class="mb-1 fw-bold">📷 CamStore</p>
            <p class="mb-0 text-secondary small">&copy; 2026 CamStore. All rights reserved.</p>
        </div>
    </footer>

    <!-- Bootstrap 5 JS Bundle CDN -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
    
    <!-- Custom JavaScript File -->
    <script src="script.js"></script>
</body>
</html>
