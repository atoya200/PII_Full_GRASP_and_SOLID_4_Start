//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        

        public static void Main(string[] args)
        {
            PopulateCatalogs catalogo = PopulateCatalogs.Instance;

            Recipe recipe = new Recipe();
            recipe.FinalProduct = catalogo.GetProduct("Café con leche");
            recipe.AddStep(catalogo.GetProduct("Café"), 100, catalogo.GetEquipment("Cafetera"), 120);
            recipe.AddStep(catalogo.GetProduct("Leche"), 200, catalogo.GetEquipment("Hervidor"), 60);

            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);
        }

        

        
    }
}
