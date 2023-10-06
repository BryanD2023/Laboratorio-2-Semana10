Module Module1

    Sub Main()
        'Ejercicio1()
        Ejercicio2()
    End Sub

    Sub Ejercicio1()
        Dim costoProducto As Double
        Dim dineroEntregado As Double


        Console.WriteLine("Ingrese el costo del artículo vendido:")
        costoProducto = Double.Parse(Console.ReadLine())

        Console.WriteLine("Ingrese la cantidad de dinero entregada por el cliente:")
        dineroEntregado = Double.Parse(Console.ReadLine())

        If dineroEntregado > costoProducto Then
            Dim cambio As Double = dineroEntregado - costoProducto
            Console.WriteLine("El cambio a entregar al cliente es: $" & cambio)
            Console.WriteLine("Vuelva pronto por el producto que desee estimado cliente")
            Console.WriteLine("Ejercicio Desarrollado por Bryan Alexis Duran Duran")
            Console.WriteLine("Codigo: DD2226012022")
            Console.WriteLine("Carrera: Tecnico en Computacion")
        ElseIf dineroEntregado = costoProducto Then
            Console.WriteLine("Se ha hecho la entrega del producto al cliente.")
            Console.WriteLine("Vuelva pronto por el producto que desee estimado cliente")
            Console.WriteLine("Ejercicio Desarrollado por Bryan Alexis Duran Duran")
            Console.WriteLine("Codigo: DD2226012022")
            Console.WriteLine("Carrera: Tecnico en Computacion")
        Else
            Console.WriteLine("El pago efectuado es insuficiente.")
            Dim faltante As Double = costoProducto - dineroEntregado
            Console.WriteLine("Falta por pagar: $" & faltante)
            If faltante > 0 Then
                Console.WriteLine("El cliente no posee suficiente dinero. Vuelva pronto por el producto que desea.")
                Console.WriteLine("Vuelva pronto por el producto que desee estimado cliente")
                Console.WriteLine("Ejercicio Desarrollado por Bryan Alexis Duran Duran")
                Console.WriteLine("Codigo: DD2226012022")
                Console.WriteLine("Carrera: Tecnico en Computacion")
            End If
        End If

        Console.ReadLine()


    End Sub


    Sub Ejercicio2()

        Dim montoCompra As Double
        Dim contadorCompras As Integer
        Dim totalCompras As Double
        Dim descuento5 As Double
        Dim descuento10 As Double

        contadorCompras = 0
        totalCompras = 0
        descuento5 = 0.05
        descuento10 = 0.1


        Do
            montoCompra = InputBox("Ingrese el monto de la compra: ")


            If montoCompra < 0 Then
                MsgBox("La operación ha sido cancelada")
                Return
            Else
                totalCompras = totalCompras + montoCompra

                contadorCompras = contadorCompras + 1
            End If

        Loop Until montoCompra = 0

        If totalCompras >= 500 Then
            descuento5 = totalCompras * descuento5
        End If

        If totalCompras >= 1000 Then
            descuento10 = totalCompras * descuento10
        End If

        totalCompras = totalCompras - descuento5 - descuento10

        If descuento5 > 0 Or descuento10 > 0 Then
            MsgBox("El total de la compra es de: $" & totalCompras)
            MsgBox("El descuento aplicado fue de: $" & descuento5 + descuento10)
        Else
            MsgBox("El total de la compra es de: $" & totalCompras)

        End If
        Console.WriteLine("Ejercicio Desarrollado por Bryan Alexis Duran Duran")
        Console.WriteLine("Codigo: DD2226012022")
        Console.WriteLine("Carrera: Tecnico en Computacion")
    End Sub

End Module
