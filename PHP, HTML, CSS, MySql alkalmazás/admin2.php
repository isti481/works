<?php
error_reporting(E_ALL & ~E_WARNING & ~E_NOTICE);
$servername="localhost";
$username="root";
$password="";
$database="felhasznalok";
$conn = new mysqli($servername, $username, $password, $database);
$conn->set_charset("utf8");
if ($conn->connect_error) {
  die("Kapcsolat hiba: " . $conn->connect_error);
}
?>
<!DOCTYPE html>
<html lang="hu">
<head>
<meta charset="UTF-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Admin</title> 
<style>
table tr :hover {background-color: yellow;}
        table {
            border-collapse: collapse;  
        }
        th {
          border: 1px solid black;
            text-align: left;
            padding: 5px;
        }            
        table tr, td {
          text-align: center;
            border: 1px solid black;
            padding: 10px;                       
        }
        tr :nth-child(even){
            background-color: lightgreen;
        }  
</style>  
</head>
<body>
<?php
if (!$conn) {
  die("Connection failed: " . mysqli_connect_error());
}
$sql = "SELECT nev, email, tel, stat FROM adatok";
$result = mysqli_query($conn, $sql);
if (mysqli_num_rows($result) > 0) {   
    echo "<table>
        <tr>
    <th>Név</th>
    <th>Email</th>
    <th>Telefonszám</th>
    <th>Státusz</th>
    </tr>";   
    while($row = mysqli_fetch_assoc($result)) {
    echo " <tr>";
    echo "<td>" . $row['nev'] . "</td>";
    echo "<td>" . $row['email'] . "</td>";
    echo "<td>" . $row['tel'] . "</td>";  
    echo "<td>" . $row['stat'] . "</td>";
    echo " </tr>";}
    echo " </table>";  
} else {
  echo "0 results";
}
mysqli_close($conn);
?>
</body>
</html>