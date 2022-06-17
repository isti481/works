<?php
error_reporting(E_ALL & ~E_WARNING & ~E_NOTICE);
?>
<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<link rel="stylesheet" href="bootstrap-4.4.1-dist/css/bootstrap.min.css" />

<title>Admin</title>  
</head>
<body>
<div class="container-fluid">
<div class="row">
<div class="col-xl-6">
  <form method="POST">
  <h2><label>Kérlek jelentkezz be az adminnal! </label></h2><br>

  <label>Felhasználónév:</label>
  <input type="text" class="form-control" name="nev" placeholder="Név" required><br>

  <label>Jelszó:</label>
  <input type="password" class="form-control" name="password" placeholder="Jelszó" required><br>

  <button type="submit" name="bejelentkezes" class="btn btn-primary">Bejelentkezes</button>
</form>
</div>
<img src="" alt="My test image">
<?php
$nev=$_POST["nev"];
$password=$_POST["password"];

$nevdrot="admin";
$jelszodrot="jelszo";

if ($nev == $nevdrot && $password == $jelszodrot)
    {
      echo '
        <script>
        alert("Felhasznalo sikeresen belepett!");
        </script>'
        ;
        echo '<script>window.location = "admin2.php";</script>';        
    } 
  
?>
</body>
</html>