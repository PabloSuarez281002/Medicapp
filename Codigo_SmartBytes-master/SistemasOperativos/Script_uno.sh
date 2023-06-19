#!/bin/bash

while :
do
clear
echo "---------------------Menu------------------------------------"
echo "-                                                           -"
echo "- 1 - Creacion del directorio Usuario                       -"
echo "- 2 - Creacion del directorio Medicos                       -"
echo "- 3 - Creacion del directorio Administradores               -" 
echo "- 4 - Respaldo Local (Forma Manual)                         -"
echo "- 5 - Salir                                                 -"
echo "-                                                           -"
echo "-------------------------------------------------------------"
echo -e "\n"
read -p "Ingrese una opcion: " opc

case "$opc" in 

1)	clear
	cd /root/CARPETA_ORIGINAL/Datos/
	mkdir Usuario
	sleep 2;
	echo "El directorio con nombre Usuario ha sido creado con exito..."
	sleep 1;	
	echo "Espere a que lo llevemos al menu..."
	sleep 4;
	;;

2) 
	clear
	cd /root/CARPETA_ORIGINAL/Datos/Usuario/
	mkdir Medicos 
	sleep 2;
	echo "El directorio con el nombre Medicos ha sido creado con exito..."
	sleep 1;	
	echo "Espere a que lo llevemos al menu..."	
	sleep 4;
	;;
3)
	clear	
	cd /root/CARPETA_ORIGINAL/Datos/Usuario/
	mkdir Administradores
	sleep 2;
	echo "El directorio con el nombre Administradores ha sido creado con exito..."
	sleep 1;	
	echo "Espere a que lo llevemos al menu..."
	sleep 4;
	;;

4)
	clear	
	FECHA_Y_HORA=`date "+%d-%m-%y_%H-%M-%S"`
	NOMBRE_ARCHIVO="Respaldo_$FECHA_Y_HORA"
	mkdir /root/Respaldo_CARPETA_ORIGINAL/$NOMBRE_ARCHIVO
	cp -R /root/CARPETA_ORIGINAL /root/Respaldo_CARPETA_ORIGINAL/$NOMBRE_ARCHIVO
	sleep 2;	
	echo "El respaldo ha sido realizado con exito"
	sleep 1;	
	echo "Espere a que lo llevemos al menu..."
	sleep 4;
	;;

5)	clear
	echo "Finalizando..."
	sleep 3;
	clear	
	exit ;;

*) echo "$opc no es una opcion valida, intente nuevamente..."
	sleep 1;
	;;



esac
done



