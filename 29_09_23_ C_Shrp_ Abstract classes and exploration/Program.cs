
/*
 * \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\Наследование\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
 
 Вот несколько примеров наследования в языке программирования C#:

--------------------1. Пример наследования классов:--------------------
class Animal
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Name = "Fido";
        dog.Eat(); // вызывает метод из класса Animal
        dog.Bark(); // вызывает метод из класса Dog
    }
}

---------------------------2. Пример наследования интерфейсов:----------------------
interface IShape
{
    void Draw();
}

class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        circle.Draw(); // вызывает метод из интерфейса IShape

        Rectangle rectangle = new Rectangle();
        rectangle.Draw(); // вызывает метод из интерфейса IShape
    }
}

-------------------------3. Пример применения ключевых слов base и override:-----------------

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal is making a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat is meowing");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.MakeSound(); // вызывает метод из класса Animal

        Dog dog = new Dog();
        dog.MakeSound(); // вызывает метод из класса Dog, переопределенный с помощью ключевого слова override

        Cat cat = new Cat();
        cat.MakeSound(); // вызывает метод из класса Cat, переопределенный с помощью ключевого слова override
    }
}

Это только некоторые примеры наследования в языке программирования C#. С помощью наследования можно создавать 
иерархии классов и интерфейсов для организации более гибкой и структурированной архитектуры программы.
 

\\\\\\\\\\\\\\\\\\\\\\\\\\\\Перегрузка Операторов\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


В языке программирования C# можно перегружать операторы для пользовательских типов данных. Это позволяет определить, как будет выполняться операция с данными объекта при использовании соответствующего оператора. Ниже представлены примеры перегрузки некоторых операторов и их объяснение:

................................1. Перегрузка оператора сложения (+):............................

class Vector
{
    public int X { get; set; }
    public int Y { get; set; }

    public Vector(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector(2, 3);
        Vector v2 = new Vector(4, 5);

        Vector result = v1 + v2; // вызов перегруженного оператора сложения

        Console.WriteLine("Результат сложения: ({0}, {1})", result.X, result.Y);
    }
}

В данном примере определен пользовательский класс Vector, для которого перегружен оператор +.
Этот оператор складывает соответствующие координаты двух векторов и возвращает новый вектор, содержащий сумму координат.

............................2. Перегрузка оператора равенства (==) и неравенства (!=):...............................

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public static bool operator ==(Person p1, Person p2)
    {
        return p1.Name == p2.Name && p1.Age == p2.Age;
    }

    public static bool operator !=(Person p1, Person p2)
    {
        return !(p1 == p2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person("Alice", 25);
        Person p2 = new Person("Bob", 30);
        Person p3 = new Person("Alice", 25);

        bool result1 = p1 == p2; // вызов перегруженного оператора равенства
        bool result2 = p1 == p3; // вызов перегруженного оператора равенства

        Console.WriteLine("Сравнение p1 и p2: " + result1);
        Console.WriteLine("Сравнение p1 и p3: " + result2);
    }
}
В этом примере класс Person перегружает операторы равенства (==) и неравенства (!=). Оператор равенства
сравнивает имена и возраст двух объектов Person, 
а оператор неравенства просто инвертирует результат оператора равенства. 

Перегрузка операторов позволяет определить, как будет работать операция с пользовательским типом данных.
Это удобно для упрощения кода и обеспечения интуитивно понятного поведения объектов при использовании операторов.


\\\\\\\\\\\\\\\\\\\\\\Перегрузка оператора true и false/\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

В языке программирования C# можно перегрузить операторы true и false для пользовательских типов данных. Это позволяет определить,
какое булево значение будет возвращаться при использовании соответствующих операторов для объекта данного типа.
Ниже представлены примеры перегрузки операторов true и false и их объяснение:

Если описали есть перегрузка оператора true то нужно обязательно делать перегрузку оператора false!

.................................1. Перегрузка оператора true:..................................
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public static bool operator true(Person p)
    {
        return p.Age >= 18;
    }

    public static bool operator false(Person p)
    {
        return p.Age < 18;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person("Alice", 20);
        Person p2 = new Person("Bob", 16);

        if (p1) // вызов перегруженного оператора true
        {
            Console.WriteLine("{0} достигла совершеннолетия", p1.Name);
        }
        else
        {
            Console.WriteLine("{0} не достигла совершеннолетия", p1.Name);
        }

        if (p2) // вызов перегруженного оператора true
        {
            Console.WriteLine("{0} достиг совершеннолетия", p2.Name);
        }
        else
        {
            Console.WriteLine("{0} не достиг совершеннолетия", p2.Name);
        }
    }
}
В данном примере определен пользовательский класс Person, для которого перегружены операторы true и false.
Оператор true проверяет, достиг ли объект совершеннолетия (в данном случае, возраст >= 18), и возвращает 
соответствующее булево значение. Оператор false выполняет обратную проверку на совершеннолетие.


...........................2. Перегрузка оператора false с использованием метода !:............................

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public static bool operator true(Person p)
    {
        return p.Age >= 18;
    }

    public static bool operator false(Person p)
    {
        return !(p.Age >= 18);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person("Alice", 20);
        Person p2 = new Person("Bob", 16);

        if (!p1) // вызов перегруженного оператора false с использованием метода !
        {
            Console.WriteLine("{0} не достигла совершеннолетия", p1.Name);
        }
        else
        {
            Console.WriteLine("{0} достигла совершеннолетия", p1.Name);
        }

        if (!p2) // вызов перегруженного оператора false с использованием метода !
        {
            Console.WriteLine("{0} не достиг совершеннолетия", p2.Name);
        }
        else
        {
            Console.WriteLine("{0} достиг совершеннолетия", p2.Name);
        }
    }
}
В этом примере класс Person также перегружает операторы true и false, но в операторе false используется метод !
для инвертирования результата оператора true. 

Перегрузка операторов true и false позволяет определить, какое булево значение будет возвращаться для объекта 
данного типа при использовании операторов if и !. 
Это удобно для управления логикой проверки объекта на истинность или ложность.


................ Абстрактные классы динамический полиморфизм ...........................

Да, в языке программирования C# есть динамический полиморфизм, который достигается с помощью механизма 
виртуальных методов и переопределения.

Для создания динамического полиморфизма в C# используются следующие ключевые слова и механизмы:


..........................1. virtual и override: Мы можем объявить метод в базовом классе ...............................
                                  с использованием ключевого слова virtual, 
чтобы он мог быть переопределен в производном классе с помощью ключевого слова override. При вызове такого
метода у объекта базового класса будет вызываться переопределенная версия метода в производном классе.

Пример:
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal1 = new Dog(); // создание объекта производного класса через ссылку базового класса
        animal1.MakeSound(); // вызов переопределенного метода из класса Dog

        Animal animal2 = new Cat(); // создание объекта производного класса через ссылку базового класса
        animal2.MakeSound(); // вызов переопределенного метода из класса Cat
    }
}

.........................2. Абстрактные классы и виртуальные свойства: ....................................
Мы можем объявить абстрактный класс с виртуальными методами или свойствами. 
Дочерние классы должны реализовать или переопределить эти методы или свойства.
При вызове метода или доступе к свойству через ссылку на базовый абстрактный класс будет 
вызываться реализация из производного класса.

Пример:
abstract class Shape
{
    public abstract void Draw();
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape shape1 = new Circle(); // создание объекта производного класса через ссылку абстрактного класса
        shape1.Draw(); // вызов переопределенного метода из класса Circle

        Shape shape2 = new Rectangle(); // создание объекта производного класса через ссылку абстрактного класса
        shape2.Draw(); // вызов переопределенного метода из класса Rectangle
    }
}

Использование данных механизмов позволяет достичь динамического полиморфизма в C#,
где во время выполнения определяется вызываемая версия метода или свойства на основе типа объекта,
а не типа ссылки на объект. 
Это позволяет обеспечить гибкость и расширяемость кода при работе с объектами разных типов из одной иерархии классов.

..................В языке C# ключевое слово sealed используется...........................

В языке программирования C# ключевое слово sealed используется для запрета дальнейшего наследования от класса 
или переопределения методов/свойств в дочерних классах. Помечая класс или член класса как sealed, мы ограничиваем 
его доступность только в рамках текущего класса, и запрещаем его использование или изменение в будущих производных классах.

Вот примеры использования sealed в C#:

1. Запрет наследования от класса:
sealed class MyClass
{
    // Код класса
}

class DerivedClass : MyClass // Ошибка компиляции, запрещено наследование от sealed класса
{
    // Код производного класса
}

В данном примере класс MyClass помечен как sealed, поэтому нельзя создать производный класс DerivedClass от MyClass.
Попытка наследования приведет к ошибке компиляции.

2. Запрет переопределения метода или свойства:
class BaseClass
{
    public virtual void MyMethod()
    {
        // Реализация метода
    }
}

class DerivedClass : BaseClass
{
    public sealed override void MyMethod()
    {
        // Переопределенная реализация метода
    }
}

class GrandChildClass : DerivedClass
{
    public override void MyMethod() // Ошибка компиляции, запрещено переопределение sealed метода
    {
        // Реализация метода
    }
}

В этом примере метод MyMethod в классе DerivedClass переопределен с ключевыми словами sealed override,
что означает, что дальнейшее переопределение в дочерних классах будет запрещено. В классе GrandChildClass 
попытка переопределения приведет к ошибке компиляции.

3. Запрет переопределения свойства:
class BaseClass
{
    public virtual int MyProperty { get; set; }
}

class DerivedClass : BaseClass
{
    public sealed override int MyProperty
    {
        get { return base.MyProperty; }
        set { base.MyProperty = value; }
    }
}

class GrandChildClass : DerivedClass
{
    public override int MyProperty // Ошибка компиляции, запрещено переопределение sealed свойства
    {
        get { return base.MyProperty; }
        set { base.MyProperty = value; }
    }
}

 */


