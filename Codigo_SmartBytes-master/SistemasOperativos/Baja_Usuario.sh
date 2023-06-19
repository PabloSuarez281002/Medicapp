#!/bin/bash


clear
declare -i usuariobaja
echo "Baja de Usuario"
read -p "Ingrese el nombre de usuario para dar de baja:" bajausuario
read -p "Ingrese el nombre del grupo al que pertenece (Medicos o Administradores):" grupo1
usuariobaja=$(cat /etc/passwd|grep -c "$bajausuario")
if [$usuariobaja -eq 0];then 
echo -e "El usuario ingresado no coincide con uno creado..."
echo -e "Espere 4 segundos para ser volver al menu..."
sleep 4;
else
sudo userdel $bajausuario ##Eliminar usuario interno
echo -e "El usuario ha sido eliminado internamente..."
sleep 3;
rm -rf /root/CARPETA_ORIGINAL/Datos/Usuario/$grupo1/$bajausuario  
echo -e "La carpeta del usuario ha sido eliminada correctamente..."
sleep 3;
fi




