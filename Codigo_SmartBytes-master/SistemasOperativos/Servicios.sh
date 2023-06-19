#!/bin/bash

clear
while :
do
echo "------------------Servicios------------------"
echo "-                                           -"
echo "- 1- Logs fallidos al sistema               -"
echo "- 2- Ver los cinco ultimos log al sistema   -"
echo "- 3- Salir                                  -"
echo "---------------------------------------------"
echo -e "\n"
read -p "Ingrese una opcion: " opc

case "$opc" in 

1)
	clear
	echo "Los logs fallidos al sistema se mostraran a continuacion... "
	sleep 1;
	echo "Espere por favor..."
	lastb -ia  	
	echo "Saliendo..."
	sleep 4;
	;;


2)
	clear
	echo "Se mostraran los 5 ultimos logs al sistema..."
	last -aiFn 5  
	sleep 5;
	echo -e "\n"
	;;
3)
	clear
	echo "Finalizando..."
	sleep 3;
	exit;;


*) echo "$opc no es una opcion valida, intente nuevamente..."
	sleep 3;
	;;

esac
done

