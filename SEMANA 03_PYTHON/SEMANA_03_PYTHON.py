def ejercicio1(): #creando ejercicio 1
    nombre = input ("Ingrese su nombre: ")
    carrera = input ("Ingrese su carrera: ")

    print (f"\n{nombre}, bienvenido a FA de {carrera}")

def ejercicio2():
    x = int (input("Ingrese el valor de x: "))
    y = int (input("Ingrese el valor de y: "))

    print ("Suma: ", (x+y))  
    print ("Resta: ", (x-y)) 
    print ("Multiplicacion: ", (x*y)) 
    print ("Division: ", (x/y))

def ejercicio3():
    
    print("\"ANTONY\"")


import math # IMPORTANDO LA LIBRERIA MATH
def ejercicio4():
     num = float(input ("Ingrese su numero decimal: "))

     print ("Raiz 2: ", math.sqrt(num))
     print ("Redondeado: ", round (num,0))
     print ("Al cubo: ", math.pow (num,3))
     print ("Raiz 3: ", num** (1/3))


def ejercicio5():
  num= input ("Ingrese un numero entero: ")

  entero = int (num)
  deci = float (num)

  print ("Resto: ", (entero%2))
  print ("Division: ", (deci/3))
  
ejercicio1()
               

