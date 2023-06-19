#!/bin/bash

while :
do
clear
echo "------------------Menu------------------"
echo "-                                      _"
echo "- 1- Usuarios                          -"
echo "- 2- Red                               -"
echo "- 3- Servicios                         -"
echo "- 4- Procesos                          -"
echo "- 5- Respaldo (CRON)                   -"
echo "- 6- Monitoreo de Procesos             -"
echo "- 7- Respaldo datos SQL                -"
echo "- 8- Salir                             _"
echo "----------------------------------------"
echo -e "\n"
read -p "Ingrese una opcion: " opc

case "$opc" in

1)
	clear
	echo "Usuarios"
	./Menu_Usuario.sh
	;;

2)
	clear
	echo "Red"
	./Red.sh
	;;

3)
	clear
	echo "Servicios"
	./Servicios.sh
	;;

4)
	clear
	echo "Procesos"
	./Procesos.sh
	;;

5) 
	clear
	echo "Respaldo"
	./Cron_Respaldo.sh
	;;

6)
	clear
	echo "Monitoreo de procesos"
	./Monitoreo_Procesos.sh
	;;

7)
	clear
	echo "Respaldo datos SQL"
	./Respaldo_SQL.sh
	;;

8)
	clear
	echo "Finalizando..."
	sleep 3;
	exit;;

*) echo "$opc no es una opcion valida, intente nuevamente..."
	sleep 1;
	;;

esac
done

