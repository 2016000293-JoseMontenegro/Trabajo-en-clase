//Crear una app que simule un sistema de un cajero automatico
// 1- tres intentos, al tercer intento bloquear la tarjeta
// 2- Consultar saldo
//3- Retirar dinero
//4- Deposito de dinero 
//5- Salir

//Limpiar pantalla en C# system.clear() o System.cls()
Algoritmo CajeroAutomatico
	Definir saldo, deposito, retiro Como Real
	Definir opc, intentos Como Entero
	Definir pin, pinCorrecto Como Entero
	saldo = 10000
	pinCorrecto = 1234
	intentos = 0
	
	//Validar el acceso por medio del pin
	Mientras intentos<3 Hacer
		Escribir Sin Saltar "Ingrese su PIN: "
		leer pin
		
		Si pin == pinCorrecto Entonces
			Limpiar Pantalla
			Escribir "Acceso Concedido!!!"
			
			Repetir //Es el DO-WHILE
				Limpiar Pantalla
				Escribir "==========================="
				Escribir "		  MENÚ PRINIPAL"
				Escribir "1- Consultar Saldo"
				Escribir "2- Depositar Dinero"
				Escribir "3- Retirar Dinero"
				Escribir "4- Salir"
				Escribir "==========================="
				
				Escribir Sin Saltar "Seleccione una Opción: []"
				Leer opc
				
				Segun opc Hacer //Switch
					1:
						Limpiar Pantalla
						Escribir "Su Saldo actual es: Q.",saldo
						Escribir "Presione una tecla para volver al menú"
						Esperar Tecla
					2:
						Limpiar Pantalla
						Escribir Sin Saltar "Ingrese el Monto a depositar: Q."
						Leer deposito
						saldo = saldo + deposito //Acumulador
						Escribir "Depósito exitoso, saldo nuevo: Q.",saldo
						Escribir "Presione una tecla para volver al menú"
						Esperar Tecla
					3:
						Limpiar Pantalla
						Escribir Sin Saltar "Ingrese monto a retirar: Q."
						leer retiro
						
						Si retiro <= saldo Entonces
							saldo = saldo-retiro
							Escribir "Retiro Exitoso, nuevo Saldo: Q.", saldo
						SiNo
							Escribir "Fondos Insuficientes"
						Fin Si
						Escribir "Presione una tecla para volver al menú"
						Esperar Tecla
					4: 
						Limpiar Pantalla
						Escribir "Gracias por usar cajero"
						Esperar Tecla
					De Otro Modo:
						Escribir "Opción inválida"
				Fin Segun
			Hasta Que opc == 4
			//terminar programa
				intentos = 4
			
		SiNo
			intentos = intentos+1 //Contador
			Escribir "PIN INCORRECTO, intento: ",intentos, "de 3"
		Fin Si
	Fin Mientras
	
	//bloqueo de la tarjeta
	//Más intentos
	Si intentos == 3 Entonces
		Escribir "Tarjeta Bloqueada"
		Escribir "Demasiados intentos fallidos"
	Fin Si
	//Opción salir 
	Si intentos == 4 Entonces
		Escribir ()
	Fin Si
	Escribir "Presione una tecla para salir del sistema"
	Esperar Tecla
FinAlgoritmo