/*
 Задача 1 
 Создать класс матрица. Переопреледлить операторы +. и -. 
 для двух матриц.




 */
using System.Diagnostics.CodeAnalysis;

namespace _29_09_23__C_Shrp__Abstract_classes_and_exploration
{
    //class Matrix
    //{
    //    public int rows{ get; set; }
    //    public int collumns { get; set; }
    //    public int[,] data { get; set; }

    //    public Matrix(int rows, int collumns)
    //    {
    //        this.rows = rows;
    //        this.collumns = collumns;
    //        this.data = new int[rows, collumns];
    //    }
    //    public int this[ int row, int coll]
    //    {
    //        get { return this[row, coll]; }
    //        set { this[row, coll] = value; }
    //    }
    //   public static Matrix operator +(Matrix m1, Matrix m2)
    //    {
    //        Matrix result = new Matrix(m1.rows, m1.collumns);

    //        for (int i = 0; i < m1.rows; i++)
    //        {
    //            for (int j = 0; j < m1.collumns; j++)
    //            {
    //                result[i,j] = m1[i,j] + m2[i,j];
    //            }
    //            Console.WriteLine();
    //        }
    //        return result;
    //    }

    //    public static Matrix operator -(Matrix m1, Matrix m2)
    //    {
    //        Matrix result = new Matrix(m1.rows, m1.collumns);

