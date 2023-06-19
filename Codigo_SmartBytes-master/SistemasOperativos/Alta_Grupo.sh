#!/bin/bash

clear
read -p "Ingrese el nombre del grupo a crear:" grupo
sudo groupadd $grupo
cd /root/CARPETA_ORIGINAL/Datos/
mkdir Grupo
echo "El grupo $grupo ha sido creado..."
sleep 3;


