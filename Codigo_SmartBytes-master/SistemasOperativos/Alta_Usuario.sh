#!/bin/bash


clear
read -p "Ingrese la cedula sin puntos ni guiones:" cedula
read -p "Ingrese su nombre:" nombre
read -p "Ingrese su primer apellido:" apellidouno
read -p "Ingrese su segundo apellido:" apellidodos
read -p "Ingrese el sexo:" sexo
read -p "Ingrese la calle:" calle
read -p "Ingrese la esquina:" esquina
read -p "Ingrese el numero de puerta:" numpuerta
read -p "Ingrese la fecha de nacimiento:" fechanacimiento
read -p "Ingrese el grupo al que pertenece (Medicos o Administradores):" grupo

cd /root/CARPETA_ORIGINAL/Datos/Usuario/$grupo
mkdir $nombre  

echo "Ci: $cedula" > /root/CARPETA_ORIGINAL/Datos/Usuario/$grupo/$nombre/datos_$nombre.txt
echo "Nombre: $nombre" >> /root/CARPETA_ORIGINAL/Datos/Usuario/$grupo/$nombre/datos_$nombre.txt
echo "Primer Apellido: $apellidouno" >> /root/CARPETA_ORIGINAL/Datos/Usuario/$grupo/$nombre/datos_$nombre.txt
echo "Segundo Apellido: $apellidodos" >> /root/CARPETA_ORIGINAL/Datos/Usuario/$grupo/$nombre/datos_$nombre.txt
echo "Sexo: $sexo" >> /root/CARPETA_ORIGINAL/Datos/Usuario/$grupo/$nombre/datos_$nombre.txt
echo "Calle: $calle" >> /root/CARPETA_ORIGINAL/Datos/Usuario/$grupo/$nombre/datos_$nombre.txt 
echo "Esquina: $esquina" >> /root/CARPETA_ORIGINAL/Datos/Usuario/$grupo/$nombre/datos_$nombre.txt
echo "Numero de puerta: $numpuerta" >> /root/CARPETA_ORIGINAL/Datos/Usuario/$grupo/$nombre/datos_$nombre.txt
echo "Fecha de nacimiento: $fechanacimiento" >> /root/CARPETA_ORIGINAL/Datos/Usuario/$grupo/$nombre/datos_$nombre.txt
echo "Grupo: $grupo" >> /root/CARPETA_ORIGINAL/Datos/Usuario/$grupo/$nombre/datos_$nombre.txt

sudo useradd -d /root/CARPETA_ORIGINAL/Datos/Usuario/$grupo/$nombre  -m -s /bin/bash -g $grupo $nombre

echo "Ingrese una contraseña para el usuario" 
sudo passwd $nombre
sleep 3;

##export $cedula
##export $nombre
##export $apellidouno
##export $apellidodos
##export $sexo
##export $calle
##export $esquina
##export $numpuerta
##export $fechanacimiento
##export $grupo







 

