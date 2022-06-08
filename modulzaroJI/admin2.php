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
    
    <title>Admin</title>
    
</head>
<!--
<body>
<table>
<tr>
<td></td>
</tr>
<tr>
<td></td>
</tr>
<tr>
<td></td>
</tr>


</table>
-->






<?php
/*
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

*/


// $conn = mysqli_connect($servername, $username, $password, $dbname);
// Check connection
if (!$conn) {
  die("Connection failed: " . mysqli_connect_error());
}

$sql = "SELECT nev, email, tel, stat FROM adatok";
$result = mysqli_query($conn, $sql);

if (mysqli_num_rows($result) > 0) {
  echo "<table><tr><th>Név: </th><th>Telefonszám:  </th><th>Státusz: </th></tr>";
  // output data of each row
  while($row = mysqli_fetch_assoc($result)) {
    echo "<tr>Név:<td> " . $row["nev"]. " </tr></td><tr><td>Telefonszám: " . $row["tel"]. "Státusz: " . $row["stat"]. "<br>";
  }
  while($row = mysqli_fetch_assoc($result)) {
    echo "--------------------------------------------------------------------------------";
    echo "</table>";
  
  echo"<table>
  <tr>
  <td>Név:</td>
  </tr>
  <tr>
  <td>".$row["nev"]."</td>
  </tr>
  <tr>
  <td>Telefonszám</td>
  </tr>
  <tr>
  <td></td>
  <tr>
  <td></td>
  </tr>
  </tr>
  </table>";
  } 
} else {
  echo "0 results";
}

mysqli_close($conn);





?>
</body>
</html>