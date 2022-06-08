<?php
error_reporting(E_ALL & ~E_WARNING & ~E_NOTICE);
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <style>
    <link rel="stylesheet" type="text/css" href="default.css">
    </style>
    <title>Admin</title>
    

</head>

<body>


<form method="POST">
<h2><label>Belépés</label></h2><br>

<label>Felhasználónév:</label>
<input type="text" name="nev" placeholder="Név" required><br>

<label>Jelszó:</label>
<input type="password" name="password" placeholder="Password" required><br>

<button type="submit" name="bejelentkezes">Bejelentkezes</button>




</form>

<img src="" alt="My test image">

<?php
// belepes
$nev=$_POST["nev"];
$password=$_POST["password"];

$nevdrot="admin";
$jelszodrot="jelszo";
if ($nev == $nevdrot && $password == $jelszodrot)
    {
      echo '
        <script>
        alert("Felhasznalo sikeresen belepett!")
        </script>'
        ;
        echo "<script>window.location = 'admin2.php'</script>";
      
    
    }
    else{
      echo '
      <script>
      alert("Felhasznalonév vagy jelszó nem stimmel!")
      </script>';
    }
      
    

    ?>


</body>
</html>