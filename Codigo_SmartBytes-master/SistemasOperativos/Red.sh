#!/bin/bash

clear
while :
do 
echo "------------------Menu IPtables------------------"
echo "- 1- Bloquear ip 172.16.0.0/18                   "
echo "- 2- Desbloquear ip 172.16.0.0/18                "
echo "- 3- Salir                                       "
echo "-------------------------------------------------"
echo -e "\n"
read -p "Ingrese una opcion: " opc

case "$opc" in 

1) 
	clear	
	echo "Se mostrara a continuacion las reglas registradas en el  archivo"
	sleep 4;
	echo "--------------------------------------------------------------------"
	iptables -L INPUT -n --line-numbers
	echo "--------------------------------------------------------------------"
	sleep 3;
	iptables -I INPUT 1 -s 172.16.0.2/18 -p tcp --dport 522 -j DROP
	echo "--------------------------------------------------------------------"	
	echo "Bloqueado con exito..."
	echo "--------------------------------------------------------------------"
	iptables -L INPUT -n --line-numbers
	echo "--------------------------------------------------------------------"
	;;

2)
	clear
	echo "Se mostrara a continuacion las reglas registradas en el archivo"
	sleep 4;
	echo "---------------------------------------------------------------------"
	iptables -L INPUT -n --line-numbers
	echo "---------------------------------------------------------------------"	
	sleep 3;
	iptables -D INPUT 1
	echo "---------------------------------------------------------------------"
	echo "Desbloqueado con exito"
	echo "---------------------------------------------------------------------"
	iptables -L INPUT -n --line-numbers
	echo "----------------------------------------------------------------------"
	;;

3)
	clear
	echo "Finalizando..."
	sleep 3;
	exit;;

*) echo "$opc no es una opcion valida, intente nuevamente..."	
	sleep 1;
	;;

esac
done
	
