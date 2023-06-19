#!/bin/bash


while :
do
clear
echo "---------------------Menu------------------------------------"
echo "-                                                           -"
echo "- 1 - Crear Grupo                                           -"
echo "- 2 - Modificar Grupo                                       -"
echo "- 3 - Eliminar Grupo                                        -"
echo "- 4 - Crear Usuario                                         -"
echo "- 5 - Modificar Usuario                                     -"
echo "- 6 - Eliminar Usuario                                      -"
echo "- 7 - Salir                                                 -" 
echo "-                                                           -"    
echo "-------------------------------------------------------------"
echo -e "\n"
read -p "Ingrese una opcion: " opc

case "$opc" in 


1) 
	clear	
	echo "Crear Grupo"
	./Alta_Grupo.sh
	;;

2)
	clear
	echo "Modificar Grupo"
	./Modificacion_Grupo.sh
	;;

3)
	clear
	echo "Eliminar Grupo"
	./Baja_Grupo.sh
	;;

4)
	clear
	echo "Crear Usuario"
	./Alta_Usuario.sh
	;;

5)
	clear
	echo "Modificar contraseña del usuario"
	./Modificacion_Usuario.sh	
	;;

6)
	clear	
	echo "Eliminar Usuario"
	./Baja_Usuario.sh
	;;


7)	
	clear	
	echo "Finalizando..."
	sleep 3;
	exit ;;

*) echo "$opc no es una opcion valida, intente nuevamente..."
	sleep 1;
	;;
	

esac
done








