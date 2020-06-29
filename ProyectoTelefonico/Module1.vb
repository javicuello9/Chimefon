Module Module1


    Sub Main()
        Dim Dia As String
        Dim Minutos As Int32
        Dim ValorMinuto As Double
        Dim MinutosImpuestos As Double


        Console.WriteLine("ingrese Dia de la llamda:")
        Dia = Console.ReadLine.ToUpper


        If Dia = "DOMINGO" Then

            Console.WriteLine("ingrese minutos de duracion de llamada:")
            Minutos = Console.ReadLine

            Select Case Minutos
                Case <= 5
                    ValorMinuto = Minutos * 1.0
                    MinutosImpuestos = ValorMinuto + (ValorMinuto * 0.3)

                    Console.WriteLine("valor de su llamada: $" & MinutosImpuestos)
                Case <= 8
                    ValorMinuto = Minutos * 0.8
                    MinutosImpuestos = ValorMinuto + (ValorMinuto * 0.3)
                    Console.WriteLine("valor de su llamada: $" & MinutosImpuestos)
                Case <= 9
                    ValorMinuto = Minutos * 0.7
                    MinutosImpuestos = ValorMinuto + (ValorMinuto * 0.3)
                    Console.WriteLine("valor de su llamada: $" & MinutosImpuestos)
                Case >= 10
                    ValorMinuto = Minutos * 0.5
                    MinutosImpuestos = ValorMinuto + (ValorMinuto * 0.3)
                    Console.WriteLine("valor de su llamada: $" & MinutosImpuestos)
            End Select
            Console.ReadLine()
        Else
            If Dia = "LUNES" Then

                Console.WriteLine("ingrese minutos de duracion de llamada:")
                Minutos = Console.ReadLine

                Select Case Minutos
                    Case <= 5
                        ValorMinuto = Minutos * 1.0

                        Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                    Case <= 8
                        ValorMinuto = Minutos * 0.8
                        Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                    Case <= 9
                        ValorMinuto = Minutos * 0.7
                        Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                    Case >= 10
                        ValorMinuto = Minutos * 0.5
                        Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                End Select
            Else

                If Dia = "MARTES" Then
                    Console.WriteLine("ingrese minutos de duracion de llamada:")
                    Minutos = Console.ReadLine
                    Select Case Minutos
                        Case <= 5
                            ValorMinuto = Minutos * 1.0

                            Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                        Case <= 8
                            ValorMinuto = Minutos * 0.8
                            Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                        Case <= 9
                            ValorMinuto = Minutos * 0.7
                            Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                        Case >= 10
                            ValorMinuto = Minutos * 0.5
                            Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                    End Select
                Else
                    If Dia = "MIERCOLES" Then
                        Console.WriteLine("ingrese minutos de duracion de llamada:")
                        Minutos = Console.ReadLine
                        Select Case Minutos
                            Case <= 5
                                ValorMinuto = Minutos * 1.0

                                Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                            Case <= 8
                                ValorMinuto = Minutos * 0.8
                                Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                            Case <= 9
                                ValorMinuto = Minutos * 0.7
                                Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                            Case >= 10
                                ValorMinuto = Minutos * 0.5
                                Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                        End Select
                    Else
                        If Dia = "JUEVES" Then
                            Console.WriteLine("ingrese minutos de duracion de llamada:")
                            Minutos = Console.ReadLine
                            Select Case Minutos
                                Case <= 5
                                    ValorMinuto = Minutos * 1.0

                                    Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                                Case <= 8
                                    ValorMinuto = Minutos * 0.8
                                    Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                                Case <= 9
                                    ValorMinuto = Minutos * 0.7
                                    Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                                Case >= 10
                                    ValorMinuto = Minutos * 0.5
                                    Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                            End Select

                        Else
                            If Dia = "VIERNES" Then
                                Console.WriteLine("ingrese minutos de duracion de llamada:")
                                Minutos = Console.ReadLine
                                Select Case Minutos
                                    Case <= 5
                                        ValorMinuto = Minutos * 1.0

                                        Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                                    Case <= 8
                                        ValorMinuto = Minutos * 0.8
                                        Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                                    Case <= 9
                                        ValorMinuto = Minutos * 0.7
                                        Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                                    Case >= 10
                                        ValorMinuto = Minutos * 0.5
                                        Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                                End Select
                            Else
                                If Dia = "SABADO" Then
                                    Console.WriteLine("ingrese minutos de duracion de llamada:")
                                    Minutos = Console.ReadLine
                                    Select Case Minutos
                                        Case <= 5
                                            ValorMinuto = Minutos * 1.0

                                            Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                                        Case <= 8
                                            ValorMinuto = Minutos * 0.8
                                            Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                                        Case <= 9
                                            ValorMinuto = Minutos * 0.7
                                            Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                                        Case >= 10
                                            ValorMinuto = Minutos * 0.5
                                            Console.WriteLine("valor de su llamada: $" & ValorMinuto)
                                    End Select
                                Else
                                    Console.WriteLine("Error... Escriba nuevamente el dia")
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Console.ReadLine()
    End Sub


End Module
