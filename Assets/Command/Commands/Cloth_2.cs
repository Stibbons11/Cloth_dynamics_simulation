using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern
{
    public class Cloth_2 : Command
    {
        private Clothes clothes;
  
        public Cloth_2(Clothes clothes)
        {
            this.clothes = clothes;
        }


        public override void Execute()
        {
            clothes.Cloth2();

        }

    }
}