    //        for (int i = 0; i < m1.rows; i++)
    //        {
    //            for (int j = 0; j < m1.collumns; j++)
    //            {
    //                result[i, j] = m1[i, j] - m2[i, j];
    //            }
    //            Console.WriteLine();
    //        }
    //        return result;
    //    }
    //}
   public abstract class Human
    {
        public string? Name { get; set; }
        public string? Age { get; set; }
                
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }    

    public class Worker : Human
    {
        public double salary { get; set; }
        public static double operator +(Worker worker1, Worker worker2)
        {
            double totalSalary = worker1.salary + worker2.salary;
            return totalSalary;
        }

    }

    // Перегрузка оператора "+" для расчета зарплаты

    class Bilder : Human
    { 
       
        public override void MakeSound()
        {
            Console.WriteLine("The 222222222222222animal makes a sound");
        }
    }

    class Sailor : Human
    {
        public string? Name1 { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("The 33333333333animal makes a sound");
        }
    }

    class Pilot : Human
    {
        public string? Name1 { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("The 111111111111animal makes a sound");
        }
    }

        internal class Program
        {
            static void Main(string[] args)
            {
                //Matrix m1 = new Matrix(2, 2);
                //m1[0, 0] = 1;
                //m1[0, 1] = 2;
                //m1[1, 0] = 3;
                //m1[1, 1] = 4;

                //Matrix m2 = new Matrix(2, 2);
                //m2[0, 0] = 5;
                //m2[0, 1] = 6;
                //m2[1, 0] = 7;
                //m2[1, 1] = 8;
                //Console.WriteLine($"Hello, World! {m1 + m2}");
                //Console.WriteLine($"Hello, World! {m1 - m2}");


                Human human1 = new Sailor(); // создание объекта производного класса через ссылку базового класса
                human1.MakeSound(); // вызов переопределенного метода из класса 

                Human human2 = new Pilot(); // создание объекта производного класса через ссылку базового класса
                human2.MakeSound(); // вызов переопределенного метода из класса 

                Human human3 = new Bilder(); // создание объекта производного класса через ссылку базового класса
                human3.MakeSound(); // вызов переопределенного метода из класса 

            }

        }  
}