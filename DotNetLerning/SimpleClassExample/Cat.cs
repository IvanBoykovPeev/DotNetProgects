using System;

namespace SimpleClassExample
{
    class Cat
    {
        //Field name
        public string name;
        //Field color
        public string color;

        public string Name
        {
            //Getter of the property "Name"
            get 
            {
                return this.name;
            }
            //Setter of the property "Name"
            set
            {
                this.name = value;
            }
        }

        public string Color
        {
            //Getter of the property "Color"
            get
            {
                return this.color;
            }
            //Setter of the property "Color"
            set
            {
                this.color = value;
            }
        }

        //Default constructor
        public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
        }

        //Constructor with parameters
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color; 
        }

        //Method SayMiau
        public void SayMiau()
        {
            Console.WriteLine("Cat {0} said: Miauuuuuuuuu!", name);
        }
    }
}
