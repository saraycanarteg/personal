/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */
package com.mycompany.imagenes;

import java.awt.image.BufferedImage;
import java.io.File;

import javax.imageio.ImageIO;

/**
 *
 * @author andrespillajo
 */
public class Imagenes {

    public static void main(String[] args) {
        try {
            // Cargar la imagen
            for (int i = 1; i < 4; i++) {
                System.out.println("####################################################");
                File archivo = new File("D:\\Universidad\\Cuarto Semestre\\Computación Paralela\\Laboratorios\\Lab3\\PDI-concurrente-master\\PDI-concurrente-master\\images\\"+i+"img.jpg");
                BufferedImage imagen = ImageIO.read(archivo);

                int altura = imagen.getHeight();
                int ancho = imagen.getWidth();

                System.out.println("Procesando imagen de " + ancho + "x" + altura);

                // Crear y asignar hilos
                int numeroHilos = 4; // Dividir en 4 partes
                Thread[] hilos = new Thread[numeroHilos];

                int filasPorHilo = altura / numeroHilos;
                int finFila;

                long inicio = System.nanoTime(); // Registrar tiempo inicial

                for (int j = 0; j < numeroHilos; j++) {
                    int inicioFila = j * filasPorHilo;

                    if (j == numeroHilos - 1) {
                        finFila = altura;
                    } else {
                        finFila = inicioFila + filasPorHilo;
                    }

                    hilos[j] = new Thread(new FiltroGris(imagen, inicioFila, finFila));
                    hilos[j].start();
                }

                // Esperar a que todos los hilos terminen
                for (Thread hilo : hilos) {
                    hilo.join();
                }

                // Guardar la nueva imagen
                File archivoSalida = new File("D:\\Universidad\\Cuarto Semestre\\Computación Paralela\\Laboratorios\\Lab3\\PDI-concurrente-master\\PDI-concurrente-master\\gray_images\\"+i+"img_gray.jpg");
                ImageIO.write(imagen, "jpg", archivoSalida);

                long fin = System.nanoTime(); // Registrar tiempo final

                System.out.println("Imagen guardada como: "+i+"img_gray.jpg");
                System.out.println("Tiempo de ejecución: " + (fin - inicio) / 1_000_000 + " ms");

            }

        } catch (Exception e) {
            e.printStackTrace();
        }
        System.out.println("####################################################");
    }
}
