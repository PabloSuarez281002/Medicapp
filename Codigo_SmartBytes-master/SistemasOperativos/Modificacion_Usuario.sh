#!/bin/bash

clear
declare -i usuariomodificar
echo "Modificacion de la contraseña de usuarios"
read -p "Ingrese el nombre del usuario para modificar:" modificarusuario
usuariomodificar=$(cat /etc/passwd|grep -c "$modificarusuario")
if [$usuariomodificar -eq 0];then
echo "El usuario ingresado no existe"
echo -e "Espere 4 segundos para ser volver al menu..."
sleep 4;
else
sudo passwd $modificarusuario ##Se le pide al usuario el cambio de constraseña del usuario que ingreso
echo "El usuario $modificarusuario ha sido modificado"
sleep 3;
fi



