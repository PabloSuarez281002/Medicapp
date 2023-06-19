#!/bin/bash

clear
echo "------------------Respaldo SQL------------------"
FECHA_Y_HORA=`date "+%d-%m-%y_%H-%M-%S"`
NOMBRE_ARCHIVO="Respaldo_SQL_$FECHA_Y_HORA"
mkdir /root/Respaldo_CARPETA_ORIGINAL/$NOMBRE_ARCHIVO
cp -R /var/lib/mysql/medicapp /root/Respaldo_CARPETA_ORIGINAL/$NOMBRE_ARCHIVO
echo "Respaldo dentro del servidor del archivo SQL creado con exito..."
sleep 3;
echo "Finalizando..."

