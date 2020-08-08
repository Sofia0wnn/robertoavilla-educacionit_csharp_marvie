﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Personajes
{
    public class JugadorNaturaleza: Personaje
    {
        public JugadorNaturaleza(string nombre) : base(nombre)
        {

        }
        public override void Mover()
        {
            PosicionX += 1;
            PosicionY += 2;
        }
    }
}
