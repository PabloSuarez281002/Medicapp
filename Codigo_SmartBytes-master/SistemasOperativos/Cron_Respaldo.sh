#!/bin/bash

clear
echo "------------------Respaldo------------------"
FECHA_Y_HORA=`date "+%d-%m-%y_%H-%M-%S"`
NOMBRE_ARCHIVO="Respaldo_$FECHA_Y_HORA"
mkdir /root/Respaldo_CARPETA_ORIGINAL/$NOMBRE_ARCHIVO
cp -R /root/CARPETA_ORIGINAL /root/Respaldo_CARPETA_ORIGINAL/$NOMBRE_ARCHIVO	
echo "Respaldo dentro del servidor creado con exito..."
sleep 3;
echo "Finalizando..."

