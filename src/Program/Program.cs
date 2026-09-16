//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;

namespace Ucu.Poo.Exercise
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    class Circuito
    {
    public static bool Calcular(bool entradaA, bool entradaB, bool entradaC)
    {
        bool CableAND = entradaA && entradaB;
        bool CableNOTAND = !entradaA && !entradaB;
        bool CableOR = CableAND || CableNOTAND;
        return CableOR && entradaC; 
        }

        static void Main()
        {
            bool Salida = Calcular(false, false, true);
            Console.WriteLine($"La Salida es: {Salida}");
        }
    }
}