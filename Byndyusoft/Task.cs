using System;

namespace Byndyusoft
{
    public class Task
    {
        //Напишите функцию, на вход которой приходит массив чисел.Функция возвращает сумму двух минимальных элементов массива.
        //Например, если дан массив[4, 0, 3, 19, 492, -10, 1], то результатом будет -10, потому что два минимальных числа -10 и 0, а их сумма -10.
        //Напишите минимум 3 модульных теста на эту функцию.
        //HINT: учти, что массив может быть пустым, или без цифр или состоять из 100 млн.элементов, поэтому надо учесть разные граничные условия.

        public static int Sum(params int[] numbers)  //Если диапазон допустимых значений ± 2 147 483 647.
        {
            try
            {
                if (numbers.Length > 1)
                {
                    int first = int.MaxValue;
                    int second = int.MaxValue;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (first >= numbers[i])
                        {
                            second = first;
                            first = numbers[i];
                        }
                    }
                    checked
                    {
                        return first + second;
                    }
                }
                throw new IndexOutOfRangeException("Array size must be > 2");
            }
            catch (IndexOutOfRangeException)
            {
                throw;  //Какое-либо поведение в случае неполного массива (в массиве меньше 2 элементов).
            }
            catch (NullReferenceException)
            {
                throw;  //Какое-либо поведение в случае пустой ссылки (...или пустой массив).
            }
            catch (OverflowException)
            {
                throw;  //Какое-либо поведение в случае переполнения (100 млн.элементов).
            }
            catch (Exception)
            {
                throw;  //Поведение во всех остальных случаях.
            }
        }
    }
}
