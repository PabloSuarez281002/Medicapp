#!/bin/bash

clear
declare -i modificargrupo
read -p "Modificacion de grupo"
read -p " Ingrese nombre de grupo para modificar:" nombreviejo
modificargrupo=$(cat /etc/group|grep -c "$nombreviejo")
if [$modificargrupo -eq 0];then
echo -e "El grupo ingresado no existe"
echo -e "Espere a que lo llevemos al menu"
sleep 4;
else
read -p "Ingrese el nuevo nombre de grupo para $nombreviejo:" nuevonombre
sudo groupmod -n $nuevonombre $nombreviejo
echo -e "El grupo ha sido modificado con exito. El nuevo nombre es $nuevonombre"
sleep 4;
fi
;;


