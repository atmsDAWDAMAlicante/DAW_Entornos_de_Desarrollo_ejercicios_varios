using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GestionBancariaAppNS;

namespace UnitTestProject1  // ATMS2DAWY2324
    {
    [TestClass]
    public class GestionBancariaTest  // ATMS2DAWY2324
        {

		// 1. PRUEBAS DEL MÉTODO RealizarIngreso()

		/*
		// 1.1.a VERSIÓN NORMAL RealizarIngreso() de una cantidad mayor que 1
		[TestMethod]
		public void PruebaRealizarIngresoMayor1()  // ATMS2DAWY2324
			{
			// ATMS2DAWY2324
			// preparación del caso de prueba
			double saldoInicial = 1000;
			double ingreso = 500;
			double saldoEsperado = 1500;

			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);

			// Método a probar
			miApp.RealizarIngreso(ingreso);

			// Verificación del resultado esperado
			Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Error al realizar el ingreso, saldo incorrecto.");
			}
		*/

		// 1.1.b VERSIÓN PARAMETRIZADA RealizarIngreso() de una cantidad mayor que 1
		[TestMethod]
		[DataRow(1000, 500, 1500)]
		public void PruebaRealizarIngresoMayor1(double saldoInicial,
			double ingreso, double saldoEsperado)  // ATMS2DAWY2324
			{
			// ATMS2DAWY2324
			// preparación del caso de prueba
			/*
			double saldoInicial = 1000;
			double ingreso = 500;
			double saldoEsperado = 1500;
			*/
			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);

			// Método a probar
			miApp.RealizarIngreso(ingreso);

			// Verificación del resultado esperado
			Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Error al realizar el ingreso, saldo incorrecto.");
			}


		// 1.2.a VERSIÓN NORMAL RealizarIngreso() de una cantidad menor que 1
		/*
		[TestMethod]
		//[ExpectedException(typeof(ArgumentOutOfRangeException))] ESTO DEBE ESTAR COMENTADO O QUITADO CON EL TRY - CATCH
		public void PruebaRealizarIngresoMenor1()  // ATMS2DAWY2324
			{
			// ATMS2DAWY2324
			// preparación del caso de prueba
			double saldoInicial = 1000;
			double ingreso = 0;
			// Línea comentada perteneciente al punto 7.1.2 del práctica
			//int ERR_CANTIDAD_NO_VALIDA = 1;

			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
		
			// Método a probar
			try
				{
				miApp.RealizarReintegro(ingreso);
				}
			catch (ArgumentOutOfRangeException exception)
				{
				// assert
				StringAssert.Contains(exception.Message,
				GestionBancariaApp.ERR_CANTIDAD_NO_VALIDA);
				return;
				}

			// ATMS2DAWY2324
			// Verificación del resultado esperado
			Assert.Fail("Error. Se debía haber producido una excepción.");
			// Verificación del resultado esperado
			// Línea comentada perteneciente al punto 7.1.2 del práctica
			//Assert.AreEqual(ERR_CANTIDAD_NO_VALIDA, resultado, "Se esperaba un error al ingresar una cantidad menor que 1");
			}
		*/

		// 1.2.b VERSIÓN PARAMETRIZADA RealizarIngreso() de una cantidad menor que 1
		[TestMethod]
		[DataRow(1000,0)]
		//[ExpectedException(typeof(ArgumentOutOfRangeException))] ESTO DEBE ESTAR COMENTADO O QUITADO CON EL TRY - CATCH
		public void PruebaRealizarIngresoMenor1(double saldoInicial, double ingreso)  // ATMS2DAWY2324
			{
			// ATMS2DAWY2324
			// preparación del caso de prueba
			/*
			double saldoInicial = 1000;
			double ingreso = 0;
			*/
			/* Línea comentada perteneciente al punto 7.1.2 del práctica */
			//int ERR_CANTIDAD_NO_VALIDA = 1;

			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);

			// Método a probar
			try
				{
				miApp.RealizarReintegro(ingreso);
				}
			catch (ArgumentOutOfRangeException exception)
				{
				// assert
				StringAssert.Contains(exception.Message,
				GestionBancariaApp.ERR_CANTIDAD_NO_VALIDA);
				return;
				}

			// ATMS2DAWY2324
			// Verificación del resultado esperado
			Assert.Fail("Error. Se debía haber producido una excepción.");
			// Verificación del resultado esperado
			/* Línea comentada perteneciente al punto 7.1.2 del práctica */
			//Assert.AreEqual(ERR_CANTIDAD_NO_VALIDA, resultado, "Se esperaba un error al ingresar una cantidad menor que 1");
			}


		// 2. PRUEBAS DEL MÉTODO RealizarReintegro()

		// 2.1.a VERSIÓN NORMAL RealizarReintegro() de una cantidad mayor que 0 y menor que el saldo
		/*
		[TestMethod]
		public void PruebaRealizarReintegroCantidadMenorSaldoyMayor1()  // ATMS2DAWY2324
			{
            // ATMS2DAWY2324
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 250;
            double saldoEsperado =	750;

            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);

            // Método a probar
            miApp.RealizarReintegro(reintegro);

			// Verificación del resultado esperado
			Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo incorrecto.");
            }
		*/

		// 2.1.b VERSIÓN PARAMETRIZADA RealizarReintegro() de una cantidad mayor que 0 y menor que el saldo

		[TestMethod]
		[DataRow(1000, 250, 750)]
		public void PruebaRealizarReintegroCantidadMenorSaldoyMayor1(double saldoInicial, 
						double reintegro, double saldoEsperado)  // ATMS2DAWY2324
			{
			// ATMS2DAWY2324
			// preparación del caso de prueba
			// Se comenta la asignación de valores para la prueba parametrizada
			/* double saldoInicial = 1000;
			double reintegro = 250;
			double saldoEsperado = 750;
			*/
			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);

			// Método a probar
			miApp.RealizarReintegro(reintegro);

			// Verificación del resultado esperado
			Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo incorrecto.");
			}




		// 2.2.a VERSIÓN NORMAL RealizarReintegro() de una cantidad menor que 1
		/*
		[TestMethod]
		public void PruebaRealizarReintegroCantidadMenor1()  // ATMS2DAWY2324
			{
			// preparación del caso de prueba
			double saldoInicial = 1000;
			double reintegro = -250;
			double saldoFinal = saldoInicial - reintegro;
			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);

			// Método a probar
			try
				{
				miApp.RealizarReintegro(reintegro);
				}
			catch (ArgumentOutOfRangeException exception)
				{
				// assert
				StringAssert.Contains(exception.Message,
				GestionBancariaApp.ERR_CANTIDAD_NO_VALIDA);
				return;
				}

			// Verificación del resultado esperado
			Assert.Fail("Error. Se debía haber producido una excepción.");
			}
		*/

		/* Bloque comentado perteneciente al punto 7.2.2 del práctica */
		/*
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void PruebaRealizarReintegroCantidadMenor1()  // ATMS2DAWY2324
			{
			// ATMS2DAWY2324
			// preparación del caso de prueba
			double saldoInicial = 1000;

								Las dos líneas siguientes y la cantidad 1250 se añaden en apartado nº 10 de la práctica
			double reintegro = 1250;
			double saldoEsperado = saldoInicial - reintegro;

			int ERR_CANTIDAD_NO_VALIDA = 1;


			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);

			// Método a probar
			int resultado = miApp.RealizarReintegro(reintegro);
			// ATMS2DAWY2324

			// Verificación del resultado esperado
			Assert.AreEqual(ERR_CANTIDAD_NO_VALIDA, resultado, 0.001, "Se esperaba un error al intentar retirar una " +
				"cantidad menor que 1");

			}
		*/

		// 2.2.b VERSIÓN PARAMETRIZADA RealizarReintegro() de una cantidad menor que 1

		[TestMethod]
		[DataRow(1000, -250, 750)]
		public void PruebaRealizarReintegroCantidadMenor1(double saldoInicial, double reintegro, 
						double saldoFinal)  // ATMS2DAWY2324
			{
			// preparación del caso de prueba
			/*
			double saldoInicial = 1000;
			double reintegro = -250;
			double saldoFinal = saldoInicial - reintegro;
			*/
			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);

			// Método a probar
			try
				{
				miApp.RealizarReintegro(reintegro);
				}
			catch (ArgumentOutOfRangeException exception)
				{
				// assert
				StringAssert.Contains(exception.Message,
				GestionBancariaApp.ERR_CANTIDAD_NO_VALIDA);
				return;
				}

			// Verificación del resultado esperado
			Assert.Fail("Error. Se debía haber producido una excepción.");
			}

		// 2.3.a VERSIÓN NORMAL RealizarReintegro() de una cantidad mayor que el saldo
		/*
		[TestMethod]
		//[ExpectedException(typeof(ArgumentOutOfRangeException))] ESTO DEBE ESTAR COMENTADO O QUITADO CON EL TRY - CATCH
		public void PruebaRealizarReintegroCantidadMayorSaldo()  // ATMS2DAWY2324
			{
			// ATMS2DAWY2324
			// preparación del caso de prueba
			double saldoInicial = 1000;
			double reintegro = 1001;
			double saldoFinal = saldoInicial - reintegro;
			Línea comentada perteneciente al punto 7.2.3 del práctica
			// int ERR_SALDO_INSUFICIENTE = 2;

			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);

			// Método a probar
			try
				{
				miApp.RealizarReintegro(reintegro);
				}
			catch (ArgumentOutOfRangeException exception)
				{
				// assert
				StringAssert.Contains(exception.Message,
				GestionBancariaApp.ERR_SALDO_INSUFICIENTE);
				return;
				}

			// ATMS2DAWY2324

			// Verificación del resultado esperado

			Assert.Fail("Error. Se debía haber producido una excepción.");

			Líneas comentadas pertenecientes al punto 7.2.3 del práctica
			//Assert.AreEqual(ERR_SALDO_INSUFICIENTE, resultado, "Se esperaba un error al intentar retirar una cantidad mayor " +
			//	" que el saldo");
			}
		*/

		// 2.3.b VERSIÓN PARAMETRIZADA RealizarReintegro() de una cantidad mayor que el saldo
		[TestMethod]
		[DataRow(1000, 1001)]
		//[ExpectedException(typeof(ArgumentOutOfRangeException))] ESTO DEBE ESTAR COMENTADO O QUITADO CON EL TRY - CATCH
		public void PruebaRealizarReintegroCantidadMayorSaldo(double saldoInicial, double reintegro)  // ATMS2DAWY2324
			{
			// ATMS2DAWY2324
			// preparación del caso de prueba
			/*
			double saldoInicial = 1000;
			double reintegro = 1001;
			*/
			/* Línea comentada perteneciente al punto 7.2.3 del práctica */
			// int ERR_SALDO_INSUFICIENTE = 2;

			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);

			// Método a probar
			try
				{
				miApp.RealizarReintegro(reintegro);
				}
			catch (ArgumentOutOfRangeException exception)
				{
				// assert
				StringAssert.Contains(exception.Message,
				GestionBancariaApp.ERR_SALDO_INSUFICIENTE);
				return;
				}

			// ATMS2DAWY2324

			// Verificación del resultado esperado

			Assert.Fail("Error. Se debía haber producido una excepción.");

			/* Líneas comentadas pertenecientes al punto 7.2.3 del práctica */
			//Assert.AreEqual(ERR_SALDO_INSUFICIENTE, resultado, "Se esperaba un error al intentar retirar una cantidad mayor " +
			//	" que el saldo");
			}


		}
	}
