using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract9
{
    /// <summary>
    /// Класс для работы с парой чисел
    /// </summary>
    public class PairOfNumbers : IArithmeticOperations, IComparable, ICloneable
    {
        /// <summary>
        /// Первое число пары.
        /// </summary>
        public double Number1 { get; set; }
        /// <summary>
        /// Второе число пары.
        /// </summary>
        public double Number2 { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="number1">Первое число пары</param>
        /// <param name="number2">Второе число пары</param>
        public PairOfNumbers(double number1, double number2)
        {
            Number1 = number1;
            Number2 = number2;
        }

        /// <summary>
        /// Метод сложения.
        /// </summary>
        /// <returns>Результат сложения</returns>
        public double Add() => Number1 + Number2;
        /// <summary>
        /// Метод вычитания.
        /// </summary>
        /// <returns>Результат вычитания</returns>
        public double Subtract() => Number1 - Number2;
        /// <summary>
        /// Метод умножения.
        /// </summary>
        /// <returns>Результат умножения</returns>
        public double Multiply() => Number1 * Number2;
        /// <summary>
        /// Метод деления.
        /// </summary>
        /// <returns>Результат деления</returns>
        /// <exception cref="DivideByZeroException">Если делитель равен нулю</exception>
        public double Divide()
        {
            if (Number2 == 0)
                throw new DivideByZeroException("Деление на ноль невозможно");
            return Number1 / Number2;
        }
        /// <summary>
        /// Метод сравнения
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Результат сравнения</returns>
        /// <exception cref="ArgumentException">Если объект не является парой чисел</exception>
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (obj is PairOfNumbers otherPair)
                return (Number1 + Number2).CompareTo(otherPair.Number1 + otherPair.Number2);
            else
                throw new ArgumentException("Объект не является парой чисел.");
        }
        /// <summary>
        /// Метод клонирования.
        /// </summary>
        /// <returns>Новая пара чисел</returns>
        public object Clone()
        {
            return new PairOfNumbers(Number1, Number2);
        }
    }
}
