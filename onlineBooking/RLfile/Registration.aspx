<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="RLfile_Registration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kayıt Ol </title>
    
     <!-- meta tags -->
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="keywords" content="Art Sign Up Form Responsive Widget, Audio and Video players, Login Form Web Template, Flat Pricing Tables, Flat Drop-Downs, Sign-Up Web Templates, 
		Flat Web Templates, Login Sign-up Responsive Web Template, Smartphone Compatible Web Template, Free Web Designs for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design"
    />
    <!-- /meta tags -->
    <!-- custom style sheet -->
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <!-- /custom style sheet -->
    <!-- fontawesome css -->
    <link href="css/fontawesome-all.css" rel="stylesheet" />
    <!-- /fontawesome css -->
    <!-- google fonts-->
    <link href="//fonts.googleapis.com/css?family=Raleway:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i"
        rel="stylesheet"/>
    <!-- /google fonts-->



      <!-- Kayıt Olmaaa-->
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
     
       <h1>Online Otel Rezervasyon Kaydı</h1>
    <div class=" w3l-login-form">
        <h2>Buradan Kaydolun</h2>
        <form action="#" method="POST">
        
            
            <div class=" w3l-form-group">
                <label>Kullanıcı Adı :</label>
                <div class="group">
                    <i class="fas fa-user"></i>
                    <asp:TextBox ID="txt_username" class="form-control" placeholder="Username" runat="server"></asp:TextBox>
                    <%--<input type="text" class="form-control" placeholder="Username" required="required" />--%>
                </div>
            </div>
            
            <div class=" w3l-form-group">
                <label>Telefo No:</label>
                <div class="group">
                    <i class="fas fa-user"></i>
                    <asp:TextBox ID="txt_mobile" class="form-control" placeholder="Mobile Number" runat="server"></asp:TextBox>
     
                </div>
            </div>
            
            
            <div class=" w3l-form-group">
                <label>Email :</label>
                <div class="group">
                    <i class="fas fa-user"></i>
                    <asp:TextBox ID="txt_email" class="form-control" placeholder="Email ID" runat="server"></asp:TextBox>
                    
                </div>
            </div>
            
            
            <div class=" w3l-form-group">
                <label>Şifre:</label>
                <div class="group">
                    <i class="fas fa-unlock"></i>
                     <asp:TextBox ID="txt_password" TextMode=Password class="form-control" placeholder="Password" runat="server"></asp:TextBox>
                   
                </div>
            </div>
            
              <div class=" w3l-form-group">
                <label>Şifre Onayla</label>
                <div class="group">
                    <i class="fas fa-unlock"></i>
                     <asp:TextBox ID="txt_cpass" TextMode="Password" class="form-control" placeholder="Confirm Password" runat="server"></asp:TextBox>
                
                </div>
            </div>
            
            <div class="forgot">
              
                <p>
                    <asp:CheckBox ID="CheckBox1" runat="server" />Beni Hatırla</p>
            </div>
            <asp:Button ID="btn_submit" runat="server" Text="Registration" BackColor="Blue" 
                Font-Bold="True" Font-Size="Medium" ForeColor="#FFFFCC" 
                onclick="btn_submit_Click" />
          
        </form>
        <p class=" w3l-register-p">Kayıt olmak<a href="Login.aspx" class="register"> Giriş</a></p>
    </div>
    <footer>
        <p class="copyright-agileinfo"> &copy; 2023 Otel Rezervasyon Sistemi. Tüm Hakları Saklıdı | Design by <a href="#">Sude Türk</a></p>
    </footer>

     
    </div>
    </form>
</body>
</html>
