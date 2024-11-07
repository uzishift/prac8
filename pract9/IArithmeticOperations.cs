using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract9
{
    /// <summary>
    /// Интерфейс для выполнения арифметических операций
    /// </summary>
    public interface IArithmeticOperations
    {
        /// <summary>
        /// Метод сложения.
        /// </summary>
        /// <returns>double</returns>
        double Add();
        /// <summary>
        /// Метод вычитания.
        /// </summary>
        /// <returns>double</returns>
        double Subtract();
        /// <summary>
        /// Метод умножения.
        /// </summary>
        /// <returns>double</returns>
        double Multiply();
        /// <summary>
        /// Медот деления.
        /// </summary>
        /// <returns>double</returns>
        double Divide();
    }
}
