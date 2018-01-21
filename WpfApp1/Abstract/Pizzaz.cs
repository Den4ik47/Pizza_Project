using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Abstract
{
    abstract class Pizzaz
    {
        public string Name { get; protected set; }
        public Pizzaz(string n) {
            Name = n;
        }
        abstract public int GetCost();
    }
    class SmallCheapiest:Pizzaz{
        public SmallCheapiest(string n) : base(n) { }
        public override int GetCost()
        {
            return 10;
        }
    }
    class MiddleCheapiest : Pizzaz
    {
        public MiddleCheapiest(string n) : base(n) { }
        public override int GetCost()
        {
            return 20;
        }
    }
    class BigCheapiest : Pizzaz
    {
        public BigCheapiest(string n) : base(n) { }
        public override int GetCost()
        {
            return 30;
        }
    }
    class SmallNormal : Pizzaz
    {
        public SmallNormal(string n) : base(n) { }
        public override int GetCost()
        {
            return 20;
        }
    }
    class MiddleNormal : Pizzaz
    {
        public MiddleNormal(string n) : base(n) { }
        public override int GetCost()
        {
            return 30;
        }
    }
    class BigNormal : Pizzaz
    {
        public BigNormal(string n) : base(n) { }
        public override int GetCost()
        {
            return 40;
        }
    }
    class SmallExpensive : Pizzaz
    {
        public SmallExpensive(string n) : base(n) { }
        public override int GetCost()
        {
            return 30;
        }
    }
    class MiddleExpensive : Pizzaz
    {
        public MiddleExpensive(string n) : base(n) { }
        public override int GetCost()
        {
            return 40;
        }
    }
    class BigExpensive : Pizzaz
    {
        public BigExpensive(string n) : base(n) { }
        public override int GetCost()
        {
            return 50;
        }
    }
  abstract  class PizzaDecorator:Pizzaz {
        protected Pizzaz pizza;
        public PizzaDecorator(string n, Pizzaz pizz) : base(n) { this.pizza = pizz; }

    }
    class Corn : PizzaDecorator {
        public Corn(Pizzaz p) : base(p.Name + " , Corn", p) { }

        public override int GetCost()
        {
            return 5;
        }
    }
    class Tomato : PizzaDecorator
    {
        public Tomato(Pizzaz p) : base(p.Name + " , Tomate", p) { }

        public override int GetCost()
        {
            return 3;
        }
    }
    class Pepe : PizzaDecorator
    {
        public Pepe(Pizzaz p) : base(p.Name + " , Peperoni", p) { }

        public override int GetCost()
        {
            return 7;
        }
    }
    class Wolowina : PizzaDecorator
    {
        public Wolowina(Pizzaz p) : base(p.Name + " , Wolowina", p) { }

        public override int GetCost()
        {
            return 8;
        }
    }
    class Chesse : PizzaDecorator
    {
        public Chesse(Pizzaz p) : base(p.Name + " , Chesse", p) { }

        public override int GetCost()
        {
            return 2;
        }
        class Szynka : PizzaDecorator
        {
            public Szynka(Pizzaz p) : base(p.Name + " , Szynka", p) { }

            public override int GetCost()
            {
                return 3;
            }
        }

    }

}
