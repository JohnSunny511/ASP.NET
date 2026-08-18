<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>User Registration - CamStore</title>
    
    <!-- Bootstrap 5 CSS CDN -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
    
    <!-- Custom CSS File -->
    <link rel="stylesheet" href="style.css">
    <style type="text/css">
        .auto-style4 {
            height: 30px;
        }
        .auto-style5 {
            margin-left: 169px;
        }
    </style>
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
                        <a class="nav-link" href="login.html">Login</a>
                    </li>
                    <!-- Dropdown for Register -->
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle active" href="#" id="registerDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                            Register
                        </a>
                        <ul class="dropdown-menu" aria-labelledby="registerDropdown">
                            <li><a class="dropdown-item active" href="user-register.aspx">User</a></li>
                            <li><a class="dropdown-item" href="admin-register.aspx">Admin</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <!-- ================= USER REGISTER FORM SECTION ================= -->
    <main class="container my-5">
        <div class="row justify-content-center">
            <div class="col-12 col-md-8 col-lg-6">
                <!-- Registration Card -->
                <div class="card shadow-sm">
                    <div class="card-body p-4">
                        <h3 class="card-title text-center fw-bold mb-4">User Registration</h3>
                        
                        <form id="userRegisterForm" runat="server">
                            <!-- 1. Full Name -->
                            <div class="mb-3">
                                <label for="userFullName" class="form-label">Full Name</label>
                                <br />
                                <table class="w-100">
                                    <tr>
                                        <td>
                                            <table class="w-100">
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
&nbsp;</div>

                            <!-- 2. Email Address -->
                            <div class="mb-3">
                                <label for="userEmail" class="form-label">Email Address</label>
                                <br />
&nbsp;<table class="w-100">
                                    <tr>
                                        <td >
                                            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </div>

                            <!-- 3. Phone Number -->
                            <div class="mb-3">
                                <label for="userPhone" class="form-label">Phone Number</label>
                                <br />
                                <table class="w-100">
                                    <tr>
                                        <td >
                                            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
&nbsp;</div>

                            <!-- 4. Age -->
                            <div class="mb-3">
                                <label for="userAge" class="form-label">Age</label>
                                <br />
                                <table class="w-100">
                                    <tr>
                                        <td >
                                            <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
&nbsp;</div>

                            <!-- 5. Address -->
                            <div class="mb-3">
                                <label for="userAddress" class="form-label">Address</label>
                                <br />
&nbsp;<table class="w-100">
                                    <tr>
                                        <td >
                                            <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </div>

                            <!-- 6. Username -->
                            <div class="mb-3">
                                <label for="userUsername" class="form-label">Username</label>
                                <br />
                                <table class="w-100">
                                    <tr>
                                        <td>
                                            <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control"></asp:TextBox>
                                        </td>
                                        <td class="auto-style4"></td>
                                    </tr>
                                </table>
&nbsp;</div>
                            
                            <!-- 7. Password -->
                            <div class="mb-3">
                                <label for="userPassword" class="form-label">Password</label>
                                <br />
                                <table class="w-100">
                                    <tr>
                                        <td>
                                            <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control"></asp:TextBox>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
&nbsp;</div>

                            <!-- 8. Confirm Password -->
                            <div class="mb-3">
                                <label for="userConfirmPassword" class="form-label">Confirm Password</label>
                                <table class="w-100">
                                    <tr>
                                        <td >
                                            <asp:TextBox ID="TextBox8" runat="server" CssClass="form-control"></asp:TextBox>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
&nbsp;</div>

                            <!-- 9. Pincode -->
                            <div class="mb-3">
                                <label for="userPincode" class="form-label">Pincode</label>
                                <table class="w-100">
                                    <tr>
                                        <td >
                                            <asp:TextBox ID="TextBox9" runat="server" CssClass="form-control"></asp:TextBox>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
&nbsp;<table class="w-100">
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:Button ID="Button1" runat="server" CssClass="auto-style5" Text="Button" Width="222px" />
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </div>
                            
                            <!-- 10. Submit Button -->
                            </form>

                        <!-- Extra Navigation Links -->
                        <div class="text-center mt-3">
                            <p class="small text-muted mb-1">Already have an account? <a href="login.aspx" class="text-decoration-none fw-bold">Login here</a></p>
                            <p class="small text-muted mb-0">Registering as an Admin? <a href="admin-register.aspx" class="text-decoration-none fw-bold">Admin Registration</a></p>
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
