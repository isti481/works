<?php
error_reporting(E_ALL & ~E_WARNING & ~E_NOTICE);
$servername="localhost";
$username="root";
$password="";
$database="modulzaroji";


$conn = new mysqli($servername, $username, $password, $database);
$conn->set_charset("utf8");


if ($conn->connect_error) {
  die("Kapcsolat hiba: " . $conn->connect_error);
}

?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="bootstrap-4.4.1-dist/css/bootstrap.min.css" />
    <title>Regisztracio</title>
    

</head>

<body>

<div class="container-fluid">
<div class="row">
<div class="col-xl-6">
 
<form method="POST">
<h2><label>Regisztráció</label></h2><br>

<label>Felhasználónév:</label>
<input type="text" class="form-control" name="nev" placeholder="Név" required><br>


<label>E-mail:</label>
<input type="text" class="form-control" name="email" placeholder="Email" required><br>

<label>Telefonszám</label>
<input type="tel" class="form-control" name="tel" placeholder="+36"><br>


<label>Jelszó:</label>
<input type="password" class="form-control" name="jelszo" placeholder="Jelszó" required><br>
<input type="password" class="form-control" name="jelszo2" placeholder="Jelszó megadása ismét" required><br>
<button type="submit" class="btn btn-primary" name="reg">Regisztráció</button>

</form>
</div>



<?php
// regisztracio

$password=$_POST["jelszo"];
$password2=$_POST["jelszo2"];

if($password != $password2){

    echo '
        <script>
        alert("A jelszó mezők nem egyeznek")
        </script>'
        ;
}


if (isset($_POST["reg"]) && $password == $password2)
    {
      $nev=$_POST["nev"];      
      $email=$_POST["email"];
      $tel = ($_POST["tel"] == "" ? "Nem adott meg számot" : $_POST["tel"]);

      $password=$_POST["jelszo"];
      $passwordsha=sha1($password);
      
      $stat=$_POST["0"];
      
      $sql="INSERT INTO adatok(nev,email,tel,password,stat) VALUES ('$nev', '$email', '$tel', '$passwordsha', '$stat')";

    if ($conn->query($sql)===TRUE) {
      echo '
      <script>
      alert("Felhasznalo sikeresen hozzáadva!")
      </script>';
      }
      else{
        echo "Hiba: ".$sql."<br>". $conn->error;
      }
      $conn->close();
      $nev="";
      $password="";
      $tel="";
      $email="";
      echo '<meta http-equiv="refresh" content="0;url=index.php">';



    }
    
    ?>



</body>
</html>